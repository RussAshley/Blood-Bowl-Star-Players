using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bowl_Star_Players
{
    public partial class Form1 : Form
    {
        private StarPlayer starPlayer = new StarPlayer("Griff Oberwald", 7, 4, 2, 3, 9, "Block, dodge, fend, Loner 3+, Sprint, Sure Feet", "yes", "no", "yes", "no", "no", "no", "no", "no", "no", 280, "image here", "Consumate Professional: Once per game , Griff may re-roll one dice that was rolled  either as a single dice roll, as part of a multiple dice roll or as part of a dice pool (this cannot be a dice that was rolled as part of an Armour, Injury or Casualty roll");

        public Form1()
        {
            InitializeComponent();
            starPlayerNametextBox.Text = starPlayer.StarPlayerName;
            CosttextBox.Text = starPlayer.Cost.ToString();
            MAtextBox.Text = starPlayer.MovementAllowance.ToString();
            STtextBox.Text = starPlayer.Strength.ToString();
            AGtextBox.Text = starPlayer.Agility.ToString();
            PAtextBox.Text = starPlayer.PassingAbility.ToString();
            AVtextBox.Text = starPlayer.ArmourValue.ToString();
            SkillstextBox.Text = starPlayer.Skills.ToString();
            specialRulestextBox.Text = starPlayer.SpecialRules;
            



        }

    }
}
