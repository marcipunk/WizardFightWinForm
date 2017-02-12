using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardFight
{
    public partial class Form1 : Form
    {
        
        Character nyertes;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fight MyFight = new Fight();



            fightBox.Text += System.Environment.NewLine;
            fightBox.Text += MyFight.Gandalf.ToString();
            fightBox.Text += System.Environment.NewLine;
            fightBox.Text += MyFight.Devil.ToString();
            fightBox.Text += System.Environment.NewLine;
            fightBox.Text += "Gandalf varázslat listája: ";
            fightBox.Text += System.Environment.NewLine;
            for (int i = 0; i < MyFight.Gandalf.Spells.Count; i++)
            {
                fightBox.Text += MyFight.Gandalf.Spells[i].ToString() + Environment.NewLine;
            }
            fightBox.Text += "Devil varázslat listája: ";
            fightBox.Text += System.Environment.NewLine;
            for (int i = 0; i < MyFight.Devil.Spells.Count; i++)
            {
                fightBox.Text += MyFight.Devil.Spells[i].ToString() + Environment.NewLine;
            }
            fightBox.Text += System.Environment.NewLine;
            fightBox.Text += "###--------<<<CSATA>>>-------###";

            

            nyertes = MyFight.WFight();
           
            gwlabel.Text = MyFight.Gandalf.Name;
            ewlabel.Text = MyFight.Devil.Name;

            //gwLife.Text = string.Empty;
            //ewLife.Text = string.Empty;

            gwLife.Text = MyFight.Gandalf.Slife.ToString();
            ewLife.Text = MyFight.Devil.Slife.ToString();

            winnerLabel.BackColor = System.Drawing.Color.Black;

            if (nyertes.Equals(MyFight.Gandalf))
            {
                beer.Location = new System.Drawing.Point(115, 315);
                beer.Visible = true;
                winnerLabel.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                beer.Location = new System.Drawing.Point(405, 315);
                beer.Visible = true;
                winnerLabel.ForeColor = System.Drawing.Color.Purple;
            }

            winnerLabel.Text = "A nyertes: " + nyertes.ToString();
        }

        private void fightBox_TextChanged(object sender, EventArgs e)
        {
            fightBox.SelectionStart = fightBox.Text.Length;
            fightBox.ScrollToCaret();
            //fightBox.Refresh();
        }
    }
}
