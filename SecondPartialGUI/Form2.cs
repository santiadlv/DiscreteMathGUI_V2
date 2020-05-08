using SecondPartialGUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondPartialGUI
{
    public partial class Form2 : Form
    {
        public static int imgIndex;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            imgIndex = 0;
            GlobalVar.GetImages();
            imgSlides.Image = GlobalVar.SetImages(imgIndex);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            imgIndex++;
            bttnPrevious.Enabled = true;
            ChangeSlide(imgIndex);

            if (GlobalVar.partialNum == 1)
            {
                if (imgIndex == GlobalVar.P1_slides.Length - 1)
                {
                    bttnNext.Enabled = false;
                }
            }
            else
            {
                if (imgIndex == GlobalVar.P2_slides.Length - 1)
                {
                    bttnNext.Enabled = false;
                }
            }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
            imgIndex--;
            bttnNext.Enabled = true;
            ChangeSlide(imgIndex);

            if (imgIndex == 0)
            {
                bttnPrevious.Enabled = false;
            }
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Closed += (s, args) => this.Close();
            GC.Collect();
            frm1.Show();
        }

        private void imgSlides_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();
        }

        private void ChangeSlide(int imgIndex)
        {
            imgSlides.Image = GlobalVar.SetImages(imgIndex);
        }
    }
}
