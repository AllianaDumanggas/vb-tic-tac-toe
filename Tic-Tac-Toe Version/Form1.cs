using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Version
{
    public partial class TICTACTOE : Form
    {
        public TICTACTOE()
        {
            InitializeComponent();
        }

        Boolean PlayerTurn = true;
        //Player1turn= true;
        //Player2turn=false;
        int turns = 0;
        // count the number of turns

        private void BT1_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT1.Image = PBXCAT.Image; 
            }
            else 
            {
                BT1.Image = PBYDOG.Image; 
            }
            BT1.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();


        }

        private void BT2_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT2.Image = PBXCAT.Image;
            }
            else 
            {
                BT2.Image = PBYDOG.Image;
            }
            BT2.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();

        }

        private void BT3_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT3.Image = PBXCAT.Image;
            }
            else 
            {
                BT3.Image = PBYDOG.Image;
            }
            BT3.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT4.Image = PBXCAT.Image;
            }
            else 
            {
                BT4.Image = PBYDOG.Image;
            }
            BT4.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            if (PlayerTurn ) 
            {
                BT5.Image = PBXCAT.Image;
            }
            else 
            {
                BT5.Image = PBYDOG.Image;
            }
            BT5.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT6.Image = PBXCAT.Image;
            }
            else 
            {
                BT6.Image = PBYDOG.Image;
            }
            BT6.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            if (PlayerTurn) 
            {
                BT7.Image = PBXCAT.Image;
            }
            else 
            {
                BT7.Image = PBYDOG.Image;
            }
            BT7.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            if (PlayerTurn )
            {
                BT8.Image = PBXCAT.Image;
            }
            else 
            {
                BT8.Image = PBYDOG.Image;
            }
            BT8.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            if (PlayerTurn)
            {
                BT9.Image = PBXCAT.Image;
            }
            else
            {
                BT9.Image = PBYDOG.Image;
            }
            BT9.Enabled = false;
            turns++;
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            CheckForDraw();
        }

        private void WinnerCheck() 
        {
            Boolean A_Winner_is_Recognized = false;
            // to check if there is already a winner

            // FOR HORIZONTAL CHECK
            if ((BT1.Image == BT2.Image) && (BT2.Image == BT3.Image) && (!BT1.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            else if ((BT4.Image == BT5.Image) && (BT5.Image == BT6.Image) && (!BT4.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            else if ((BT7.Image == BT8.Image) && (BT8.Image == BT9.Image) && (!BT7.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            // FOR VERTICAL CHECK
            else if ((BT1.Image == BT4.Image) && (BT4.Image == BT7.Image) && (!BT1.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            else if ((BT2.Image == BT5.Image) && (BT5.Image == BT8.Image) && (!BT2.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            else if ((BT3.Image == BT6.Image) && (BT6.Image == BT9.Image) && (!BT3.Enabled))
            {
                A_Winner_is_Recognized = true;
            }
            // FOR DIAGONAL CHECK
            else if ((BT1.Image == BT5.Image ) && (BT5.Image == BT9.Image ) && (!BT1.Enabled ))
            {
                A_Winner_is_Recognized = true;
            }
            else if ((BT3.Image == BT5.Image ) && (BT5.Image == BT7.Image ) && (!BT3.Enabled ))
            {
                A_Winner_is_Recognized = true;
            }

            if (A_Winner_is_Recognized)
            {
                string Winner = "";
                if (PlayerTurn) 
                {
                    Winner = "Player 2, What an Arf, Congrats";
                }
                else
                {
                    Winner = "Player 1, What a Meow, Congrats";
                }
                MessageBox.Show(Winner + ""," YOU WIN"); 
                
            }
             

            if (A_Winner_is_Recognized)
            {
                BT1.Enabled = false;
                BT4.Enabled = false;
                BT7.Enabled = false;
                BT2.Enabled = false;
                BT5.Enabled = false;
                BT8.Enabled = false;
                BT3.Enabled = false;
                BT6.Enabled = false;
                BT9.Enabled = false;
            }
             
        }
 
        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
            // closes the application
        }

         Boolean CheckForDraw()
        {
            if (turns == 9)
            {
                MessageBox.Show("A Draw");
                return true;
            }
               
            else
            {
                return false;
            }
               
        }

        private void TryAgain()
        {
            Boolean PlayAgain = true;
            if ( PlayAgain)
            {
                PlayerTurn = true;
                BT1.Image = null;
                BT1.Enabled = true;
                BT2.Image = null;
                BT2.Enabled = true;
                BT3.Image = null;
                BT3.Enabled = true;
                BT4.Image = null;
                BT4.Enabled = true;
                BT5.Image = null;
                BT5.Enabled = true;
                BT6.Image = null;
                BT6.Enabled = true;
                BT7.Image = null;
                BT7.Enabled = true;
                BT8.Image = null;
                BT8.Enabled = true;
                BT9.Image = null;
                BT9.Enabled = true;
                turns = 0;
            }
           
        }

        private void PLAYAGAINBUTTON_Click(object sender, EventArgs e)
        {
            TryAgain();
        }
    }
}
