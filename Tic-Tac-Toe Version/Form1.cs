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
            PlayerTurn = !PlayerTurn; 
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
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
            PlayerTurn = !PlayerTurn;
        }
    }
}
