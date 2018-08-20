using System;

namespace JoppesDjurfamiljGUI {
    public class HouseCat : Cat {
        public HouseCat(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed;
        }

        public override string Interact(Ball ball) {
            if(Hungry) {
                //stream.Log($"<{baseClassName}> Too hungry to play");
                return ($"{Name} ignores the ball");
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

                return ($"{Name} hides and gets ready to hunt the {ball} with a big jump.");
            }
        }

        public override string HungryAnimal() {
            return ($"{Name} whines a bit before walking away");
        }

        public override string ToString() {
            return $"{Name}, House cat";
        }

    }
}
