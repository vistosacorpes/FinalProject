namespace FinalProject
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button1.Location = new Point(165, 205);
            button1.Name = "button1";
            button1.Size = new Size(160, 42);
            button1.TabIndex = 0;
            button1.Text = "Area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button2.Location = new Point(165, 253);
            button2.Name = "button2";
            button2.Size = new Size(160, 42);
            button2.TabIndex = 0;
            button2.Text = "Perimeter";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button3.Location = new Point(165, 307);
            button3.Name = "button3";
            button3.Size = new Size(160, 42);
            button3.TabIndex = 0;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(507, 421);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Activity";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}