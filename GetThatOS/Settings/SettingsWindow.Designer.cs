namespace GetThatOS.Settings
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 1;
            label1.Text = "GetThatOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 50);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 2;
            label2.Text = "0.3.5";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(176, 50);
            button1.TabIndex = 3;
            button1.Text = "Integrity Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 138);
            button2.Name = "button2";
            button2.Size = new Size(176, 50);
            button2.TabIndex = 4;
            button2.Text = "Repository";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 194);
            button3.Name = "button3";
            button3.Size = new Size(176, 50);
            button3.TabIndex = 5;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 250);
            button4.Name = "button4";
            button4.Size = new Size(176, 50);
            button4.TabIndex = 6;
            button4.Text = "About";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 311);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetThatOS Settings";
            Load += SettingsWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}