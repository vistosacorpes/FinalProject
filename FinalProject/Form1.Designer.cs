namespace FinalProject
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
            b1 = new Button();
            b2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // b1
            // 
            b1.BackColor = Color.Transparent;
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.ForeColor = Color.Black;
            b1.Location = new Point(149, 219);
            b1.Name = "b1";
            b1.Size = new Size(201, 35);
            b1.TabIndex = 0;
            b1.Text = "START";
            b1.UseVisualStyleBackColor = false;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.Transparent;
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.ForeColor = Color.Black;
            b2.Location = new Point(149, 260);
            b2.Name = "b2";
            b2.Size = new Size(201, 35);
            b2.TabIndex = 0;
            b2.Text = "EXIT";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 23);
            label1.Name = "label1";
            label1.Size = new Size(249, 73);
            label1.TabIndex = 1;
            label1.Text = "Activity";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(507, 421);
            Controls.Add(label1);
            Controls.Add(b2);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Activity";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private Button b2;
        private Label label1;
    }
}
