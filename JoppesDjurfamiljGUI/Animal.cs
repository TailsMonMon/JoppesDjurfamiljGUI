using System;

namespace JoppesDjurfamiljGUI {
    public abstract class Animal{
        // Defining data
        internal Random random = new Random();
        internal Stream stream = new Stream();
        internal string baseClassName = "animal";
        internal int age = 0;
        internal string name = "";
        internal string favFood = "";
        internal string breed = "";
        internal bool hungry = false;

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string FavFood {
            get { return favFood; }
            set { favFood = value; }
        }

        public string Breed {
            get { return breed; }
            set { breed = value; }
        }

        public bool Hungry {
            get { return hungry; }
            set { hungry = value; }
        }

        public Animal(int _age, string _name, string _favFood, string _breed) {
            this.age = _age;
            this.name = _name;
            this.favFood = _favFood;
            this.breed = _breed;
        }

        public abstract string Interact(Ball ball);

        public abstract string HungryAnimal();

        public string Eat(string food) {
            if(!Hungry) {
                return (Name + " is not hungry");
            }
            else {

                if(food == FavFood) {
                    Hungry = false;
                    return (Name + " eats hungrily"); 
                }
                else {
                    HungryAnimal();
                    return (Name + " whimpers. \n");
                }

            }
        }
        
        public virtual string AgeString() {
            return $"{Age} years";
        }

        public override string ToString() {
            return Name;
        }

    }
}
