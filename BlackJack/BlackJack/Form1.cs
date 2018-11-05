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
        int score;
        Deck deck = new Deck();
        List<Card> Hand = new List<Card>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void PrintHand()
        {
            handLabel.Text = "";
            for (int i = 0; i < Hand.Count; i++)
            {
                handLabel.Text += Hand[i].ToString() + "\n";
            }
           
        }
        private void dealButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle(4);
            for (int i = 0; i < 2; i++)
            {
                Hand.Add(deck.Draw());
                if((int)Hand[i].Value >= 10)
                {
                    score += 10;
                }
                else if (Hand[i].Value == Enums.Value.Ace)
                {
                    using (AceDialogue aceDialogue = new AceDialogue())
                    {
                        if(aceDialogue.ShowDialog() == DialogResult.OK)
                        {
                            score += aceDialogue.ChosenValue;
                        }
                    }
                }
                else
                {
                    score += (int)Hand[i].Value;
                }
                
            }
            PrintHand();
            scoreLabel.Text = score.ToString();
            dealButton.Enabled = false;
            drawButton.Enabled = true;
            keepButton.Enabled = true;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Card cardDrawn = deck.Draw();
            if ((int)cardDrawn.Value >= 10)
            {
                score += 10;
            }
            else if (cardDrawn.Value == Enums.Value.Ace)
            {
                using (AceDialogue aceDialogue = new AceDialogue())
                {
                    if (aceDialogue.ShowDialog() == DialogResult.OK)
                    {
                        score += aceDialogue.ChosenValue;
                    }
                }
            }
            else
            {
                score += (int)cardDrawn.Value;
            }
         
            Hand.Add(cardDrawn);
            scoreLabel.Text = score.ToString();
            PrintHand();
        }
    }
}
