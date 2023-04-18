using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ViewLayerDevExpress.Login
{
    public partial class frmSplash : DevExpress.XtraEditors.XtraForm
    {
        private Timer fadeInTimer = new Timer();
        public frmSplash()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © " + DateTime.Now.Year.ToString();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Opacidad del fadeIn
            this.Opacity = 0;
            fadeInTimer.Interval = 20;
            fadeInTimer.Tick += new EventHandler(fadeInTimer_Tick);
            fadeInTimer.Start();
            // Cerrar el formulario de splash después de 3 segundos
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();

            //iniciar frame con hilos
            this.Dispose();
            frmMain mainFrame = new frmMain();
            mainFrame.Show();
            //Thread mainThread = new Thread(() => Application.Run(mainFrame));
            //mainThread.Start();
        }
        void fadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                fadeInTimer.Stop();
                return;
            }
            this.Opacity += 0.05;
        }
    }
}