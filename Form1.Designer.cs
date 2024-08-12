namespace CSharp_ParentFromANDChildFrom
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
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            chidlFormToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(860, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(37, 20);
            openToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { chidlFormToolStripMenuItem });
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(180, 22);
            openToolStripMenuItem1.Text = "Open";
            // 
            // chidlFormToolStripMenuItem
            // 
            chidlFormToolStripMenuItem.Name = "chidlFormToolStripMenuItem";
            chidlFormToolStripMenuItem.Size = new Size(180, 22);
            chidlFormToolStripMenuItem.Text = "Chidl Form";
            chidlFormToolStripMenuItem.Click += chidlFormToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 495);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 20F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "ParentForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem chidlFormToolStripMenuItem;
    }
}
