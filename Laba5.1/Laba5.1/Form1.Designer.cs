namespace Laba5._1
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
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            exToolStripMenuItem = new ToolStripMenuItem();
            axAcroPDF1 = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axAcroPDF1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, exToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(180, 22);
            openToolStripMenuItem1.Text = "open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // exToolStripMenuItem
            // 
            exToolStripMenuItem.Name = "exToolStripMenuItem";
            exToolStripMenuItem.Size = new Size(180, 22);
            exToolStripMenuItem.Text = "exit";
            exToolStripMenuItem.Click += exToolStripMenuItem_Click;
            // 
            // axAcroPDF1
            // 
            axAcroPDF1.Dock = DockStyle.Fill;
            axAcroPDF1.Enabled = true;
            axAcroPDF1.Location = new Point(0, 24);
            axAcroPDF1.Name = "axAcroPDF1";
            axAcroPDF1.OcxState = (AxHost.State)resources.GetObject("axAcroPDF1.OcxState");
            axAcroPDF1.Size = new Size(800, 426);
            axAcroPDF1.TabIndex = 1;
            axAcroPDF1.OnConnecting += axAcroPDF1_OnConnecting;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axAcroPDF1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Обозреватель документов в формате PDF";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axAcroPDF1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem exToolStripMenuItem;
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting axAcroPDF1;
    }
}
