﻿using System;

namespace JoppesDjurfamiljGUI {
    class Cat : Animal {
        public Cat(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed;
        }

        public override void Interact(Ball ball) {
            if(Hungry) {
                Console.WriteLine("{0} whimpers and lays down", Name);
                stream.Log($"<{baseClassName}> Too hungry to play");
            }
            else {
                Console.WriteLine("{0} starts purring and lays down next to the {1}", Name, ball);

                int lowerQuality = random.Next(4);
                ball.Quality -= lowerQuality;
                if(ball.Quality < 0) {
                    ball.Quality = 0;
                    Console.WriteLine(ball + " is now broken");
                }
                stream.Log($"<{baseClassName}> Quality went down to " + ball.Quality);
                stream.Log($"<{baseClassName}> Successfully played with pet");
            }
        }

        public override void HungryAnimal() {
            Console.WriteLine("{0} whines a bit before walking away", Name);
            int catchMice = random.Next(3);
            if(catchMice == 0) {
                Hungry = true;
            }
            else {
                Console.WriteLine("... after a few minutes {0} is back with a mice", Name);
                Hungry = false;
            }
        }

        public override string ToString() {
            return $"{Name}, Cat";
        }
    }
}
