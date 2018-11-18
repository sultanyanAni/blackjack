using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        bool dealt21 = false;
        int dealerScore;
        int playerScore;
        Deck deck = new Deck();
        List<Card> PlayerHand = new List<Card>();
        List<PictureBox> PlayerPics = new List<PictureBox>();
        List<Card> DealerHand = new List<Card>();
        List<PictureBox> DealerPics = new List<PictureBox>();
  
        public Form1()
        {
            InitializeComponent();
        }
        void resetGame()
        {
            dealt21 = false;
            drawButton.Enabled = false;
            keepButton.Enabled = false;
            dealButton.Enabled = true;
            scoreLabel.Text = "";
            handLabel.Text = "";
            dealerHandLabel.Text = "";
            dealerScoreLabel.Text = "";
            playerScore = 0;
            dealerScore = 0;
            PlayerHand.Clear();
            DealerHand.Clear();
            for (int i = 0; i < PlayerPics.Count; i++)
            {
                PlayerPics[i].Image = Properties.Resources.empty_space;
                DealerPics[i].Image = Properties.Resources.empty_space;
            }
            deck.ReloadDeck();
            deck.Shuffle(5);
        }
        void checkScore()
        {
            if (playerScore > 21)
            {
                DialogResult dialogResult = MessageBox.Show("Dealer wins! Would you like to play again?", "Loss", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }
            else if (dealerScore > 21)
            {
                DialogResult dialogResult = MessageBox.Show("You win! Would you like to play again?", "Win", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }
            else if (playerScore == 21)
            {
                DialogResult dialogResult = MessageBox.Show("You win! Would you like to play again?", "Win", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }
            else if(playerScore == dealerScore)
            {
                DialogResult dialogResult = MessageBox.Show("You tied! Would you like to play again?", "Tie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }

        }
        void dealerCheck()
        {
            int aceDifference = 21 - (dealerScore + 1);
            int elevenDifference = 21 - (dealerScore + 11);

            if (aceDifference < elevenDifference)
            {
                dealerScore += 1;
            }
            else
            {
                dealerScore += 11;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control pb in Controls)
            {
                if (pb is PictureBox)
                {
                    PictureBox box = (PictureBox)pb;
                    int tag = Convert.ToInt32(pb.Tag);
                    if (tag < 0)
                    {
                        DealerPics.Add(box);
                    }
                    else
                    {
                        PlayerPics.Add(box);
                    }
                }
            }
            bool swapped = false;
            for (int i = 0; i < DealerPics.Count; i++)
            {
                swapped = false;
                for (int j = 1; j < DealerPics.Count; j++)
                {
                    int tag1 = Convert.ToInt32(DealerPics[j].Tag);
                    int tag2 = Convert.ToInt32(DealerPics[j - 1].Tag);
                    if (tag1 < tag2)
                    {
                        PictureBox temp = DealerPics[j];
                        DealerPics[j] = DealerPics[j - 1];
                        DealerPics[j - 1] = temp;
                        swapped = true;
                    }
                }

                if(swapped == false)
                {
                    break;
                }
            }
            for (int i = 0; i < PlayerPics.Count; i++)
            {
                swapped = false;
                for (int j = 1; j < PlayerPics.Count; j++)
                {
                    int tag1 = Convert.ToInt32(PlayerPics[j].Tag);
                    int tag2 = Convert.ToInt32(PlayerPics[j - 1].Tag);
                    if (tag1 < tag2)
                    {
                        PictureBox temp = PlayerPics[j];
                        PlayerPics[j] = PlayerPics[j - 1];
                        PlayerPics[j - 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }
            }

        }
        void PrintHand(List<Card> hand, List<PictureBox> pictureBoxes, bool firstDeal = false)
        {
            if (!firstDeal)
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    pictureBoxes[i].Image = deck.deckImages[hand[i]];
                }
            }
            else
            {
                pictureBoxes[0].Image = deck.deckImages[hand[0]];
                pictureBoxes[1].Image = Properties.Resources.Card_Back;
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle(4);
            //dealing dealer's hand
            for (int i = 0; i < 2; i++)
            {
                DealerHand.Add(deck.Draw());
                if ((int)DealerHand[i].Value >= 10)
                {
                    dealerScore += 10;
                }
                else if (DealerHand[i].Value == Enums.Value.Ace)
                {

                    dealerCheck();
                }
                else
                {
                    dealerScore += (int)DealerHand[i].Value;
                }
            }

            PrintHand(DealerHand, DealerPics, true);
            //if the dealer has 21, they win before the player's hand is checked
            if (dealerScore == 21)
            {
                dealt21 = true;
                PrintHand(DealerHand, DealerPics);
                DialogResult dialogResult = MessageBox.Show("The dealer scored 21! Would you like to play again?", "Loss", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }

            }

            //dealing player's hand if the dealer doesnt get a 21 on their first turn
            if (!dealt21)
            {
                for (int i = 0; i < 2; i++)
                {
                    PlayerHand.Add(deck.Draw());
                    if ((int)PlayerHand[i].Value >= 10)
                    {
                        playerScore += 10;
                    }
                    else if (PlayerHand[i].Value == Enums.Value.Ace)
                    {
                        using (AceDialogue aceDialogue = new AceDialogue(playerScore))
                        {
                            if (aceDialogue.ShowDialog() == DialogResult.OK)
                            {
                                playerScore += aceDialogue.ChosenValue;
                            }
                        }
                    }
                    else
                    {
                        playerScore += (int)PlayerHand[i].Value;
                    }

                }
                PrintHand(PlayerHand, PlayerPics);
                scoreLabel.Text = playerScore.ToString();
                dealButton.Enabled = false;
                drawButton.Enabled = true;
                keepButton.Enabled = true;
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Card cardDrawn = deck.Draw();
            if ((int)cardDrawn.Value >= 10)
            {
                playerScore += 10;
            }
            else if (cardDrawn.Value == Enums.Value.Ace)
            {
                using (AceDialogue aceDialogue = new AceDialogue(playerScore))
                {
                    if (aceDialogue.ShowDialog() == DialogResult.OK)
                    {
                        playerScore += aceDialogue.ChosenValue;
                    }
                }
            }
            else
            {
                playerScore += (int)cardDrawn.Value;
            }

            PlayerHand.Add(cardDrawn);
            scoreLabel.Text = playerScore.ToString();
            PrintHand(PlayerHand, PlayerPics);
            checkScore();
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            if (dealerScore <= 16)
            {
                Card cardToDraw = deck.Draw();
                if ((int)cardToDraw.Value >= 10)
                {
                    dealerScore += 10;
                }
                else if (cardToDraw.Value == Enums.Value.Ace)
                {

                    dealerCheck();
                }
                else
                {
                    dealerScore += (int)cardToDraw.Value;
                }
                DealerHand.Add(cardToDraw);
            }
            dealerScoreLabel.Visible = true;
            dealerScoreLabel.Text = dealerScore.ToString();
            PrintHand(DealerHand, DealerPics);
            checkScore();
            if (playerScore > dealerScore)
            {
                DialogResult dialogResult = MessageBox.Show("You win! Would you like to play again?", "Win", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }
            else if (playerScore < dealerScore)
            {
                DialogResult dialogResult = MessageBox.Show("Dealer wins! Would you like to play again?", "Loss", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }

        }
    }
}
