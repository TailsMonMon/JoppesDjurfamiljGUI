using System;

namespace JoppesDjurfamiljGUI {
    public class Puppy : Dog {
        public Puppy(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed; 
        }

        public override string Interact(Ball ball) {
            if(Hungry) {
                //stream.Log($"<{baseClassName}> Too hungry to play");
                return ($"{Name} begins to play with the ball but quickly lays down and whimper");
            }
            else {
                int lowerQuality = random.Next(2);
                ball.Quality -= lowerQuality;
                if(ball.Quality < 0) {
                    ball.Quality = 0;
                    Console.WriteLine(ball + " is now broken");
                }
                //stream.Log($"<{baseClassName}> Quality went down to " + ball.Quality);
                //stream.Log($"<{baseClassName}> Successfully played with pet");

                return ($"{Name} runs after the ball while tripping a few times, trying to catch it");
            }
        }

        public override string HungryAnimal() {
            return ($"{Name} whimpers and turns around, pretending there is no food.");
        }
        
        public override string AgeString() {
            return $"{Age} months";
        }

        public override string ToString() {
            return $"{Name}, Puppy";
        }
    }
}
