namespace Anket2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Anket = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            Date = new Label();
            Add = new Button();
            Change = new Button();
            Save = new Button();
            Load = new Button();
            fileTextBox = new TextBox();
            listBox1 = new ListBox();
            phoneTextBox = new TextBox();
            Phone = new Label();
            emailTextBox = new TextBox();
            Email = new Label();
            surnameTextBox = new TextBox();
            Surname = new Label();
            nameTextBox = new TextBox();
            Name = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            Anket.SuspendLayout();
            SuspendLayout();
            // 
            // Anket
            // 
            Anket.Controls.Add(dateTimePicker1);
            Anket.Controls.Add(Date);
            Anket.Controls.Add(Add);
            Anket.Controls.Add(Change);
            Anket.Controls.Add(Save);
            Anket.Controls.Add(Load);
            Anket.Controls.Add(fileTextBox);
            Anket.Controls.Add(listBox1);
            Anket.Controls.Add(phoneTextBox);
            Anket.Controls.Add(Phone);
            Anket.Controls.Add(emailTextBox);
            Anket.Controls.Add(Email);
            Anket.Controls.Add(surnameTextBox);
            Anket.Controls.Add(Surname);
            Anket.Controls.Add(nameTextBox);
            Anket.Controls.Add(Name);
            Anket.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Anket.Location = new Point(40, 1);
            Anket.Name = "Anket";
            Anket.Padding = new Padding(10);
            Anket.Size = new Size(658, 448);
            Anket.TabIndex = 0;
            Anket.TabStop = false;
            Anket.Text = "Anket";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(114, 316);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(39, 319);
            Date.Name = "Date";
            Date.Size = new Size(49, 25);
            Date.TabIndex = 14;
            Date.Text = "Date";
            // 
            // Add
            // 
            Add.Location = new Point(152, 403);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 13;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Change
            // 
            Change.Location = new Point(152, 363);
            Change.Name = "Change";
            Change.Size = new Size(112, 34);
            Change.TabIndex = 12;
            Change.Text = "Change";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Save
            // 
            Save.Location = new Point(534, 362);
            Save.Name = "Save";
            Save.Size = new Size(76, 34);
            Save.TabIndex = 11;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Load
            // 
            Load.Location = new Point(430, 362);
            Load.Name = "Load";
            Load.Size = new Size(79, 34);
            Load.TabIndex = 10;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(430, 313);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.PlaceholderText = "File Name";
            fileTextBox.Size = new Size(180, 31);
            fileTextBox.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(315, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 254);
            listBox1.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(114, 244);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(150, 31);
            phoneTextBox.TabIndex = 7;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(36, 244);
            Phone.Name = "Phone";
            Phone.Size = new Size(62, 25);
            Phone.TabIndex = 6;
            Phone.Text = "Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(114, 177);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(36, 177);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(114, 112);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(150, 31);
            surnameTextBox.TabIndex = 3;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(26, 115);
            Surname.Name = "Surname";
            Surname.Size = new Size(82, 25);
            Surname.TabIndex = 2;
            Surname.Text = "Surname";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(114, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 1;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(36, 56);
            Name.Name = "Name";
            Name.Size = new Size(59, 25);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Anket);
            Text = "Form1";
            Anket.ResumeLayout(false);
            Anket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Anket;
        private TextBox nameTextBox;
        private Label Name;
        private Label Surname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox surnameTextBox;
        private TextBox emailTextBox;
        private Label Email;
        private Label Phone;
        private TextBox phoneTextBox;
        private ListBox listBox1;
        private Button Save;
        private Button Load;
        private TextBox fileTextBox;
        private Button Add;
        private Button Change;
        private DateTimePicker dateTimePicker1;
        private Label Date;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
    }
}