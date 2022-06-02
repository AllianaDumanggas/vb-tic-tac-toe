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

        Boolean PlayerTurn = false;
        //Player1turn= ture;
        //Player2turn=false;
         

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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
            
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
             
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
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
            PlayerTurn = !PlayerTurn;
            WinnerCheck();
        }

        private void WinnerCheck() 
        {
            Boolean A_Winner_is_Recognized = false;
            // to check if there is already a winner

            // HORIZONTAL CHECK
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
            // VERTICAL CHECK
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
            // DIAGONAL CHECK
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
                    Winner = "Player 2, What an Arf";
                }
                else
                {
                    Winner = "Player 1, What a Meow";
                }
                MessageBox.Show(Winner + ""," YOU WIN"); 
            }
        }
    }
}
