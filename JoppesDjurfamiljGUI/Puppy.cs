﻿using System;

namespace JoppesDjurfamiljGUI {
    class Puppy : Dog {
        public Puppy(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed; 
        }

        public override void Interact(Ball ball) {
            if(Hungry) {
                Console.WriteLine("{0} begins to play with the ball but quickly lays down and whimper", Name);
                stream.Log($"<{baseClassName}> Too hungry to play");
            }
            else {
                Console.WriteLine("{0} runs after the ball while tripping a few times, trying to catch it", Name);

                int lowerQuality = random.Next(2);
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
            Console.WriteLine("{0} whimpers and turns around, pretending there is no food.", Name);
        }
        
        public override string AgeString() {
            return $"{Age} months";
        }

        public override string ToString() {
            return $"{Name}, Puppy";
        }
    }
}
