using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamiljGUI {
    public class Petowner {
        // Defining data
        private int age = 0;
        private string namePetowner = "Joppe";
        Stream stream = new Stream();
        private string className = "petowner";
        internal List<string> foods = new List<string>();
        internal List<Animal> pets = new List<Animal> {
            new Dog(5, "Alfons", "Pork", "Andalusier"),
            new Puppy(8, "Bea", "Minced meat", "Terrier"),
            new HouseCat(7, "Charles", "Mice", "Norwegan Forestcat"),
            new Leopardus(3, "Diana", "Chiken", "Kodkod"), // Yes thats a legit breed
            new Dog(4, "Eevee", "Minced meat", "Corgie"),
            new Leopardus(9, "Frank", "Pork", "Kodkod"),
            new Puppy(1, "George", "Pork", "Poodle")
        };
        internal List<Ball> balls = new List<Ball>(){
            new Ball("Red", "Smooth", 4, 0),
            new Ball("Blue", "Wavey", 6, 10),
            new Ball("Pink", "Super soft", 6, 16),
            new Ball("Green", "Grass like", 2, 22),
            new Ball("Yellow", "Knobby", 3, 27),
            new Ball("Green", "Hard", 5, 29),
            new Ball("Blue", "Smooth", 3, 30)
        };

        public Petowner() {
            stream.Log($"<{className}> Program started sucessfully");
            int petIndex = 0;
            int ballIndex = 0;
            List<string> loadingStatus = stream.LoadStatus();

            foreach(string line in loadingStatus) {
                if(line.Contains("[ball]")) {
                    string[] loadingBall = line.Replace("[ball]", "").Split(',');

                    balls[ballIndex].Color = loadingBall[0];
                    balls[ballIndex].Texture = loadingBall[1];
                    balls[ballIndex].Size = Convert.ToInt32(loadingBall[2]);
                    balls[ballIndex].Quality = Convert.ToInt32(loadingBall[3]);
                    ballIndex++;
                }
                else if(line.Contains("[pet]")) {
                    string[] loadingPet = line.Replace("[pet]", "").Split(',');

                    pets[petIndex].Name = loadingPet[0];
                    pets[petIndex].Age = Convert.ToInt32(loadingPet[1]);
                    pets[petIndex].Breed = loadingPet[2];
                    pets[petIndex].Hungry = Convert.ToBoolean(loadingPet[3]);
                    pets[petIndex].FavFood = loadingPet[4];
                    petIndex++;
                }
            }
        }

        private void LogStatus() {
            stream.Log($"<{className}> Begins status update to file, " + stream.StatusFile);
            List<string> updateData = new List<string>();

            foreach(Ball ball in balls) {
                updateData.Add($"[ball]{ball.Color},{ball.Texture},{ball.Size},{ball.Quality}");
            }
            
            foreach(Animal pet in pets) {
                updateData.Add($"[pet]{pet.Name},{pet.Age},{pet.Breed},{pet.Hungry},{pet.FavFood}");
            }

            stream.SaveStatus(updateData);
            stream.Log($"<{className}> Status update was successful");
        }
        
        // TODO: Make method to play fetch.
    }
}
