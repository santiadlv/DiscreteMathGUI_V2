using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondPartialGUI.Classes;

namespace SecondPartialGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void bttnTheory1_Click(object sender, EventArgs e)
        {
            ShowTheory(1);
        }

        private void bttnTheory2_Click(object sender, EventArgs e)
        {
            ShowTheory(2);
        }

        private void bttnExercises1_Click(object sender, EventArgs e)
        {
            ShowExercises(1);
        }

        private void bttnExercises2_Click(object sender, EventArgs e)
        {
            ShowExercises(2);
        }

        private void ShowTheory(int partial)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Closed += (s, args) => this.Close();
            GC.Collect();
            GlobalVar.partialNum = partial;
            frm2.Show();
        }

        private void ShowExercises(int partial)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Closed += (s, args) => this.Close();
            GC.Collect();
            GlobalVar.partialNum = partial;
            frm3.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }
    }
}
