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
        public OmaVorm(string Pealkiri, string Fail)
        {
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Text = Pealkiri;
            Label fail = new Label
            {
                Text = "" ,
                Location = new System.Drawing.Point(150, 120),
                Size = new System.Drawing.Size(120, 40),
                //BackColor = System.Drawing.Color.LightGray
            };

            Button nupp = new Button
            {
                Text = String.Format("Kuulame esimese muusikat"),
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            nupp.Click += Nupp_Click;
            Button nupp1 = new Button
            {
                Text = String.Format("Kuulame teise muusikat"),
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp1.Click += Nupp_Click1;

            Button nupp2 = new Button
            {
                Text = String.Format("Kuulame kolmas muusikat"),
                Location = new System.Drawing.Point(250, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp2.Click += Nupp_Click2;



            this.Controls.Add(nupp);
            this.Controls.Add(nupp1);
            this.Controls.Add(nupp2);
            this.Controls.Add(fail);


        }


        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\chill.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Mängib - Chill");

                }
            }
            else
            {
                MessageBox.Show("Okay...");
            }
        }
        private void Nupp_Click1(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\Gangsta.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Mängib - Gangsta");

                }
            }
            else
            {
                MessageBox.Show("Okay...");
            }
        }
        private void Nupp_Click2(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\chill.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Mängib - chill");

                }
            }
            else
            {
                MessageBox.Show("Okay...");
            }
        }
    }
}
