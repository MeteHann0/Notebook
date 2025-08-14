namespace Notebook
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
            buttonSave = new Button();
            buttonOpen = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(176, 312);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(553, 237);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(69, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 120);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(447, 77);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(295, 120);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 33);
            label1.Name = "label1";
            label1.Size = new Size(211, 26);
            label1.TabIndex = 4;
            label1.Text = "Write your note  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 33);
            label2.Name = "label2";
            label2.Size = new Size(192, 26);
            label2.TabIndex = 5;
            label2.Text = "Open your note";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 235);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 7;
            label3.Text = "File Name(optional):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(buttonOpen);
            Controls.Add(buttonSave);
            Name = "Form1";
            Text = "Notebook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonOpen;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
