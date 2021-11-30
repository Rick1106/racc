using System;

namespace Classes
{
    class PropertyHandler
    {
        private static string race;
        private static string profession;
        private static string name;
        private static string[] usableProfessions;

        public static void resetValues()
        {
            race = String.Empty;
            profession = String.Empty;
            name = String.Empty;
        }

        public static void setRace(string _race)
        {
            race = _race;
        }

        public static void setProfession(string _profession)
        {
            profession = _profession;
        }

        public static void setName(string _name)
        {
            name = _name;
        }

        public static void setUsableProfessions(string[] _usableProfessions)
        {
            usableProfessions = _usableProfessions;
        }

        public static string getRace()
        {
            return race;
        }

        public static string getProfession()
        {
            return profession;
        }

        public static string getName()
        {
            return name;
        }

        public static string[] getUsableProfessions()
        {
            return usableProfessions;
        }
    }
}