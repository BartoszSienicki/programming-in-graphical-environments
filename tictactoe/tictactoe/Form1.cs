using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[3, 3];
        GraTicTacToe gra = new GraTicTacToe();
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

        }



        private void ZablokujPrzyciski()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Font = new Font("Arial", 24);
                    btn.Tag = new Point(i, j);
                    btn.Click += Button_Click;
                    buttons[i, j] = btn;

                    tableLayoutPanel1.Controls.Add(btn, j, i); // kolumna, wiersz
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Point p = (Point)clicked.Tag;

            if (!gra.WykonajRuch(p.X, p.Y))
                return;

            clicked.Text = gra.AktualnyGracz;

            listBoxHistoria.Items.Add($"{gra.AktualnyGracz}: ({p.X}, {p.Y})");


            string winner = gra.SprawdzWygrana();
            if (winner != null)
            {
                MessageBox.Show($"Gracz {winner} wygrał!");
                ZablokujPrzyciski();
                return;
            }

            if (gra.CzyRemis())
            {
                MessageBox.Show("Remis!");
                return;
            }

            gra.ZmienGracza();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gra.ResetPlanszy();
            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            listBoxHistoria.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
