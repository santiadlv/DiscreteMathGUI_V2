using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SecondPartialGUI.Classes
{
    public static class GlobalVar
    {
        public static int partialNum = 1; //Flag to see if they want Partial 1/2 content
        public static string[] topics = new string[5]; //All topics

        public static Image[] P1_slides = new Image[8];     //Theory and problems for Partial 1
        public static Image[] P1_problems = new Image[5];

        public static Image[] P2_slides = new Image[12];    //Theory and problems for Partial 2
        public static Image[] P2_problems = new Image[5];

        public static bool[] P1_correctAnswers_1 = new bool[4]; //right answers for Partial 1
        public static bool[] P1_correctAnswers_2 = new bool[4];
        public static bool[] P1_correctAnswers_3 = new bool[4];
        public static bool[] P1_correctAnswers_4 = new bool[4];
        public static bool[] P1_correctAnswers_5 = new bool[4];

        public static bool[] P2_correctAnswers_1 = new bool[4]; //Right answers for Partial 2
        public static bool[] P2_correctAnswers_2 = new bool[4];
        public static bool[] P2_correctAnswers_3 = new bool[4];
        public static bool[] P2_correctAnswers_4 = new bool[4];
        public static bool[] P2_correctAnswers_5 = new bool[4];

        public static bool[] ans1 = new bool[4]; //Arrays to save answers to all problems
        public static bool[] ans2 = new bool[4];
        public static bool[] ans3 = new bool[4];
        public static bool[] ans4 = new bool[4];
        public static bool[] ans5 = new bool[4];

        public static bool[] correctFinals = new bool[5];
        public static int finalsIndex = 0;
        public static int correctCount = 0;

        public static void GetImages()
        {
            P1_slides[0] = Properties.Resources.p1_cover;
            P1_slides[1] = Properties.Resources.p1_img1;
            P1_slides[2] = Properties.Resources.p1_img2;
            P1_slides[3] = Properties.Resources.p1_img3;
            P1_slides[4] = Properties.Resources.p1_img4;
            P1_slides[5] = Properties.Resources.p1_img5;
            P1_slides[6] = Properties.Resources.p1_img6;
            P1_slides[7] = Properties.Resources.p1_img7;

            P2_slides[0] = Properties.Resources.p2_cover;
            P2_slides[1] = Properties.Resources.p2_img1;
            P2_slides[2] = Properties.Resources.p2_img2;
            P2_slides[3] = Properties.Resources.p2_img3;
            P2_slides[4] = Properties.Resources.p2_img4;
            P2_slides[5] = Properties.Resources.p2_img5;
            P2_slides[6] = Properties.Resources.p2_img6;
            P2_slides[7] = Properties.Resources.p2_img7;
            P2_slides[8] = Properties.Resources.p2_img8;
            P2_slides[9] = Properties.Resources.p2_img9;
            P2_slides[10] = Properties.Resources.p2_img10;
            P2_slides[11] = Properties.Resources.p2_img11;
        }

        public static void GetProblems()
        {
            P1_problems[0] = Properties.Resources.p1_prob1;
            P1_problems[1] = Properties.Resources.p1_prob2;
            P1_problems[2] = Properties.Resources.p1_prob3;
            P1_problems[3] = Properties.Resources.p1_prob4;
            P1_problems[4] = Properties.Resources.p1_prob5;

            P2_problems[0] = Properties.Resources.p2_prob1;
            P2_problems[1] = Properties.Resources.p2_prob2;
            P2_problems[2] = Properties.Resources.p2_prob3;
            P2_problems[3] = Properties.Resources.p2_prob4;
            P2_problems[4] = Properties.Resources.p2_prob5;
        }

        public static void GetTopics()
        {
           if (partialNum == 1)
           {
                topics[0] = "'Simplificaciones'";
                topics[1] = "'Condicional'";
                topics[2] = "'Argumentos'";
                topics[3] = "'Reglas de inferencia'";
                topics[4] = "'Variantes de la condicional'";
           }
           else
           {
                topics[0] = "'Conjuntos extensionales'";
                topics[1] = "'Conjuntos intensionales'";
                topics[2] = "'Subconjuntos'";
                topics[3] = "'Operaciones entre conjuntos'";
                topics[4] = "'Propiedades de conjuntos'";
            }
        }

        public static void GetCorrectAnswers()
        {
            P1_correctAnswers_1[1] = true;
            P1_correctAnswers_2[3] = true;
            P1_correctAnswers_3[0] = true;
            P1_correctAnswers_4[2] = true;
            P1_correctAnswers_5[1] = true;

            P2_correctAnswers_1[3] = true;
            P2_correctAnswers_2[0] = true;
            P2_correctAnswers_3[1] = true;
            P2_correctAnswers_4[2] = true;
            P2_correctAnswers_5[3] = true;
        }

        public static Image SetImages(int index)
        {
            if (partialNum == 1)
            {
                return P1_slides[index];
            }
            else
            {
                return P2_slides[index];
            }
        }

        public static Image SetProblem(int index)
        {
            if (partialNum == 1)
            {
                return P1_problems[index];
            }
            else
            {
                return P2_problems[index];
            }
        }

        public static void CheckAnswers(bool[] answers, bool[] correctA)
        {
            bool correctQuestion = true;
            for (int i = 0; i < 4; i++)
            {
                if (answers[i] != correctA[i])
                {
                    correctQuestion = false;
                }
            }
            correctFinals[finalsIndex] = correctQuestion;
            finalsIndex++;
        }

        public static string GiveResults()
        {
            string sentence;
            for (int i = 0; i < correctFinals.Length; i++)
            {
                if (correctFinals[i] == true)
                {
                    correctCount++;
                }
            }
            float score = ((float)correctCount / 5) * 100;
            sentence = "¡Felicidades! Obtuviste " + correctCount + " pregunta(s) correcta(s).\n";
            sentence += "\nTú calificación es de " + score.ToString() + GradeScore((int)score);
            return sentence;
        }

        public static string GradeScore(int score)
        {
            if (score == 100) { return ". ¡Excelente trabajo!\n"; }
            else if (score == 80) { return ". ¡Muy buen trabajo!\n"; }
            else if (score == 60) { return ". ¡Buen trabajo!\n"; }
            else if (score == 40) { return ". Bien hecho, pero hay detalles que contemplar.\n"; }
            else if (score == 20) { return ". Hay que estudiar un poco más la teoría.\n"; }
            else { return ". ¡No leíste la teoría! Hay mucho que estudiar.\n"; }
        }

        public static string SuggestTopics()
        {
            List<int> improve = new List<int>();
            string temp = "";
            string sentence = "";

            for (int i = 0; i < correctFinals.Length; i++)
            {
                if (correctFinals[i] == false)
                {
                    improve.Add(i + 1);
                }
            }

            for (int j = 0; j < improve.Count; j++)
            {
                if (j == improve.Count - 1)
                {
                    temp += improve[j].ToString() + " (" + topics[improve[j] - 1] + ")";
                }
                else if (j == improve.Count - 2)
                {
                    temp += improve[j].ToString() + " (" + topics[improve[j] - 1] + ")" + " y ";
                }
                else
                {
                    temp += improve[j].ToString() + " (" + topics[improve[j] - 1] + ")" + ", ";
                }
            }

            if (improve.Count == 0)
            {
                return "";
            }
            else
            {
                sentence = "\nTuviste la(s) pregunta(s) " + temp + " incorrecta(s).\n";
                sentence += "\nRegresa a la sección de teoría para reforzar estos conceptos.";
                return sentence;
            }
        }
    }
}
