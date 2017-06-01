﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapleEquips.Objects;

namespace MapleEquips {

    public partial class Form1 : Form {
        Item itemTest = new Item("Test Name", 500, 250, 300, 400);
        public Form1() {
            InitializeComponent();
            //Width = 1182;
            pbBook.Item = itemTest;
            pbTotem3.BackgroundImage = MapleEquips.Properties.Resources.ChuChu;
            pbMirHat.Image = MapleEquips.Properties.Resources.ChuChu;
            pbMirWing.Image = MapleEquips.Properties.Resources.ChuChu;
            pbMirHat.Image = MapleEquips.Properties.Resources.ChuChu;
            pbMirPendant.BackgroundImage = MapleEquips.Properties.Resources.ChuChu;
            pbMechFrame.Image = MapleEquips.Properties.Resources.ChuChu;
            pbMechTransistor.BackgroundImage = MapleEquips.Properties.Resources.ChuChu;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (Width == 977) {
                Width = 671;
            }

            else {
                Width = 977;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (Width == 977) {
                Width = 671;
            }

            else {
                Width = 977;
            }
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            Form newCharacter = new Forms.NewCharacter(this);
            newCharacter.Show();
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void statsGroupBox_Enter(object sender, EventArgs e) {
            // you can move that group box here so you won't need to individually move all that shit individually and
            // have to keep track of all the identifiers

            // move based on whether the class name is mir or mech
            // fk sky statsGroupBox.Location = new Point(50, 310);
        }

        private void pbBook_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(pbBook, pbBook.Item.hoverStats());
        }

    }
}
