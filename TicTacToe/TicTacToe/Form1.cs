using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class TicTacToe : Form
    {
        //bool counter for player turn
        public bool isX = true;
        //declaring images
        Image xMark = Properties.Resources.X;
        Image oMark = Properties.Resources.O;
        //creating 2D array
        PictureBox[,] pictureBoxes = new PictureBox[3, 3];


        public TicTacToe()
        {
            InitializeComponent();
            InitializePictureBoxes();

        }
        private void InitializePictureBoxes()
        {
            // assigning pictureBoxes to the 2D array for easier access
            pictureBoxes[0, 0] = pictureBox1;
            pictureBoxes[0, 1] = pictureBox2;
            pictureBoxes[0, 2] = pictureBox3;
            pictureBoxes[1, 0] = pictureBox4;
            pictureBoxes[1, 1] = pictureBox5;
            pictureBoxes[1, 2] = pictureBox6;
            pictureBoxes[2, 0] = pictureBox7;
            pictureBoxes[2, 1] = pictureBox8;
            pictureBoxes[2, 2] = pictureBox9;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox1);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox2);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox3);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox4);
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox5);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox6);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox7);
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox8);
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            GridSystem(pictureBox9);
        }

        //method for player turn
        private void GridSystem(PictureBox grid)
        {
            if (grid.Image == null)
            {
                if (isX == true)
                {
                    grid.Image = xMark;
                    isX = false;
                }
                else
                {
                    grid.Image = oMark;
                    isX = true;
                }
            }

            if (WinCondition())
            {
                if (grid.Image == xMark)
                {
                    MessageBox.Show("X wins!!");
                }
                else if (grid.Image == oMark)
                {
                    MessageBox.Show("O wins!!");
                }
                InitializeGame();
            }

            if (CheckTie())
            {
                MessageBox.Show("Tie game!!");
                InitializeGame();
            }


        }

        //winner decision
        private bool WinCondition()
        {
            //rows
            for (int row = 0; row < 3; row++)
            {
                if (
                    pictureBoxes[row, 0].Image != null && pictureBoxes[row, 0].Image == pictureBoxes[row, 1].Image && pictureBoxes[row, 1].Image == pictureBoxes[row, 2].Image
                    )
                {
                    return true;
                }
            }

            //columns
            for (int col = 0; col < 3; col++)
            {
                if (
                    pictureBoxes[0, col].Image != null && pictureBoxes[0, col].Image == pictureBoxes[1, col].Image && pictureBoxes[1, col].Image == pictureBoxes[2, col].Image
                    )
                {
                    return true;
                }
            }

            //diagonals
            if (pictureBoxes[0, 0].Image != null && pictureBoxes[0, 0].Image == pictureBoxes[1, 1].Image && pictureBoxes[1, 1].Image == pictureBoxes[2, 2].Image)
            {
                return true;
            }
            else if (pictureBoxes[0, 2].Image != null && pictureBoxes[0, 2].Image == pictureBoxes[1, 1].Image && pictureBoxes[1, 1].Image == pictureBoxes[2, 0].Image)
            {
                return true;
            }

            return false;
        }

        private bool CheckTie()
        {
            // Check if all cells are filled
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Image == null)
                {
                    // if not all full return false
                    return false;
                }
            }

            // all cells are filled so tie
            return true;
        }
        private void InitializeGame()
        {
            // clear images from all PictureBoxes
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Image = null;
            }

            // enable all PictureBoxes for clicks
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Enabled = true;
            }

            // reset currentPlayer to 'X'
            isX = true;
        }

   
    }
}