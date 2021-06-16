using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTermProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(3);
            percentagelabel.Text = progressBar.Value + "%";
            if(progressBar.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                login log = new login();
                log.Show();
            }
            

        }

       
    }
}
