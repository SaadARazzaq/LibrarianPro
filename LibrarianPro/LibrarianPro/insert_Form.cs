using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace F200220__Mini_Project
{
    public partial class insert_Form : Form
    {
        public insert_Form()
        {
            InitializeComponent();
        }

        private void insert_Form_Load(object sender, EventArgs e)
        {
            // Path.Combine is used to concatenate the "My Documents" folder path with the desired folder name to form the complete folder path.The Directory.Exists method is used to check if the folder already exists, and if not, the Directory.CreateDirectory method is called to create the folder.
            string folderName = "LibrarianPro__Folder";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Get the file names in the folder
            string[] fileNames = Directory.GetFiles(folderPath, "*.txt").Select(Path.GetFileName).ToArray();

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("File Name", typeof(string));

            // Add each file name to the DataTable
            foreach (string fileName in fileNames)
            {
                dataTable.Rows.Add(fileName);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Not implemented for this example
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Insert_label_Click(object sender, EventArgs e)
        {
            // Not implemented for this example
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected file name from the DataGridView
                string fileName = dataGridView1.SelectedRows[0].Cells["File Name"].Value.ToString();

                // Path.Combine is used to concatenate the "My Documents" folder path with the desired folder name to form the complete folder path.The Directory.Exists method is used to check if the folder already exists, and if not, the Directory.CreateDirectory method is called to create the folder.
                string folderName = "LibrarianPro__Folder";
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Construct the full file path
                string filePath = Path.Combine(folderPath, fileName);

                // Open the file in append mode and create a StreamWriter to write data to it
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    // Prompt the user to enter data for the selected file
                    string bookTitle = title_textBox.Text;
                    string bookAuthor = author_textBox.Text;
                    string bookISBN = isbn_textBox.Text;
                    string bookCopies = copies_textBox.Text;

                    // Validate the inputs
                    if (!IsValidAuthor(bookAuthor))
                    {
                        MessageBox.Show("Author name can only contain alphabets.");
                        return;
                    }

                    if (!IsValidCopies(bookCopies))
                    {
                        MessageBox.Show("Number of copies can only contain numbers.");
                        return;
                    }

                    // Write the book information to the file
                    writer.WriteLine($"{bookTitle},{bookAuthor},{bookISBN},{bookCopies}");
                    writer.WriteLine();

                    MessageBox.Show("Book information added to the file: " + fileName);
                }
            }
            else
            {
                MessageBox.Show("Please select a file from the grid.");
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will clear your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                insert_Form f1 = new insert_Form();
                f1.ShowDialog();
            }
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

        private void author_textBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the author name input
            string input = author_textBox.Text;
            if (!IsValidAuthor(input))
            {
                // Show an error message and remove invalid characters
                MessageBox.Show("Author name can only contain alphabets.");
                author_textBox.Text = RemoveInvalidCharacters(input);
            }
        }

        private void copies_textBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the number of copies input
            string input = copies_textBox.Text;
            if (!IsValidCopies(input))
            {
                // Show an error message and remove invalid characters
                MessageBox.Show("Number of copies can only contain numbers.");
                copies_textBox.Text = RemoveInvalidCharacters(input);
            }
        }

        // Helper method to check if the author name is valid (contains only alphabets)
        private bool IsValidAuthor(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        // Helper method to check if the number of copies is valid (contains only numbers)
        private bool IsValidCopies(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]+$");
        }

        // Helper method to remove invalid characters from the input
        private string RemoveInvalidCharacters(string input)
        {
            return Regex.Replace(input, @"[^a-zA-Z0-9]", "");
        }
    }
}
