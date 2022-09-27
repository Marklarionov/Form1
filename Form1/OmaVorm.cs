using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class OmaVorm : Form
    {
        public OmaVorm() { }
        RadioButton Mnupp;
        public OmaVorm(string Pealkiri, string Fail)
        {

            this.ClientSize = new System.Drawing.Size(300, 300);
            /*this.Text = Pealkiri;
            {
                Text = "Chill",
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 75),
                BackColor = System.Drawing.Color.LightGray
            };*/
            Label failinimi = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 75),
                BackColor = System.Drawing.Color.LightGray
            };
            this.Controls.Add(failinimi);
        }
        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\..\chill.wav"))
                {
                    MessageBox.Show("Muusika Mängitakse!");
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show("Okay...");
            }
        }
    }
}
