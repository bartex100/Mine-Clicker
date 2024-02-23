using static System.Net.WebRequestMethods;

namespace KopalniaSobota
{
    internal class Blade
    {
        int pointsPerClick = 1;
        int pickLevel = 0;
        int pickTier = 0;
        public double cena = 50;
        public string nazwa;
        public double punkty=1;
        int tier;
        string[] nazwy = { "Stone", "Lead", "Copper", "Alluminium", "Iron", "Steel","Stainless steel", "Tytanowe", "Wolframowe", "Diamentowe" };
        string[] tiers = { "", "Ulepszone", "Zaawansowane", "Lepsze", "Epickie", "Legendarne", "Mityczne" };
        string[] images = { 
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/stone.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/lead.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/copper.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/allum.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/iron.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/steel.png"

        };
        int upgrades = 0;


        public int PointsPerClick
        {
            get { return pointsPerClick; }
        }
        public void upBladeLevel()
        {
            if (nazwy[pickLevel] != "Diamentowe")
            {
                cena = cena * 1.6;
                punkty = punkty * 1.5;
                pickLevel++;
                nazwa = tiers[tier] +" "+nazwy[pickLevel];
            }
            else
            {
                pickLevel = 0;
                tier++;
                upBladeLevel();
            }
        }

    }
}
