namespace FinalProject
{
    partial class Form6
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
            valuex = new TextBox();
            valuey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // valuex
            // 
            valuex.Location = new Point(162, 116);
            valuex.Name = "valuex";
            valuex.Size = new Size(276, 23);
            valuex.TabIndex = 0;
            // 
            // valuey
            // 
            valuey.Location = new Point(162, 145);
            valuey.Name = "valuey";
            valuey.Size = new Size(276, 23);
            valuey.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label1.Location = new Point(71, 107);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 1;
            label1.Text = "Value x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label2.Location = new Point(71, 138);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "Value y:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(162, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label3.Location = new Point(71, 179);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 1;
            label3.Text = "Answer:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button1.Location = new Point(113, 280);
            button1.Name = "button1";
            button1.Size = new Size(138, 49);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button2.Location = new Point(257, 280);
            button2.Name = "button2";
            button2.Size = new Size(138, 49);
            button2.TabIndex = 2;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button3.Location = new Point(257, 335);
            button3.Name = "button3";
            button3.Size = new Size(138, 49);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(507, 421);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(valuey);
            Controls.Add(valuex);
            Name = "Form6";
            Text = "Triangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valuex;
        private TextBox valuey;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}