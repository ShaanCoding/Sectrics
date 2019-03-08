using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sectrics_V2
{
    public partial class startMenu : Form
    {
        public void SplashScreen()
        {
            Application.Run(new splashScreen());
        }

        public startMenu()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(2500);

            InitializeComponent();

            t.Abort();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void startApplication_Click(object sender, EventArgs e)
        {
            nodes node = new nodes();
            this.Hide();
            node.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            tutorialMenu tutorial = new tutorialMenu();
            this.Hide();
            tutorial.Show();
        }

        private void startMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
