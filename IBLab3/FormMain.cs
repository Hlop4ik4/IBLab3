using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace IBLab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChooseSourceFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxSourceFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChooseDecryptFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxDecryptFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChooseEncryptFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxEncryptFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChoosePasswordFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxPasswordFilePath.Text = openFileDialog1.FileName;
        }

        private void radioButtonManualPassword_CheckedChanged(object sender, EventArgs e)
        {
            SwitchPasswordInputMethod();
        }

        private void radioButtonChoosePasswordFile_CheckedChanged(object sender, EventArgs e)
        {
            SwitchPasswordInputMethod();
        }

        private void SwitchPasswordInputMethod()
        {
            buttonChoosePasswordFile.Enabled = radioButtonChoosePasswordFile.Checked;
            textBoxManualPassword.Enabled = radioButtonManualPassword.Checked;
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Ошибка при освобождении объекта: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private string ExtractPassword()
        {
            string password = null;
            if (radioButtonManualPassword.Checked)
            {
                password = textBoxManualPassword.Text;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(this, "Не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                string passwordFile = textBoxPasswordFilePath.Text;
                if (string.IsNullOrEmpty(passwordFile))
                {
                    MessageBox.Show(this, "Не выбран файл с паролем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                try
                {
                    // Загружаем текстовые файлы (Word, Excel) с помощью соответствующих библиотек
                    if (passwordFile.EndsWith(".doc") || passwordFile.EndsWith(".docx"))
                    {
                        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                        Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(passwordFile);
                        string text = wordDoc.Content.Text;
                        wordDoc.Close();
                        wordApp.Quit();

                        password = Regex.Replace(text, @"[\u0000-\u001F\u007F-\u0084\u0086-\u009F]", string.Empty);

                    }
                    else if (passwordFile.EndsWith(".xls") || passwordFile.EndsWith(".xlsx"))
                    {
                        // Создание экземпляра приложения Excel
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                        // Открытие книги Excel
                        Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(passwordFile);

                        // Чтение данных
                        Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
                        Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;

                        int rowCount = range.Rows.Count;
                        int columnCount = range.Columns.Count;

                        StringBuilder stringBuilder = new StringBuilder();

                        for (int row = 1; row <= rowCount; row++)
                        {
                            for (int column = 1; column <= columnCount; column++)
                            {
                                // Получение значения ячейки
                                string value = range.Cells[row, column].Value?.ToString();

                                stringBuilder.Append(value);
                                stringBuilder.Append('\t'); // Добавляем разделитель между значениями
                            }

                            stringBuilder.AppendLine(); // Добавляем перевод строки после каждой строки
                        }

                        string text = stringBuilder.ToString();
                        password = Regex.Replace(text, @"[\u0000-\u001F\u007F-\u0084\u0086-\u009F]", string.Empty);


                        // Закрытие и освобождение ресурсов
                        workbook.Close();
                        excelApp.Quit();

                        ReleaseObject(worksheet);
                        ReleaseObject(workbook);
                        ReleaseObject(excelApp);
                    }
                    else if (passwordFile.EndsWith(".txt"))
                    {
                        password = File.ReadAllText(passwordFile, Encoding.UTF8);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Ошибка загрузки пароля из файла:\n" + e.Message, "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                    return null;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(this, "В файле не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return password;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string sourceFilePath = textBoxSourceFilePath.Text;
            if (string.IsNullOrEmpty(sourceFilePath))
            {
                MessageBox.Show(this, "Не выбран исходный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string encodedFilePath = textBoxEncryptFilePath.Text;
            if (string.IsNullOrEmpty(encodedFilePath))
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            DESECB algorithmRealisation = new DESECB();
            byte[] byte_result = algorithmRealisation.Encrypt(sourceFilePath, password);
            string string_result = Encoding.ASCII.GetString(byte_result);

            string filePath = encodedFilePath;

            // Сохраняем текстовые файлы (Word, Excel) с помощью соответствующих библиотек
            if (filePath.EndsWith(".doc") || filePath.EndsWith(".docx"))
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
                wordDoc.Content.Text = string_result.Replace('\x00', ' ');
                wordDoc.SaveAs2(filePath);
                wordDoc.Close();
                wordApp.Quit();
            }
            else if (filePath.EndsWith(".xls") || filePath.EndsWith(".xlsx"))
            {
                // Создание документа Excel
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                {
                    // Добавление рабочего листа
                    WorkbookPart workbookPart = document.AddWorkbookPart();
                    workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(new SheetData());

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbookPart.Workbook.AppendChild(new
DocumentFormat.OpenXml.Spreadsheet.Sheets());
                    Sheet sheet = new Sheet()
                    {
                        Id = workbookPart.GetIdOfPart(worksheetPart),
                        SheetId = 1,
                        Name = "Sheet1"
                    };
                    sheets.Append(sheet);

                    // Создание ячейки с данными
                    Cell cell = new Cell()
                    {
                        DataType = CellValues.String,
                        CellValue = new CellValue(string_result.Replace('\x00', ' '))
                    };

                    // Создание строки с ячейкой
                    Row row = new Row();
                    row.Append(cell);

                    // Добавление строки в таблицу
                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                    sheetData.Append(row);

                    // Сохранение документа
                    workbookPart.Workbook.Save();
                }
            }
            else if (filePath.EndsWith(".txt"))
            {
                File.WriteAllBytes(filePath, Encoding.ASCII.GetBytes(string_result));
            }

            DialogResult result = MessageBox.Show("Файл зашифрован. Открыть файл?", "Информация", MessageBoxButtons.YesNo,
MessageBoxIcon.Information);
            // Проверить ответ пользователя
            if (result == DialogResult.Yes)
            {
                // Открыть файл в ассоциированной программе
                Process.Start(encodedFilePath);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string encodedFilePath = textBoxSourceFilePath.Text;
            if (string.IsNullOrEmpty(encodedFilePath))
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string decodedFilePath = textBoxDecryptFilePath.Text;
            if (string.IsNullOrEmpty(decodedFilePath))
            {
                MessageBox.Show(this, "Не выбран расшифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            DESECB algorithmRealisation = new DESECB();
            byte[] byte_result = algorithmRealisation.Decrypt(encodedFilePath, password);
            string string_result = Encoding.ASCII.GetString(byte_result);

            string filePath = decodedFilePath;

            // Сохраняем текстовые файлы (Word, Excel) с помощью соответствующих библиотек
            if (filePath.EndsWith(".doc") || filePath.EndsWith(".docx"))
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
                wordDoc.Content.Text = string_result.Replace('\x00', ' ');
                wordDoc.SaveAs2(filePath);
                wordDoc.Close();
                wordApp.Quit();
            }
            else if (filePath.EndsWith(".xls") || filePath.EndsWith(".xlsx"))
            {
                // Создание документа Excel
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                {
                    // Добавление рабочего листа
                    WorkbookPart workbookPart = document.AddWorkbookPart();
                    workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(new SheetData());

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbookPart.Workbook.AppendChild(new
DocumentFormat.OpenXml.Spreadsheet.Sheets());
                    Sheet sheet = new Sheet()
                    {
                        Id = workbookPart.GetIdOfPart(worksheetPart),
                        SheetId = 1,
                        Name = "Sheet1"
                    };
                    sheets.Append(sheet);

                    // Создание ячейки с данными
                    Cell cell = new Cell()
                    {
                        DataType = CellValues.String,
                        CellValue = new CellValue(string_result.Replace('\x00', ' '))
                    };

                    // Создание строки с ячейкой
                    Row row = new Row();
                    row.Append(cell);

                    // Добавление строки в таблицу
                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                    sheetData.Append(row);

                    // Сохранение документа
                    workbookPart.Workbook.Save();
                }
            }
            else if (filePath.EndsWith(".txt"))
            {
                File.WriteAllBytes(filePath, Encoding.ASCII.GetBytes(string_result));
            }

            DialogResult result = MessageBox.Show("Файл расшифрован. Открыть файл?", "Информация", MessageBoxButtons.YesNo,
MessageBoxIcon.Information);
            // Проверить ответ пользователя
            if (result == DialogResult.Yes)
            {
                // Открыть файл в ассоциированной программе
                Process.Start(decodedFilePath);
            }
        }

        private void справочнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Алгоритм DES в режиме ECB. Описание алгоритма: исходный файл разбивается на 64-битовые блоки.\n" +

                            "Каждый из этих блоков кодируется независимо от других блоков с использованием одного и того же ключа шифрования.\n" +

                            "Данный режим является самым простым режимом, при котором незашифрованный текст обрабатывается последовательно(блок за блоком).\n" +

                            "Если исходный текст длиннее, чем длина блока соответствующего алгоритма, то он разбивается на блоки соответствующей длины, причем последний блок дополняется в случае необходимости фиксированными значениями.\n" +

                            "Преимуществом алгоритма является возможность распараллеливания вычислений.\n", "Справочная информация",

                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №3. Изучение криптографических алгоритмов. " +

                            "Алгоритмы шифрования.\n" +

                            "Вариант 15: Алгоритм DES в режиме ECB (Electronic Codebook) - электронный шифроблокнот.", "Задание",

                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void кемВыполненноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил:\n" +

                           "студент группы ИСЭбд-41 Мутрисков Данила\n", "Кем выполненно",

                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
