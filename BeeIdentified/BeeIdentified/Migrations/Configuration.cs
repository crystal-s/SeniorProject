namespace BeeIdentified.Migrations
{
    using Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BeeIdentified.Models.ApplicationDbContext";
        }

        protected override void Seed(BeeIdentified.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.BeeDatas.AddOrUpdate(
                b => b.BeeID,
                new BeeData { BeeID = "1", CommonName = "Bumblebee", LatinName = "Bombus", ConservationStatus = ConservationStatus.Endangered, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "2", CommonName = "Yellow Faced Bumblebee", LatinName = "Bombus vosnesenskii", ConservationStatus = ConservationStatus.LeastConcern, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "3", CommonName = "Black Tailed Bumblebee / Orange Rumped Bumblebee", LatinName = "Bombus melanopygus", ConservationStatus = ConservationStatus.LeastConcern, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Orange, Fuzzy = true },

                new BeeData { BeeID = "4", CommonName = "Western Bumblebee", LatinName = "Bombus occidentalis", ConservationStatus = ConservationStatus.Vulnerable, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = true },

                new BeeData { BeeID = "5", CommonName = "Mason Bee", LatinName = "Osmia", FirstColor = Color.Blue, SecondColor = Color.Green, ThirdColor = Color.Black, Fuzzy = true },

                new BeeData { BeeID = "6", CommonName = "Blue Orchard Mason Bee", LatinName = "Osmia lignaria", FirstColor = Color.Black, SecondColor = Color.Blue, Fuzzy = true },

                new BeeData { BeeID = "7", CommonName = "Sweat Bee", LatinName = "Lasioglossum", FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Brown, Fuzzy = false },

                new BeeData { BeeID = "8", CommonName = "Sweat Bee", LatinName = "Halictus", FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = false },

                new BeeData { BeeID = "9", CommonName = "Death Camas Bee", LatinName = "Andrena astragali", FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = true },

                new BeeData { BeeID = "10", CommonName = "Snowy Miner / Snowy Adrena", LatinName = "Andrena nivalis", FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "11", CommonName = "Western Leafcutter Bee", LatinName = "Megachile perihirta", FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "12", CommonName = "Silver-Tailed Petalcutter", LatinName = "Megachile montivaga", FirstColor = Color.Black, SecondColor = Color.White, ThirdColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "13", CommonName = "Cuckoo Bee", LatinName = "Triepeolus concavus", FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Yellow, Fuzzy = false }

                // Template for new seed data
                //new BeeData { BeeID = "14", CommonName = "", LatinName = "", ConservationStatus = ConservationStatus., FirstColor = Color.Black, SecondColor = Color, ThirdColor = Color, Fuzzy = },

                );

        }
    }
}
