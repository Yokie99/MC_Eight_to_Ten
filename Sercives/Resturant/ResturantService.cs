
namespace MC_Eight_to_Ten.Sercives.Resturant
{
    public class ResturantService : IResturantService
    {
        public string WhatToEat(string input)
        {
            var rand = new Random();
            int num = rand.Next(10);
            string[] asianFood = { "China Palace", "Mandrin Villa", "Pho Island", "Golden Spoon", "Panda Express", "Ahi Poke", "Thai Me Up", "GK Mongolian", "Kitty's Kitchen", "Oz KBBQ" };
            string[] fastFood = { "McDonald", "Taco Bell", "Burger King", "Wendys", "Rasing Canes", "In N Out", "Chipolte", "Jack in the Box", "Chick-Fil-A", "Five Guys" };
            string[] mexicanFood = { "La Costa", "El Jardin", "Tato's Grill", "El Forastero", "San Marcos", "Taqueria Yvette", "Las Casuelas", "La Estrella", "El Polo Loco", "Fello's Mexican Food" };

            if (input == "Asian")
            {
                return $"Let's go get {asianFood[num]} !";
            }
            else if (input == "FastFood")
            {
                return $"Let's go get {fastFood[num]} !";
            }
            else if (input == "Mexican")
            {
                return $"Let's go get {mexicanFood[num]} !";
            }
            else
            {
                return "I don't know which category this is. Try another request. Either Asian, FastFood, or Mexican";
            }

        }

    }
}