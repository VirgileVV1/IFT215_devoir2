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
            labelTimeNotif.Text = timerValue.ToString();
            if (timerValue < 0)
            {
                this.Hide();
                timerNotification.Stop();
            }
        }

        public void FormNotification_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double clic");
        }
    }
}
