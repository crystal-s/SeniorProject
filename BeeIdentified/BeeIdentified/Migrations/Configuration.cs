namespace BeeIdentified.Migrations
{
    using Data.Entities;
    using System.Data.Entity.Migrations;

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
            /* Add bee data to the database. */
            context.BeeDatas.AddOrUpdate(
                b => b.BeeID,
                new BeeData { BeeID = "1", CommonName = "Bumblebee", LatinName = "Bombus", ConservationStatus = ConservationStatus.Endangered, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "2", CommonName = "Yellow Faced Bumblebee", LatinName = "Bombus vosnesenskii", ConservationStatus = ConservationStatus.LeastConcern, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "3", CommonName = "Black Tailed Bumblebee / Orange Rumped Bumblebee", LatinName = "Bombus melanopygus", ConservationStatus = ConservationStatus.LeastConcern, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Orange, Fuzzy = true },

                new BeeData { BeeID = "4", CommonName = "Western Bumblebee", LatinName = "Bombus occidentalis", ConservationStatus = ConservationStatus.Vulnerable, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = true, Photo = "/Photo/WesternBumbleBee.jpg" },

                new BeeData { BeeID = "5", CommonName = "Mason Bee", LatinName = "Osmia", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Red, SecondColor = Color.Orange, ThirdColor = Color.Black, Fuzzy = true, Photo = "/Photo/Osmia1.jpg" },

                new BeeData { BeeID = "6", CommonName = "Blue Orchard Mason Bee", LatinName = "Osmia lignaria", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Blue, ThirdColor = Color.Green, Fuzzy = true, Photo = "/Photos/Osmia2.jpg" },

                new BeeData { BeeID = "7", CommonName = "Sweat Bee", LatinName = "Lasioglossum", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Brown, Fuzzy = false },

                new BeeData { BeeID = "8", CommonName = "Sweat Bee", LatinName = "Halictus", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = false },

                new BeeData { BeeID = "9", CommonName = "Death Camas Bee", LatinName = "Andrena astragali", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.White, Fuzzy = true },

                new BeeData { BeeID = "10", CommonName = "Snowy Miner / Snowy Adrena", LatinName = "Andrena nivalis", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "11", CommonName = "Western Leafcutter Bee", LatinName = "Megachile perihirta", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "12", CommonName = "Silver-Tailed Petalcutter", LatinName = "Megachile montivaga", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.White, ThirdColor = Color.Yellow, Fuzzy = true },

                new BeeData { BeeID = "13", CommonName = "Cuckoo Bee", LatinName = "Triepeolus concavus", ConservationStatus = ConservationStatus.DataDeficient, FirstColor = Color.Black, SecondColor = Color.Yellow, ThirdColor = Color.Yellow, Fuzzy = false, Photo = "/Photo/TriepeolusConcavus.jpg" }

                // Template for new seed data
                //new BeeData { BeeID = "14", CommonName = "", LatinName = "", ConservationStatus = ConservationStatus., FirstColor = Color.Black, SecondColor = Color, ThirdColor = Color, Fuzzy = },

                );

            // How to seed data for a particular user by user id, bee id, and a location
            //context.UserBees.AddOrUpdate(
            //    u => u.UserID,
            //    new UserBees { UserID = "155f9026-a800-49ed-bbcf-b77c70bcfda2", BeeID = "2", Location = "Portland, OR" },
            //    new UserBees { UserID = "155f9026-a800-49ed-bbcf-b77c70bcfda2", BeeID = "3", Location = "Bend, OR" }
            //    );   
        }
    }
}
