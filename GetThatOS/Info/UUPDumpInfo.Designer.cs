namespace GetThatOS.Info
{
    partial class UUPDumpInfo
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 0;
            label1.Text = "Important Download Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 53);
            label2.Name = "label2";
            label2.Size = new Size(272, 63);
            label2.TabIndex = 1;
            label2.Text = "Windows 11 - XP will be downloaded \r\nfrom Archive.org\r\n\r\n";
            // 
            // UUPDumpInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UUPDumpInfo";
            Text = "Form1";
            Load += UUPDumpInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}