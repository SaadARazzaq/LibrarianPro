using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace F200220__Mini_Project
{
    public partial class delete_Form : Form
    {
        public class Book
        {
            public string FileName { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int Copies { get; set; }
        }

        private List<Book> books; // Store the books data

        public delete_Form()
        {
            InitializeComponent();
        }

        // ...

        private void delete_Form_Load(object sender, EventArgs e)
        {
            // Path.Combine is used to concatenate the "My Documents" folder path with the desired folder name to form the complete folder path.The Directory.Exists method is used to check if the folder already exists, and if not, the Directory.CreateDirectory method is called to create the folder.
            string folderName = "LibrarianPro__Folder";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Create a list to hold the book data
            books = new List<Book>();

            // Retrieve the file names in the folder
            string[] fileNames = Directory.GetFiles(folderPath);

            // Read data from each file and create Book objects
            foreach (string fileName in fileNames)
            {
                string[] lines = File.ReadAllLines(fileName);

                // Check if the file contains at least 1 line (minimum required for a book entry)
                if (lines.Length >= 1)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');

                        // Check if the data array has 4 elements (minimum required for a book entry)
                        if (data.Length >= 4)
                        {
                            Book book = new Book
                            {
                                FileName = Path.GetFileName(fileName),
                                Title = data[0].Trim(),
                                Author = data[1].Trim(),
                                ISBN = data[2].Trim(),
                                Copies = int.Parse(data[3].Trim())
                            };

                            books.Add(book);
                        }
                    }
                }
            }

            // Bind the list of books to the DataGridView
            dataGridView1.DataSource = books;
        }

        // ...


        private void home_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Insert_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            insert_Form f2 = new insert_Form();
            f2.ShowDialog();
        }

        private void view_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            read_Form f3 = new read_Form();
            f3.ShowDialog();
        }

        private void update_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Form f4 = new Update_Form();
            f4.ShowDialog();
        }

        private void delete_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_Form f4 = new delete_Form();
            f4.ShowDialog();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DeleteBookFromFile(string fileName, string bookTitle)
        {
            // Path.Combine is used to concatenate the "My Documents" folder path with the desired folder name to form the complete folder path.The Directory.Exists method is used to check if the folder already exists, and if not, the Directory.CreateDirectory method is called to create the folder.
            string folderName = "LibrarianPro__Folder";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Find the file path for the book
            string filePath = Path.Combine(folderPath, fileName);

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Create a list to hold the updated lines
            List<string> updatedLines = new List<string>();

            // Iterate through the lines and remove the book entry
            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data.Length >= 4 && data[0].Trim().Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    // Skip this line (book entry)
                    continue;
                }

                updatedLines.Add(line);
            }

            // Write the updated lines back to the file
            File.WriteAllLines(filePath, updatedLines);
        }


        private void Delete_button_Click(object sender, EventArgs e)
        {
            string title = BookName_textBox.Text.Trim();
            bool bookFound = false;
            Book bookToRemove = null;

            // Find the book to remove from the list
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    bookToRemove = book;
                    bookFound = true;
                    break;
                }
            }

            if (bookFound && bookToRemove != null)
            {
                // Remove the book from the list
                books.Remove(bookToRemove);

                // Update the grid by setting the data source again
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = books;

                // Delete the book from the file
                DeleteBookFromFile(bookToRemove.FileName, bookToRemove.Title);

                MessageBox.Show("Book deleted successfully.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book is not available.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
