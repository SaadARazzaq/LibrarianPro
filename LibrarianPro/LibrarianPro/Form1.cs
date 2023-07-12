using System;
using System.IO;
using System.Windows.Forms;

namespace F200220__Mini_Project
{
    public partial class Form1 : Form
    {
        public static string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string fileName = filename_textBox.Text.Trim(); // Getting the filename from the text box

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid filename.");
                return;
            }

            // Path.Combine is used to concatenate the "My Documents" folder path with the desired folder name to form the complete folder path.The Directory.Exists method is used to check if the folder already exists, and if not, the Directory.CreateDirectory method is called to create the folder.
            string folderName = "LibrarianPro__Folder";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, fileName + ".txt");

            if (File.Exists(filePath))
            {
                MessageBox.Show("File already exists.");
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Perform any necessary writing to the file here
                }

                MessageBox.Show("File is created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating the file: " + ex.Message);
            }
        }


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

        private void delete_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_Form f4 = new delete_Form();
            f4.ShowDialog();
        }

        private void update_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Form f4 = new Update_Form();
            f4.ShowDialog();
        }
    }
}
