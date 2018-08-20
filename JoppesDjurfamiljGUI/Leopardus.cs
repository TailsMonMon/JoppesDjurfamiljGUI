using System;

namespace JoppesDjurfamiljGUI {
    public class Leopardus : Cat {
        public Leopardus(int _age, string _name, string _favFood, string _breed) : base(_age, _name, _favFood, _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed;
        }

        public override string Interact(Ball ball) {
            //stream.Log($"<{baseClassName}> Not intersted in playing");
            if(Hungry) {
                return ($"{Name} hisses slightly.");
            }
            else {
                return ($"{Name} ignores the ball and climbes the cat-tree instead.");
            }
        }

        public override string ToString() {
            return $"{Name}, Leopardus";
        }

    }
}
