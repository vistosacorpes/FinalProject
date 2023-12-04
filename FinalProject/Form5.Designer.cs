namespace FinalProject
{
    partial class Form5
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
            textBox1 = new TextBox();
            label1 = new Label();
            width = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(200, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 95);
            label1.Name = "label1";
            label1.Size = new Size(43, 35);
            label1.TabIndex = 1;
            label1.Text = "A:";
            // 
            // width
            // 
            width.Location = new Point(200, 107);
            width.Name = "width";
            width.Size = new Size(138, 23);
            width.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label2.Location = new Point(105, 141);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Answer:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button1.Location = new Point(93, 281);
            button1.Name = "button1";
            button1.Size = new Size(148, 47);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button2.Location = new Point(262, 281);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 3;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button3.Location = new Point(262, 334);
            button3.Name = "button3";
            button3.Size = new Size(148, 47);
            button3.TabIndex = 4;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(507, 421);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(width);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Square";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox width;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}