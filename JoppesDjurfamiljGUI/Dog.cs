using System;

namespace JoppesDjurfamiljGUI {
    public class Dog : Animal{
        public Dog(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed; 
        }

        public override string Interact(Ball ball) {
            if(Hungry) {
                //stream.Log($"<{baseClassName}> Too hungry to play");
                return ($"{Name} nudges the ball and sits down");
            }
            else {
                int lowerQuality = random.Next(7);
                ball.Quality -= lowerQuality;
                if(ball.Quality < 0) {
                    ball.Quality = 0;
                    //Form1.RichTextBoxRead(ball + " is now broken");
                }
                //stream.Log($"<{baseClassName}> Quality went down to " + ball.Quality);
                //stream.Log($"<{baseClassName}> Successfully played with pet");

                return ($"{Name} runs after it furiosly and quickly runs back, all while barking");
            }
        }

        public override string HungryAnimal() {
            return ($"{Name} takes a nibble of the food and whimpers. Refusing to eat more.");
        }

        public override string ToString() {
            return $"{Name}, Dog";
        }

    }
}
