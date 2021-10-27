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
        static PlayerDataAccess pda = new PlayerDataAccess("Data Source = StarData.db");
        //static StarPlayer starPlayerGriff = new StarPlayer("Griff Oberwald", 7, 4, 2, 3, 9, "Block, dodge, fend, Loner 3+, Sprint, Sure Feet", "yes", "no", "yes", "no", "no", "no", "no", "no", "no", 280, "image here", "Consumate Professional: Once per game , Griff may re-roll one dice that was rolled  either as a single dice roll, as part of a multiple dice roll or as part of a dice pool (this cannot be a dice that was rolled as part of an Armour, Injury or Casualty roll");
        //static StarPlayer starPlayerKarla = new StarPlayer("Karla Von Kill", 6, 3, 3, 4, 9, "Block, Dauntless, Dodge, Jump Up, Loner 4+", "yes", "yes", "yes", "no", "no", "no", "no", "no", "no", 210, "image here", "Indomitable: Once per game, when Karla successfully rolls to use her Dauntless skill, she may increase her strengthcharacteristic to double that of her nominated Block target");

        StarPlayer[] playerArray; // = new StarPlayer[] { starPlayerGriff, starPlayerKarla };

        int index = 0;
        public Form1()
        {
            InitializeComponent();
            playerArray = pda.ReadAllStars();

            populateForm();
           
         }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            index++;
            if(index >playerArray.Length -1)
            {
                index = 0;
            }
            populateForm();
            

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            index--;
            if (index < playerArray.Length - 1)
            {
                index = 0;
            }
            populateForm();
            
        }

        private void populateForm()
        {
            string compare = "Yes";

            string htc="";
            string ls="";
            string owc="";
            string ss="";
            string ekl="";
            string wes="";
            string bb="";
            string uc="";
            string fo="";
                    

            starPlayerNametextBox.Text = playerArray[index].StarPlayerName;
            CosttextBox.Text = playerArray[index].Cost.ToString();

            MAtextBox.Text = playerArray[index].MovementAllowance.ToString();
            STtextBox.Text = playerArray[index].Strength.ToString();
            AGtextBox.Text = playerArray[index].Agility.ToString();
            PAtextBox.Text = playerArray[index].PassingAbility.ToString();
            AVtextBox.Text = playerArray[index].ArmourValue.ToString();
            SkillstextBox.Text = playerArray[index].Skills.ToString();
            specialRulestextBox.Text = playerArray[index].SpecialRules;
            StarpictureBox.Image = Image.FromFile(playerArray[index].StarPlayerImage);


            if (playerArray[index].HalflingThimbleCup == compare )
            {
                htc = "Halfling Thimble Cup, ";
            }
            else
            {
                htc = "";
            }

            if (playerArray[index].LustrianSuperLeague == compare )
            {
                ls = "Lustrian Superleague, ";
            }
            else
            {
                ls = "";
            }

            if (playerArray[index].OldWorldClassic == compare)
            {
                owc = "Old World Classic, ";
            }
            else
            {
                owc = "";
            }


            if (playerArray[index].SylvanianSpotlight == compare )
            {
               ss= "Sylvanian Spotlight, ";
            }
            else
            {
                ss = "";
            }

            if (playerArray[index].ElvenKingdomsLeague == compare )
            {
                ekl = "Elven Kingdom League, " ;
            }
            else
            {
                ekl = "";
            }

            if (playerArray[index].WorldsEdgeSuperleague == compare )
            {
                wes = "Worlds Edge Superleague";
            }
            else
            {
                wes = "";
            }

            if (playerArray[index].BadlandsBrawl == compare )
            {
                bb = "Badlands Brawl, ";
            }
            else
            {
                bb = "";
            }

            if (playerArray[index].UnderworldChallenge == compare )
            {
               uc = "Underworld Challenge, ";
            }
            else
            {
                uc = "";
            }

            if (playerArray[index].FavouredOf == compare )
            {
                fo = "Favoured Of...,  ";
            }
            else
            {
                fo = "";
            }

            LeaguestextBox.Text = htc + ls  + owc +  ss + ekl +  wes +  bb +  uc +  fo;


        }

        private void HalflingThimbleradioButton_Click(object sender, EventArgs e)
        {
           
             playerArray = pda.ReadAllStars();
            for (int i = 0; i < playerArray.Length; i++)
            

               if (playerArray[index].HalflingThimbleCup == "Yes")
              {
                comboBox1.Items.Add(playerArray[i].StarPlayerName);
              
            }
           
           
        }









        private void populateSidebar()
        {
           
        }
    }




}
