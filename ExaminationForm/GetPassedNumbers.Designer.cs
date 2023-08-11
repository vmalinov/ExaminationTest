namespace WinFormsApp1
{
    partial class GetPassedNumbers
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 403);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(437, 33);
            button1.Name = "button1";
            button1.Size = new Size(314, 129);
            button1.TabIndex = 1;
            button1.Text = "PRESS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(437, 254);
            label1.Name = "label1";
            label1.Size = new Size(173, 72);
            label1.TabIndex = 2;
            label1.Text = "Result";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(625, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 78);
            textBox1.TabIndex = 3;
            // 
            // GetPassedNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "GetPassedNumbers";
            Text = "App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}