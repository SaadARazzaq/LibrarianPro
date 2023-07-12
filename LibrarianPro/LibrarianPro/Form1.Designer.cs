
namespace F200220__Mini_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_label = new System.Windows.Forms.Label();
            this.delete_label = new System.Windows.Forms.Label();
            this.update_label = new System.Windows.Forms.Label();
            this.view_label = new System.Windows.Forms.Label();
            this.Insert_label = new System.Windows.Forms.Label();
            this.home_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.fileName_label = new System.Windows.Forms.Label();
            this.filename_textBox = new System.Windows.Forms.MaskedTextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.logo_label);
            this.panel1.Controls.Add(this.delete_label);
            this.panel1.Controls.Add(this.update_label);
            this.panel1.Controls.Add(this.view_label);
            this.panel1.Controls.Add(this.Insert_label);
            this.panel1.Controls.Add(this.home_label);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 1035);
            this.panel1.TabIndex = 0;
            // 
            // logo_label
            // 
            this.logo_label.AutoSize = true;
            this.logo_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_label.ForeColor = System.Drawing.Color.Black;
            this.logo_label.Location = new System.Drawing.Point(45, 903);
            this.logo_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logo_label.Name = "logo_label";
            this.logo_label.Size = new System.Drawing.Size(281, 90);
            this.logo_label.TabIndex = 4;
            this.logo_label.Text = "Developed By:\r\nSamuraiSyntax";
            // 
            // delete_label
            // 
            this.delete_label.AutoSize = true;
            this.delete_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_label.ForeColor = System.Drawing.Color.White;
            this.delete_label.Location = new System.Drawing.Point(34, 533);
            this.delete_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.delete_label.Name = "delete_label";
            this.delete_label.Size = new System.Drawing.Size(145, 53);
            this.delete_label.TabIndex = 3;
            this.delete_label.Text = "Delete";
            this.delete_label.Click += new System.EventHandler(this.delete_label_Click);
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_label.ForeColor = System.Drawing.Color.White;
            this.update_label.Location = new System.Drawing.Point(30, 409);
            this.update_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.update_label.Name = "update_label";
            this.update_label.Size = new System.Drawing.Size(159, 53);
            this.update_label.TabIndex = 3;
            this.update_label.Text = "Update";
            this.update_label.Click += new System.EventHandler(this.update_label_Click);
            // 
            // view_label
            // 
            this.view_label.AutoSize = true;
            this.view_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_label.ForeColor = System.Drawing.Color.White;
            this.view_label.Location = new System.Drawing.Point(30, 275);
            this.view_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.view_label.Name = "view_label";
            this.view_label.Size = new System.Drawing.Size(254, 53);
            this.view_label.TabIndex = 3;
            this.view_label.Text = "View / Read";
            this.view_label.Click += new System.EventHandler(this.view_label_Click);
            // 
            // Insert_label
            // 
            this.Insert_label.AutoSize = true;
            this.Insert_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_label.ForeColor = System.Drawing.Color.White;
            this.Insert_label.Location = new System.Drawing.Point(30, 161);
            this.Insert_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Insert_label.Name = "Insert_label";
            this.Insert_label.Size = new System.Drawing.Size(129, 53);
            this.Insert_label.TabIndex = 2;
            this.Insert_label.Text = "Insert";
            this.Insert_label.Click += new System.EventHandler(this.Insert_label_Click);
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.ForeColor = System.Drawing.Color.White;
            this.home_label.Location = new System.Drawing.Point(30, 46);
            this.home_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(138, 53);
            this.home_label.TabIndex = 1;
            this.home_label.Text = "Home";
            this.home_label.Click += new System.EventHandler(this.home_label_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.Transparent;
            this.welcome_label.Location = new System.Drawing.Point(625, 80);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(724, 315);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "    Welcome \r\n         To\r\nLibrarianPro";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fileName_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName_label.ForeColor = System.Drawing.Color.White;
            this.fileName_label.Location = new System.Drawing.Point(487, 616);
            this.fileName_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(278, 46);
            this.fileName_label.TabIndex = 2;
            this.fileName_label.Text = "Enter File Name:";
            // 
            // filename_textBox
            // 
            this.filename_textBox.BackColor = System.Drawing.Color.White;
            this.filename_textBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_textBox.ForeColor = System.Drawing.Color.Black;
            this.filename_textBox.Location = new System.Drawing.Point(495, 691);
            this.filename_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.filename_textBox.Name = "filename_textBox";
            this.filename_textBox.Size = new System.Drawing.Size(392, 47);
            this.filename_textBox.TabIndex = 3;
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_button.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.create_button.ForeColor = System.Drawing.Color.White;
            this.create_button.Location = new System.Drawing.Point(929, 691);
            this.create_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(276, 63);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_button.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(1778, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(104, 91);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::F200220__Mini_Project.Properties.Resources.library_1024x683;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1878, 1031);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.filename_textBox);
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.Label Insert_label;
        private System.Windows.Forms.Label delete_label;
        private System.Windows.Forms.Label update_label;
        private System.Windows.Forms.Label view_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.MaskedTextBox filename_textBox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label logo_label;
    }
}

