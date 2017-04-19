using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ARRAre
{
    public partial class Splash : SplashScreen
    {
        public Splash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
        }

        public void shownligin()
        {

           UserLogIn vbe = new UserLogIn();
            vbe.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            shownligin();


            this.Hide();
        }

       
    }
}