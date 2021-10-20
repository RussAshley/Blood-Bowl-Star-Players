using System;
using System.Collections.Generic;
using System.Text;

namespace Blood_Bowl_Star_Players
{
    class StarPlayer
    {

        private string starPlayerName;
        private int movementAllowance;
        private int strength;
        private int agility;
        private int passingAbility;
        private int armourValue;
        private string skills;
        private string halflingThimbleCup;
        private string lustrianSuperLeague;
        private string oldWorldClassic;
        private string sylvanianSpotlight;
        private string elvenKingdomsLeague;
        private string worldsEdgeSuperleague;
        private string badlandsBrawl;
        private string underworldChallenge;
        private string favouredOf;
        private int cost;
        private string starPlayerImage;
        private string specialRules;

        public StarPlayer(string starPlayerName, int movementAllowance, int strength, int agility, int passingAbility, int armourValue, string skills, string halflingThimbleCup, string lustrianSuperLeague, string oldWorldClassic, string sylvanianSpotlight, string elvenKingdomsLeague, string worldsEdgeSuperleague, string badlandsBrawl, string underworldChallenge, string favouredOf, int cost, string starPlayerImage, string specialRules)
        {
            this.StarPlayerName = starPlayerName;
            this.MovementAllowance = movementAllowance;
            this.Strength = strength;
            this.Agility = agility;
            this.PassingAbility = passingAbility;
            this.ArmourValue = armourValue;
            this.Skills = skills;
            this.HalflingThimbleCup = halflingThimbleCup;
            this.LustrianSuperLeague = lustrianSuperLeague;
            this.OldWorldClassic = oldWorldClassic;
            this.SylvanianSpotlight = sylvanianSpotlight;
            this.ElvenKingdomsLeague = elvenKingdomsLeague;
            this.WorldsEdgeSuperleague = worldsEdgeSuperleague;
            this.BadlandsBrawl = badlandsBrawl;
            this.UnderworldChallenge = underworldChallenge;
            this.FavouredOf = favouredOf;
            this.Cost = cost;
            this.StarPlayerImage = starPlayerImage;
            this.SpecialRules = specialRules;
        }

        public string StarPlayerName { get => starPlayerName; set => starPlayerName = value; }
        public int MovementAllowance { get => movementAllowance; set => movementAllowance = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Agility { get => agility; set => agility = value; }
        public int PassingAbility { get => passingAbility; set => passingAbility = value; }
        public int ArmourValue { get => armourValue; set => armourValue = value; }
        public string Skills { get => skills; set => skills = value; }
        public string HalflingThimbleCup { get => halflingThimbleCup; set => halflingThimbleCup = value; }
        public string LustrianSuperLeague { get => lustrianSuperLeague; set => lustrianSuperLeague = value; }
        public string OldWorldClassic { get => oldWorldClassic; set => oldWorldClassic = value; }
        public string SylvanianSpotlight { get => sylvanianSpotlight; set => sylvanianSpotlight = value; }
        public string ElvenKingdomsLeague { get => elvenKingdomsLeague; set => elvenKingdomsLeague = value; }
        public string WorldsEdgeSuperleague { get => worldsEdgeSuperleague; set => worldsEdgeSuperleague = value; }
        public string BadlandsBrawl { get => badlandsBrawl; set => badlandsBrawl = value; }
        public string UnderworldChallenge { get => underworldChallenge; set => underworldChallenge = value; }
        public string FavouredOf { get => favouredOf; set => favouredOf = value; }
        public int Cost { get => cost; set => cost = value; }
        public string StarPlayerImage { get => starPlayerImage; set => starPlayerImage = value; }
        public string SpecialRules { get => specialRules; set => specialRules = value; }
    }
}
