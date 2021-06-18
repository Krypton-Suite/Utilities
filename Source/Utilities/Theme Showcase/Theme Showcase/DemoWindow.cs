using Krypton.Toolkit;
using System;

namespace ThemeShowcase
{
    public partial class DemoWindow : KryptonForm
    {
        public DemoWindow()
        {
            InitializeComponent();
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeChanger changer = new ThemeChanger();

            changer.Show();
        }
    }
}
