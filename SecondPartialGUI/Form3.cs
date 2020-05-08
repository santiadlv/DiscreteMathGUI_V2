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
    public partial class Form3 : Form
    {
        public static int probIndex;
        public static string msgBoxName = "TECHNION - Retroalimentación de ejercicios";

        public Form3()
        {
            InitializeComponent();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Closed += (s, args) => this.Close();
            GC.Collect();
            frm1.Show();
        }

        private void bttnNextQ_Click(object sender, EventArgs e)
        {
            ChooseArray();
            lblTitle.Focus();
            ResetButtons();

            probIndex++;
            ChangeProblem(probIndex);

            if (GlobalVar.partialNum == 1)
            {
                if (probIndex == GlobalVar.P1_problems.Length - 1)
                {
                    bttnNextQ.Enabled = false;
                    bttnCheck.Visible = true;
                }
            }
            else
            {
                if (probIndex == GlobalVar.P2_problems.Length - 1)
                {
                    bttnNextQ.Enabled = false;
                    bttnCheck.Visible = true;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GlobalVar.finalsIndex = 0;
            GlobalVar.correctCount = 0;
            probIndex = 0;
            GlobalVar.GetProblems();
            imgProblem.Image = GlobalVar.SetProblem(probIndex);
        }

        private void ChangeProblem(int imgIndex)
        {
            imgProblem.Image = GlobalVar.SetProblem(imgIndex);
        }

        private void bttnCheck_Click(object sender, EventArgs e)
        {
            ChooseArray();
            GlobalVar.GetCorrectAnswers();
            GlobalVar.GetTopics();

            if (GlobalVar.partialNum == 1)
            {
                GlobalVar.CheckAnswers(GlobalVar.ans1, GlobalVar.P1_correctAnswers_1);
                GlobalVar.CheckAnswers(GlobalVar.ans2, GlobalVar.P1_correctAnswers_2);
                GlobalVar.CheckAnswers(GlobalVar.ans3, GlobalVar.P1_correctAnswers_3);
                GlobalVar.CheckAnswers(GlobalVar.ans4, GlobalVar.P1_correctAnswers_4);
                GlobalVar.CheckAnswers(GlobalVar.ans5, GlobalVar.P1_correctAnswers_5);
            }
            else
            {
                GlobalVar.CheckAnswers(GlobalVar.ans1, GlobalVar.P2_correctAnswers_1);
                GlobalVar.CheckAnswers(GlobalVar.ans2, GlobalVar.P2_correctAnswers_2);
                GlobalVar.CheckAnswers(GlobalVar.ans3, GlobalVar.P2_correctAnswers_3);
                GlobalVar.CheckAnswers(GlobalVar.ans4, GlobalVar.P2_correctAnswers_4);
                GlobalVar.CheckAnswers(GlobalVar.ans5, GlobalVar.P2_correctAnswers_5);
            }

            string msgBoxTxt = GlobalVar.GiveResults() + GlobalVar.SuggestTopics();
            MessageBox.Show(msgBoxTxt, msgBoxName, MessageBoxButtons.OK);
            bttnCheck.Enabled = false;
        }

        private void SaveAnswers(bool[] arr)
        {
            arr[0] = rbA.Checked;
            arr[1] = rbB.Checked;
            arr[2] = rbC.Checked;
            arr[3] = rbD.Checked;
        }

        private void ChooseArray()
        {
            if (probIndex == 0) { SaveAnswers(GlobalVar.ans1); }
            if (probIndex == 1) { SaveAnswers(GlobalVar.ans2); }
            if (probIndex == 2) { SaveAnswers(GlobalVar.ans3); }
            if (probIndex == 3) { SaveAnswers(GlobalVar.ans4); }
            if (probIndex == 4) { SaveAnswers(GlobalVar.ans5); }
        }

        private void ResetButtons()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
        }
    }
}
