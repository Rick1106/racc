using Classes.Constants;

namespace Classes.Characters
{
    class CharacterStats
    {
        private string race;
        private string profession;

        #region Basic stats
        //General stats
        private int healthPoints;
        private int magicPoints;
        private int armor;
        private int level;

        //Attributes
        private int strength;
        private int agility;
        private int constitution;
        private int intelligence;
        private int charisma;
        #endregion

        //Constructor
        public CharacterStats(string _race, string _profession)
        {
            this.race = _race;
            this.profession = _profession;

            initializeBasicStats();
            calculateGeneralStats();
        }

        //Calculate methods
        private void initializeBasicStats()
        {
            switch (this.race)
            {
                case CRace.RACE_GNOME:
                    this.strength = 0;
                    this.agility = 1;
                    this.constitution = -2;
                    this.intelligence = 1;
                    this.charisma = 0;

                    this.healthPoints = 0;
                    this.armor = 1;
                    break;

                case CRace.RACE_HALFLING:
                    this.strength = 0;
                    this.agility = 1;
                    this.constitution = -2;
                    this.intelligence = 1;
                    this.charisma = 0;

                    this.healthPoints = 0;
                    this.armor = 1;
                    break;

                case CRace.RACE_DWARF:
                    this.strength = 0;
                    this.agility = -1;
                    this.constitution = 2;
                    this.intelligence = 0;
                    this.charisma = -1;

                    this.healthPoints = 1;
                    this.armor = 1;
                    break;

                case CRace.RACE_ELF:
                    this.strength = -1;
                    this.agility = 1;
                    this.constitution = -1;
                    this.intelligence = 0;
                    this.charisma = 1;

                    this.healthPoints = 0;
                    this.armor = 0;
                    break;

                case CRace.RACE_HUMAN:
                    this.strength = 0;
                    this.agility = 0;
                    this.constitution = 0;
                    this.intelligence = 0;
                    this.charisma = 0;

                    this.healthPoints = 0;
                    this.armor = 0;
                    break;
            }

            this.level = 1;

        }
        private void calculateGeneralStats()
        {
            switch (this.profession)
            {
                case CProfession.PROFESSION_SORCERER:
                    this.healthPoints += ((this.constitution + 4) * this.level);
                    this.magicPoints += ((this.intelligence + 3) * this.level);
                    break;

                case CProfession.PROFESSION_RANGER:
                    this.healthPoints += ((this.constitution + 8) * this.level);
                    this.magicPoints += ((this.intelligence + 3) * this.level);
                    break;

                case CProfession.PROFESSION_SHAMAN:
                    this.healthPoints += ((this.constitution + 6) * this.level);
                    this.magicPoints += ((this.charisma + 3) * this.level);
                    break;

                case CProfession.PROFESSION_PRIEST:
                    this.healthPoints += ((this.constitution + 8) * this.level);
                    this.magicPoints += ((this.charisma + 3) * this.level);
                    break;

                case CProfession.PROFESSION_WARRIOR:
                    this.healthPoints += ((this.constitution + 10) * this.level);
                    this.magicPoints += ((this.intelligence + 3) * this.level);
                    break;

                case CProfession.PROFESSION_THIEF:
                    this.healthPoints += ((this.constitution + 6) * this.level);
                    this.magicPoints += ((this.intelligence + 3) * this.level);
                    break;

                case CProfession.PROFESSION_BARD:
                    this.healthPoints += ((this.constitution + 6) * this.level);
                    this.magicPoints += ((this.charisma + 3) * this.level);
                    break;
            }

            this.armor += this.healthPoints - 3;

        }

        //Getter methods
        public string getRace()
        {
            return this.race;
        }
        public string getProfession()
        {
            return this.profession;
        }
        public int getHealthPoints()
        {
            return this.healthPoints;
        }
        public int getMagicPoints()
        {
            return this.magicPoints;
        }
        public int getArmor()
        {
            return this.armor;
        }
        public int getLevel()
        {
            return this.level;
        }
        public int getStrength()
        {
            return this.strength;
        }
        public int getAgility()
        {
            return this.agility;
        }
        public int getConstitution()
        {
            return this.constitution;
        }
        public int getIntelligence()
        {
            return this.intelligence;
        }
        public int getCharisma()
        {
            return this.charisma;
        }
    }
}
