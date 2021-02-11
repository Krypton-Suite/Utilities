
namespace NuGetUploadFileCreator
{
    partial class MainWindow
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnOpenInExplorer = new Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateScript = new Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.ktxtScriptName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtAPIKey = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kbtnViewContents = new Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new Krypton.Toolkit.KryptonButton();
            this.ktxtPackagePath = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kbtnCreateFile = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCreateFile);
            this.kryptonPanel1.Controls.Add(this.kbtnOpenInExplorer);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateScript);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 139);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(671, 45);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOpenInExplorer
            // 
            this.kbtnOpenInExplorer.Enabled = false;
            this.kbtnOpenInExplorer.Location = new System.Drawing.Point(12, 8);
            this.kbtnOpenInExplorer.Name = "kbtnOpenInExplorer";
            this.kbtnOpenInExplorer.Size = new System.Drawing.Size(150, 25);
            this.kbtnOpenInExplorer.TabIndex = 2;
            this.kbtnOpenInExplorer.Values.Text = "Open in &Explorer";
            this.kbtnOpenInExplorer.Click += new System.EventHandler(this.kbtnOpenInExplorer_Click);
            // 
            // kbtnGenerateScript
            // 
            this.kbtnGenerateScript.Enabled = false;
            this.kbtnGenerateScript.Location = new System.Drawing.Point(413, 8);
            this.kbtnGenerateScript.Name = "kbtnGenerateScript";
            this.kbtnGenerateScript.Size = new System.Drawing.Size(150, 25);
            this.kbtnGenerateScript.TabIndex = 1;
            this.kbtnGenerateScript.Values.Text = "Generate &Script";
            this.kbtnGenerateScript.Click += new System.EventHandler(this.kbtnGenerateScript_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(569, 8);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.ktxtScriptName);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.ktxtAPIKey);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kbtnViewContents);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel2.Controls.Add(this.ktxtPackagePath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(671, 136);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // ktxtScriptName
            // 
            this.ktxtScriptName.Hint = "Name your script file (e.g. Upload to NuGet.cmd)";
            this.ktxtScriptName.Location = new System.Drawing.Point(151, 103);
            this.ktxtScriptName.Name = "ktxtScriptName";
            this.ktxtScriptName.Size = new System.Drawing.Size(472, 23);
            this.ktxtScriptName.TabIndex = 7;
            this.ktxtScriptName.TextChanged += new System.EventHandler(this.ktxtScriptName_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 103);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(126, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "NuGet Script Name:";
            // 
            // ktxtAPIKey
            // 
            this.ktxtAPIKey.Hint = "Enter your API key";
            this.ktxtAPIKey.Location = new System.Drawing.Point(151, 74);
            this.ktxtAPIKey.Name = "ktxtAPIKey";
            this.ktxtAPIKey.Size = new System.Drawing.Size(472, 23);
            this.ktxtAPIKey.TabIndex = 5;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 74);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "NuGet API Key:";
            // 
            // kbtnViewContents
            // 
            this.kbtnViewContents.Enabled = false;
            this.kbtnViewContents.Location = new System.Drawing.Point(506, 43);
            this.kbtnViewContents.Name = "kbtnViewContents";
            this.kbtnViewContents.Size = new System.Drawing.Size(153, 25);
            this.kbtnViewContents.TabIndex = 3;
            this.kbtnViewContents.Values.Text = "V&iew Directory Content";
            this.kbtnViewContents.Click += new System.EventHandler(this.kbtnViewContents_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.AutoSize = true;
            this.kbtnBrowse.Location = new System.Drawing.Point(629, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(30, 25);
            this.kbtnBrowse.TabIndex = 2;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // ktxtPackagePath
            // 
            this.ktxtPackagePath.Hint = "Enter a valid path";
            this.ktxtPackagePath.Location = new System.Drawing.Point(151, 13);
            this.ktxtPackagePath.Name = "ktxtPackagePath";
            this.ktxtPackagePath.Size = new System.Drawing.Size(472, 23);
            this.ktxtPackagePath.TabIndex = 1;
            this.ktxtPackagePath.TextChanged += new System.EventHandler(this.ktxtPackagePath_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "NuGet Package Path:";
            // 
            // kbtnCreateFile
            // 
            this.kbtnCreateFile.Enabled = false;
            this.kbtnCreateFile.Location = new System.Drawing.Point(326, 8);
            this.kbtnCreateFile.Name = "kbtnCreateFile";
            this.kbtnCreateFile.Size = new System.Drawing.Size(81, 25);
            this.kbtnCreateFile.TabIndex = 3;
            this.kbtnCreateFile.Values.Text = "Create &File";
            this.kbtnCreateFile.Click += new System.EventHandler(this.kbtnCreateFile_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 184);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kbtnGenerateScript;
        private Krypton.Toolkit.KryptonTextBox ktxtScriptName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox ktxtAPIKey;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton kbtnViewContents;
        private Krypton.Toolkit.KryptonButton kbtnBrowse;
        private Krypton.Toolkit.KryptonTextBox ktxtPackagePath;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kbtnOpenInExplorer;
        private Krypton.Toolkit.KryptonButton kbtnCreateFile;
    }
}

