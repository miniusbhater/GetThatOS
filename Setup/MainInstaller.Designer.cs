namespace GetThatOSSetup
{
    partial class MainInstaller
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 47);
            label1.TabIndex = 0;
            label1.Text = "GetThatOS Setup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 9);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "miniusbhater";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(356, 15);
            label3.TabIndex = 2;
            label3.Text = "GetThatOS Will Be Installed To: 'C:\\Program Files (x86)\\GetThatOS'\r\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(143, 124);
            button1.Name = "button1";
            button1.Size = new Size(135, 55);
            button1.TabIndex = 3;
            button1.Text = "Install";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 41);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "0.2.9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 106);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 6;
            label5.Text = "Installing Please wait";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 106);
            label6.Name = "label6";
            label6.Size = new Size(363, 15);
            label6.TabIndex = 7;
            label6.Text = "Install Complete You May Launch GetThatOS From Your Start Menu\r\n";
            label6.Visible = false;
            // 
            // MainInstaller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 191);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "MainInstaller";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setup - 0.2.9";
            Load += MainInstaller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
