using System;

namespace LiveCodingTempFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Halloween is coming, and you need to figure out how much candy to buy.
            //Luckily you have tracked the weather, temperature,and number of tricker treaters from years past.From your research you have tracked 4 different types of weather: 
            //"Clear", "Cloudy", "Raining", "Full Moon"
            //From your research you have tracked 4 differnt types of temperature 40s, 50s, 60s, 70s
            //You get 10% more trick or treaters if the weather is clear
            //You get 0% more trick or treaters if the weather is cloudy
            //You get 25% less trick or treaters if the weather is rainy
            //You get 25% more trick or treaters if the weather is Full Moon
            //You get more trick or treaters the warmer the weather
            //You get 5% less trick or treaters if it's in the 40s
            //You get 0% more trick or treaters if it's in the 50s
            //You get 5% more trick or treaters if it's in the 60s
            //You get 20% more trick or treaters if its' in the 70s
            //On average you get 250 trick or treaters, and you want to give each kid 3 pieces of candy.
            //How much candy do you need to buy if it's clear, and in the 50s? 825
            //How much candy do you need to buy if it's a full moon, and in the 40s? 900
            //How much candy do you need to buy if it's raining, and in the 70s? 712.5

            //weather (4), temperature(4), # of trick or treaters (250 average: 3 pieces of candy per child)
            double kidCount = 250;

            Console.WriteLine("Please input the weather: ");
            string weather = Console.ReadLine();

            Console.WriteLine("Please input the temperature: ");
            string temperature = Console.ReadLine();

            //TODO: figure out how to turn string to int
            //original coded: int temp = Parse(temperature);
            //completed!
            int temp = Int32.Parse(temperature);

            //weather: Clear, Cloudy, Raining, Full Moon
            if (weather == "Clear")
            { kidCount += (kidCount * .1); }
            if (weather == "Cloudy")
            { kidCount = 250; }
            if (weather == "Raining")
            { kidCount -= (kidCount * .25); }
            if (weather == "Full Moon")
            { kidCount += (kidCount * .25); }

            //temperature: 40s, 50s, 60s, 70s
            if (temp < 49 && temp >= 40)
            { kidCount -= (kidCount * .05); }
            //if (temp < 59 && temp >= 50)
            //{ kidCount = kidCount; }
            if (temp < 69 && temp >= 60)
            { kidCount += (kidCount * .05); }
            if (temp < 79 && temp >= 70)
            { kidCount += (kidCount * .2); }

            double totalCandy = kidCount * 3;

            Console.WriteLine($"The amount of candy you need to get is: {totalCandy}");
        }
    }
}
