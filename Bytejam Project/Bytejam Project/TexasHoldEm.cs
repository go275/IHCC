﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bytejam_Project
{
    public partial class TexasHoldEm : Form
    {
        public Dictionary<string, Image> CardImages = new Dictionary<string, Image>();
        public List<string> CardDeck;
        public TexasHoldEm()
        {
            InitializeComponent();
        }

        private void TexasHoldEm_Load( object sender, EventArgs e )
        {
            string[] imageFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "/images/");
           for (int x = 0; x < imageFiles.Length; x++)
           {
               string[] splitDirectory = imageFiles[x].Split('/');
               string actualName = splitDirectory[splitDirectory.Length - 1].Split('.')[0];
               CardImages.Add(actualName, Image.FromFile(imageFiles[x]));
           }
           
           DealCards();



        }

        public void DealCards()
        {
            //playerCard1.Image = CardImages["Back"];
            //playerCard2.Image = CardImages["Back"];
            //playerCard3.Image = CardImages["Back"];
            //playerCard4.Image = CardImages["Back"];
            //playerCard5.Image = CardImages["Back"];
            //
            //dealerCard1.Image = CardImages["Back"];
            //dealerCard2.Image = CardImages["Back"];
            //dealerCard3.Image = CardImages["Back"];
            //dealerCard4.Image = CardImages["Back"];
            //dealerCard5.Image = CardImages["Back"];           
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}