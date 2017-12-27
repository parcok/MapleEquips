using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapleEquips.Objects;
using DevExpress.Utils;
using System.Data.SQLite;

namespace MapleEquips {

    public partial class Form1 : Form {
        Item itemTest = new Item("Test Name", 500, 250, 300, 400);
        public Form1() {
            InitializeComponent();
            //panelMir.Location = new Point(461, 41);
            //this.Width = 715;
            //statsGroupBox.Location = new Point(81, 310);
            //pbTotem3.BackgroundImage = MapleEquips.Properties.Resources.ChuChu;
            //pbMirHat.Image = MapleEquips.Properties.Resources.ChuChu;
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

        //this.pbBook.MouseHover += new System.EventHandler(this.pbBook_MouseHover); Ensure to add handler in designer
        private void pbEnhanced_MouseHover(object sender, EventArgs e) {
            /*EnhancedPictureBox hoveredBox = (EnhancedPictureBox)sender;
            if (hoveredBox.Item != null) {
                hoveredBox.Tag = MapleEquips.Properties.Resources.ChuChu;
                enhancedToolTip1.SetToolTip(hoveredBox, "Test");
            }*/
            DevExpress.Utils.SuperToolTip tip = new DevExpress.Utils.SuperToolTip();
            //setup the SuperToolTip...
            ToolTipTitleItem titleItem1 = new ToolTipTitleItem();
            titleItem1.Text = "Edit Popup Menu";
            tip.Items.Add(titleItem1);
            Image resImage = MapleEquips.Properties.Resources.ChuChu;
            ToolTipItem item1 = new ToolTipItem();
            item1.Image = resImage;
            item1.Text = "Show the Edit popup menu";
            tip.Items.Add(item1);
            totem3.SuperTip = tip;
        }

        private void equipmentHover(object sender, EventArgs e) {
            try {
                DevExpress.XtraEditors.PictureEdit box = (DevExpress.XtraEditors.PictureEdit)sender;
                DevExpress.Utils.SuperToolTip tip = new DevExpress.Utils.SuperToolTip();
                SuperToolTipSetupArgs itemInfo = new SuperToolTipSetupArgs();
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.db;Version=3;");
                m_dbConnection.Open();
                string sql = "select * from equips where equipSlot='" + box.Name + "'";
                Console.WriteLine(sql);
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    Console.WriteLine("Result set found!");
                    Console.WriteLine("Title: " + reader["title"] + "\tText: " + reader["text"]);
                    itemInfo.Title.Text = Convert.ToString(reader["title"]);
                    itemInfo.Contents.Image = box.BackgroundImage;
                    itemInfo.Contents.Text = Convert.ToString(reader["text"]).Replace("<br>", "\r\n");
                    itemInfo.ShowFooterSeparator = true;
                    itemInfo.Footer.Text = Convert.ToString(reader["footer"]).Replace("<br>", "\r\n");
                }
                tip.Setup(itemInfo);
                box.SuperTip = tip;
            } catch {
                MessageBox.Show("There was an error showing the equipment stats.");
            }
        }


        private void pbEnhanced_MouseLeave(object sender, EventArgs e) {
            EnhancedPictureBox hoveredBox = (EnhancedPictureBox)sender;
            hoveredBox.Tag = null;
        }
    }
}
