﻿namespace Classes.Constants
{
    class CProfession
    {
        public const string PROFESSION_BARD = "Bard";
        public const string PROFESSION_THIEF = "Thief";
        public const string PROFESSION_WARRIOR = "Warrior";
        public const string PROFESSION_PRIEST = "Priest";
        public const string PROFESSION_SHAMAN = "Shaman";
        public const string PROFESSION_RANGER = "Ranger";
        public const string PROFESSION_SORCERER = "Sorcerer";

        public static string[] PROFESSIONS_HUMAN = new string[] { PROFESSION_BARD, PROFESSION_THIEF, PROFESSION_WARRIOR, PROFESSION_PRIEST, PROFESSION_SHAMAN, PROFESSION_RANGER, PROFESSION_SORCERER };
        public static string[] PROFESSIONS_ELF = new string[] { PROFESSION_BARD, PROFESSION_THIEF, PROFESSION_PRIEST, PROFESSION_SHAMAN, PROFESSION_RANGER, PROFESSION_SORCERER };
        public static string[] PROFESSIONS_DWARF = new string[] { PROFESSION_BARD, PROFESSION_THIEF, PROFESSION_WARRIOR, PROFESSION_PRIEST, PROFESSION_SHAMAN, PROFESSION_RANGER };
        public static string[] PROFESSIONS_HAFLING = new string[] { PROFESSION_BARD, PROFESSION_THIEF, PROFESSION_WARRIOR, PROFESSION_PRIEST, PROFESSION_SHAMAN, PROFESSION_RANGER, PROFESSION_SORCERER };
        public static string[] PROFESSIONS_GNOME = new string[] { PROFESSION_BARD, PROFESSION_THIEF, PROFESSION_WARRIOR, PROFESSION_PRIEST, PROFESSION_SHAMAN, PROFESSION_RANGER, PROFESSION_SORCERER };
    }
}