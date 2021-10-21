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
        static StarPlayer starPlayerGriff = new StarPlayer("Griff Oberwald", 7, 4, 2, 3, 9, "Block, dodge, fend, Loner 3+, Sprint, Sure Feet", "yes", "no", "yes", "no", "no", "no", "no", "no", "no", 280, "image here", "Consumate Professional: Once per game , Griff may re-roll one dice that was rolled  either as a single dice roll, as part of a multiple dice roll or as part of a dice pool (this cannot be a dice that was rolled as part of an Armour, Injury or Casualty roll");
        static StarPlayer starPlayerKarla = new StarPlayer("Karla Von Kill", 6, 3, 3, 4, 9, "Block, Dauntless, Dodge, Jump Up, Loner 4+", "yes", "yes", "yes", "no", "no", "no", "no", "no", "no", 210, "image here", "Indomitable: Once per game, when Karla successfully rolls to use her Dauntless skill, she may increase her strengthcharacteristic to double that of her nominated Block target");

        StarPlayer[] playerArray = new StarPlayer[] { starPlayerGriff, starPlayerKarla };

        int index = 0;
        public Form1()
        {
            InitializeComponent();
            starPlayerNametextBox.Text = playerArray[index].StarPlayerName;
            CosttextBox.Text = playerArray[index].Cost.ToString();

            MAtextBox.Text = playerArray[index].MovementAllowance.ToString();
            STtextBox.Text = playerArray[index].Strength.ToString();
            AGtextBox.Text = playerArray[index].Agility.ToString();
            PAtextBox.Text = playerArray[index].PassingAbility.ToString();
            AVtextBox.Text = playerArray[index].ArmourValue.ToString();
            SkillstextBox.Text = playerArray[index].Skills.ToString();
            specialRulestextBox.Text = playerArray[index].SpecialRules;
            



        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            index++;
            if(index >playerArray.Length -1)
            {
                index = 0;
            }
            starPlayerNametextBox.Text = playerArray[index].StarPlayerName;
            CosttextBox.Text = playerArray[index].Cost.ToString();

            MAtextBox.Text = playerArray[index].MovementAllowance.ToString();
            STtextBox.Text = playerArray[index].Strength.ToString();
            AGtextBox.Text = playerArray[index].Agility.ToString();
            PAtextBox.Text = playerArray[index].PassingAbility.ToString();
            AVtextBox.Text = playerArray[index].ArmourValue.ToString();
            SkillstextBox.Text = playerArray[index].Skills.ToString();
            specialRulestextBox.Text = playerArray[index].SpecialRules;

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            index--;
            if (index < playerArray.Length - 1)
            {
                index = 0;
            }
            starPlayerNametextBox.Text = playerArray[index].StarPlayerName;
            CosttextBox.Text = playerArray[index].Cost.ToString();

            MAtextBox.Text = playerArray[index].MovementAllowance.ToString();
            STtextBox.Text = playerArray[index].Strength.ToString();
            AGtextBox.Text = playerArray[index].Agility.ToString();
            PAtextBox.Text = playerArray[index].PassingAbility.ToString();
            AVtextBox.Text = playerArray[index].ArmourValue.ToString();
            SkillstextBox.Text = playerArray[index].Skills.ToString();
            specialRulestextBox.Text = playerArray[index].SpecialRules;
        }
    }
}
