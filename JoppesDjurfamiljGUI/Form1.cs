using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoppesDjurfamiljGUI {
    public partial class Form1: Form {
        Petowner petowner = new Petowner();

        public Form1() {
            InitializeComponent();

            comboBoxPets.DisplayMember = "Name";
            comboBoxPets.DataSource = petowner.pets;
            
            comboBoxBalls.DisplayMember = "Color" + "Texture";
            comboBoxBalls.DataSource = petowner.balls;

            
            comboBoxFoods.DisplayMember = "food"; //BUG: Not working, can't figure out why. Yet.
            comboBoxFoods.DataSource = petowner.foods;
            
        }

        private void buttonListPets_Click(object sender, EventArgs e) {
            richTextBoxRead.Clear();
            foreach(Animal pet in petowner.pets) {
                richTextBoxRead.AppendText($"{pet.Name} is {pet.AgeString()} old and is a {pet.Breed}.");
                richTextBoxRead.AppendText(Environment.NewLine);
            }
        }

        private void buttonListFoods_Click(object sender, EventArgs e) {
            richTextBoxRead.Clear();
            // Load text to write
            foreach(string food in petowner.foods) {
                StringBuilder petsFavFood = new StringBuilder();
                foreach(Animal pet in petowner.pets) {
                    if(food == pet.favFood) {
                        petsFavFood.Append(pet.Name);
                        petsFavFood.Append(", ");
                    }
                }
                petsFavFood.Remove(petsFavFood.Length - 2, 2);
                richTextBoxRead.AppendText($"{petsFavFood} loves {food}");
                richTextBoxRead.AppendText(Environment.NewLine);
            }

        }

        private void buttonListBalls_Click(object sender, EventArgs e) {
            richTextBoxRead.Clear();
            foreach(Ball ball in petowner.balls) {
                richTextBoxRead.AppendText($"{ball.Color}, {ball.Texture} ball with Ø{ball.Size}cm. Quality: {ball.QualityString()}");
                richTextBoxRead.AppendText(Environment.NewLine);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e) {
            richTextBoxRead.Clear();
            richTextBoxRead.AppendText("This is about Joppe and his family of pets.");
            richTextBoxRead.AppendText(Environment.NewLine);
            richTextBoxRead.AppendText("To interact with the pets Joppe can play with them or feed them. There are several dishes to choose from and also several kinds of balls.");
            richTextBoxRead.AppendText(Environment.NewLine);
            richTextBoxRead.AppendText("Of course, the animals will react different depending on what is offered. ");
            richTextBoxRead.AppendText(Environment.NewLine);
        }
        
        private void buttonFeedPet_Click(object sender, EventArgs e) {
            comboBoxFoods.Visible = true;
            comboBoxPets.Visible = true;
            comboBoxBalls.Visible = false;
        }

        private void buttonPlayFetch_Click(object sender, EventArgs e) {
            comboBoxPets.Visible = true;
            comboBoxBalls.Visible = true;
            comboBoxFoods.Visible = false;
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            int petIndex = comboBoxPets.SelectedIndex;
            int foodIndex = comboBoxFoods.SelectedIndex;
            int ballIndex = comboBoxBalls.SelectedIndex;
            
            richTextBoxRead.Clear();

            if(comboBoxBalls.Visible) {
                richTextBoxRead.AppendText($"Joppe wants to play with {petowner.pets[petIndex].Name} using a {petowner.balls[ballIndex].Color} {petowner.balls[ballIndex].Texture} ball.");
                string interact = petowner.pets[petIndex].Interact(petowner.balls[ballIndex]);
                richTextBoxRead.AppendText(interact);
            }
            else if(comboBoxFoods.Visible) {
                richTextBoxRead.Text = $"Joppe is going to feed {petowner.foods[foodIndex]} to {petowner.pets[petIndex].Name}";
                string feed = petowner.pets[petIndex].Eat(petowner.foods[foodIndex]);
                richTextBoxRead.AppendText(feed);

            }

            comboBoxPets.Visible = false;
            comboBoxFoods.Visible = false;
            comboBoxBalls.Visible = false;
        }
        
    }
}
