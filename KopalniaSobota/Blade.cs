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
        public string currentImage;
        string[] nazwy = { "Stone", "Lead", "Copper", "Alluminium", "Iron", "Steel","Stainless steel", "Titan", "Tungsten","Tugsten carbide", "Diamond" };
        string[] tiers = { "", "Upgraded", "Advanced", "Better", "Epic", "Legendary", "Mithical" };
        string[] images = { 
            "",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/stone.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/lead.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/copper.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/allum.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/iron.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/steel.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/stainless.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/titan.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/tungsten.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/carbide.png",
            "https://raw.githubusercontent.com/bartex100/Mine-Clicker/Assets/blades/diamond.png"

        };


        public int PointsPerClick
        {
            get { return pointsPerClick; }
        }
        public void upBladeLevel()
        {
            if (nazwy[pickLevel] != "Diamond")
            {
                cena = cena * 1.6;
                punkty = punkty * 1.5;
                pickLevel++;
                nazwa = tiers[tier] +" "+nazwy[pickLevel];
                currentImage = images[pickLevel];
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
