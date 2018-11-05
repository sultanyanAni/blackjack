﻿using System;
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
    public partial class AceDialogue : Form
    {
        public int ChosenValue { get; set; }
        public AceDialogue()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            ChosenValue = 1;
        }

        private void ElevenButton_Click(object sender, EventArgs e)
        {
            ChosenValue = 11;
        }
    }
}
