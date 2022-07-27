using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prepration
{
    class Light
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Location { get; set; }

        public bool Mode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Different ways to Store Class Object in Array
            Light light = new Light
            {
                Id = 1,
                Brand = "Bajaj",
                Location = "Sector 52",
                Mode = true
            };

            Light light1 = new Light
            {
                Id = 2,
                Brand = "Bajaj",
                Location = "Sector 62",
                Mode = false
            };

            Light light3 = new Light
            {
                Id = 3,
                Brand = "Siska",
                Location = "Sector 63",
                Mode = true
            };

            Light[] lights = { light, light1, light3 };

            Light[] lights1 = {new Light { Id = 101, Brand = "Bajaj", Location = " sector_61" , Mode = true},
                                new Light { Id = 102, Brand = "Bajaj", Location = " sector_62" , Mode = false},
                                 new Light { Id = 103, Brand = "Siska", Location = " sector_63" , Mode = true}};


            Light[] lights2 =
            {
                new Light
                {
                    Id = 111,
                    Brand = "BAJAJ",
                    Location = "Sector_47",
                    Mode = true
                },
                new Light
                {
                    Id = 222,
                    Brand = "Surya",
                    Location = "Sector_52",
                    Mode = false
                },
                 new Light
                 {
                    Id = 333,
                    Brand = "Surya",
                    Location = "Sector_63",
                    Mode = true
                 },
                  new Light
                  {
                    Id = 444,
                    Brand = "Bajaj",
                    Location = "Sector_62",
                    Mode = false
                  }
            };

            foreach (var item in lights2)
            {
                if (item.Mode == false)
                {
                    Console.WriteLine("This Light is not working :" + " " + item.Id + " " + item.Brand + " " + item.Location);

                }
            }
            Console.ReadLine();
        }
    }
}
