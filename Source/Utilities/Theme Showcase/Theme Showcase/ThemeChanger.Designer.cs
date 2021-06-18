
namespace ThemeShowcase
{
    partial class ThemeChanger
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
            this.components = new System.ComponentModel.Container();
            this.palette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.manager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnImportTheme = new Krypton.Toolkit.KryptonButton();
            this.kbtnShowcaseTheme = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // palette
            // 
            this.palette.CustomisedKryptonPaletteFilePath = null;
            // 
            // manager
            // 
            this.manager.GlobalPalette = this.palette;
            this.manager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnShowcaseTheme);
            this.kryptonPanel1.Controls.Add(this.kbtnImportTheme);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(423, 148);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnImportTheme
            // 
            this.kbtnImportTheme.Location = new System.Drawing.Point(13, 56);
            this.kbtnImportTheme.Name = "kbtnImportTheme";
            this.kbtnImportTheme.Size = new System.Drawing.Size(156, 25);
            this.kbtnImportTheme.TabIndex = 0;
            this.kbtnImportTheme.Values.Text = "&Import Theme";
            this.kbtnImportTheme.Click += new System.EventHandler(this.kbtnImportTheme_Click);
            // 
            // kbtnShowcaseTheme
            // 
            this.kbtnShowcaseTheme.Location = new System.Drawing.Point(255, 56);
            this.kbtnShowcaseTheme.Name = "kbtnShowcaseTheme";
            this.kbtnShowcaseTheme.Size = new System.Drawing.Size(156, 25);
            this.kbtnShowcaseTheme.TabIndex = 1;
            this.kbtnShowcaseTheme.Values.Text = "&Showcase Theme";
            this.kbtnShowcaseTheme.Click += new System.EventHandler(this.kbtnShowcaseTheme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 148);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette palette;
        private Krypton.Toolkit.KryptonManager manager;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnShowcaseTheme;
        private Krypton.Toolkit.KryptonButton kbtnImportTheme;
    }
}

