using System;

namespace JoppesDjurfamiljGUI {
    public class Cat : Animal {
        public Cat(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed;
        }

        public override string Interact(Ball ball) {
            if(Hungry) {
                //stream.Log($"<{baseClassName}> Too hungry to play");
                return ($"{Name} whimpers and lays down");
            }
            else {
                int lowerQuality = random.Next(4);
                ball.Quality -= lowerQuality;
                if(ball.Quality < 0) {
                    ball.Quality = 0;
                    //form.RichTextBoxRead(ball + " is now broken");
                }
                //stream.Log($"<{baseClassName}> Quality went down to " + ball.Quality);
                //stream.Log($"<{baseClassName}> Successfully played with pet");

                return ($"{Name} starts purring and lays down next to the {ball}");
            }
        }

        public override string HungryAnimal() {
            int catchMice = random.Next(3);
            if(catchMice == 0) {
                Hungry = true;
                return ($"{Name} whines a bit before walking away \n ... after a few minutes {Name} is back with a mice");
            }
            return ($"{Name} whines a bit before walking away");
        }

        public override string ToString() {
            return $"{Name}, Cat";
        }
    }
}
