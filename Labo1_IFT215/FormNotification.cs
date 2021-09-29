using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo1_IFT215
{
    public partial class FormNotification : Form
    {
        int timerValue;
        public FormNotification()
        {
            InitializeComponent();
            timerNotification.Start();
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            timerValue = 5;
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            timerValue--;
            labelNotificationTime.Text = timerValue.ToString();
            if (timerValue < 0)
            {
                this.Hide();
                timerNotification.Stop();
            }
        }

        /*
         * Méthode appelée lorsque l'utilisateur clique sur la notification
         */
        public void timerStop(object sender, EventArgs e)
        {
            timerNotification.Stop();
        }

        /*
         * Méthode appelée lorsque l'utilisateur double-clique sur la notification
         */
        public void hideForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void buttonExit_MouseEntered(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.White;
            buttonExit.BackColor = Color.Red; 
        }
        public void buttonExit_MouseExited(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.Gray;
            buttonExit.BackColor = Color.WhiteSmoke;
        }

    }
}
