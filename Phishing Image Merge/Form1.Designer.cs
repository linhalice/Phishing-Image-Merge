namespace Phishing_Image_Merge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBoxMerge1 = new CheckBox();
            checkBoxMerge2 = new CheckBox();
            checkBoxPlayFacebook = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBoxImagePath = new TextBox();
            label1 = new Label();
            checkBoxPlaySelect = new CheckBox();
            button2 = new Button();
            textBoxPlaySelect = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxMerge1
            // 
            checkBoxMerge1.AutoSize = true;
            checkBoxMerge1.Location = new Point(19, 25);
            checkBoxMerge1.Name = "checkBoxMerge1";
            checkBoxMerge1.Size = new Size(111, 19);
            checkBoxMerge1.TabIndex = 0;
            checkBoxMerge1.Text = "Ghép ảnh kiểu 1";
            checkBoxMerge1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMerge2
            // 
            checkBoxMerge2.AutoSize = true;
            checkBoxMerge2.Location = new Point(192, 25);
            checkBoxMerge2.Name = "checkBoxMerge2";
            checkBoxMerge2.Size = new Size(111, 19);
            checkBoxMerge2.TabIndex = 1;
            checkBoxMerge2.Text = "Ghép ảnh kiểu 2";
            checkBoxMerge2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlayFacebook
            // 
            checkBoxPlayFacebook.AutoSize = true;
            checkBoxPlayFacebook.Location = new Point(19, 24);
            checkBoxPlayFacebook.Name = "checkBoxPlayFacebook";
            checkBoxPlayFacebook.Size = new Size(154, 19);
            checkBoxPlayFacebook.TabIndex = 2;
            checkBoxPlayFacebook.Text = "Ghép nút play Facebook";
            checkBoxPlayFacebook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(584, 198);
            button1.Name = "button1";
            button1.Size = new Size(64, 41);
            button1.TabIndex = 3;
            button1.Text = "Ghép";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.fishing_baits;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBoxImagePath
            // 
            textBoxImagePath.Enabled = false;
            textBoxImagePath.Location = new Point(254, 216);
            textBoxImagePath.Name = "textBoxImagePath";
            textBoxImagePath.Size = new Size(169, 23);
            textBoxImagePath.TabIndex = 5;
            textBoxImagePath.TextChanged += textBoxImagePath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 195);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 6;
            label1.Text = "Đường dẫn thư mục ảnh gốc:";
            // 
            // checkBoxPlaySelect
            // 
            checkBoxPlaySelect.AutoSize = true;
            checkBoxPlaySelect.Location = new Point(19, 49);
            checkBoxPlaySelect.Name = "checkBoxPlaySelect";
            checkBoxPlaySelect.Size = new Size(150, 19);
            checkBoxPlaySelect.TabIndex = 7;
            checkBoxPlaySelect.Text = "Ghép nút play tuỳ chọn";
            checkBoxPlaySelect.UseVisualStyleBackColor = true;
            checkBoxPlaySelect.CheckedChanged += checkBoxPlaySelect_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(138, 74);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 8;
            button2.Text = "Chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPlaySelect
            // 
            textBoxPlaySelect.Enabled = false;
            textBoxPlaySelect.Location = new Point(19, 75);
            textBoxPlaySelect.Name = "textBoxPlaySelect";
            textBoxPlaySelect.Size = new Size(113, 23);
            textBoxPlaySelect.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxMerge1);
            groupBox1.Controls.Add(checkBoxMerge2);
            groupBox1.Location = new Point(254, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 62);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghép ảnh xem thêm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkBoxPlayFacebook);
            groupBox2.Controls.Add(checkBoxPlaySelect);
            groupBox2.Controls.Add(textBoxPlaySelect);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(254, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 109);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghép ảnh nút play";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 23);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 12;
            label3.Text = "ảnh gốc.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(27, 23);
            textBox1.TabIndex = 11;
            textBox1.Text = "3";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 23);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 10;
            label2.Text = "Tỷ lệ button bằng 1/";
            // 
            // button3
            // 
            button3.Location = new Point(429, 216);
            button3.Name = "button3";
            button3.Size = new Size(50, 23);
            button3.TabIndex = 12;
            button3.Text = "Chọn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(189, 17);
            label4.TabIndex = 13;
            label4.Text = "Aurae Software: 0981.907.596";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(514, 198);
            button4.Name = "button4";
            button4.Size = new Size(64, 41);
            button4.TabIndex = 14;
            button4.Text = "Kết quả";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(662, 249);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBoxImagePath);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ghép ảnh Bait";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxMerge1;
        private CheckBox checkBoxMerge2;
        private CheckBox checkBoxPlayFacebook;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBoxImagePath;
        private Label label1;
        private CheckBox checkBoxPlaySelect;
        private Button button2;
        private TextBox textBoxPlaySelect;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private Label label4;
        private Button button4;
    }
}
