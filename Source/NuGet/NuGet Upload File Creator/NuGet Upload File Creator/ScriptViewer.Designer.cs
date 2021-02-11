
namespace NuGetUploadFileCreator
{
    partial class ScriptViewer
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.krtbEditFile = new Krypton.Toolkit.KryptonRichTextBox();
            this.kbtnClose = new Krypton.Toolkit.KryptonButton();
            this.kbtnOpen = new Krypton.Toolkit.KryptonButton();
            this.kbtnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnSave);
            this.kryptonPanel1.Controls.Add(this.kbtnOpen);
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 643);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(708, 45);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.krtbEditFile);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(708, 640);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // krtbEditFile
            // 
            this.krtbEditFile.Location = new System.Drawing.Point(13, 13);
            this.krtbEditFile.Name = "krtbEditFile";
            this.krtbEditFile.Size = new System.Drawing.Size(683, 624);
            this.krtbEditFile.TabIndex = 0;
            this.krtbEditFile.Text = "";
            // 
            // kbtnClose
            // 
            this.kbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnClose.Location = new System.Drawing.Point(606, 8);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 25);
            this.kbtnClose.TabIndex = 0;
            this.kbtnClose.Values.Text = "Cl&ose";
            // 
            // kbtnOpen
            // 
            this.kbtnOpen.Location = new System.Drawing.Point(510, 8);
            this.kbtnOpen.Name = "kbtnOpen";
            this.kbtnOpen.Size = new System.Drawing.Size(90, 25);
            this.kbtnOpen.TabIndex = 1;
            this.kbtnOpen.Values.Text = "Ope&n";
            this.kbtnOpen.Click += new System.EventHandler(this.kbtnOpen_Click);
            // 
            // kbtnSave
            // 
            this.kbtnSave.Enabled = false;
            this.kbtnSave.Location = new System.Drawing.Point(414, 8);
            this.kbtnSave.Name = "kbtnSave";
            this.kbtnSave.Size = new System.Drawing.Size(90, 25);
            this.kbtnSave.TabIndex = 2;
            this.kbtnSave.Values.Text = "&Save";
            // 
            // ScriptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 688);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ScriptViewer";
            this.Text = "ScriptViewer";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnSave;
        private Krypton.Toolkit.KryptonButton kbtnOpen;
        private Krypton.Toolkit.KryptonButton kbtnClose;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonRichTextBox krtbEditFile;
    }
}