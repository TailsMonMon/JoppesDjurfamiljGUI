namespace JoppesDjurfamiljGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonListPets = new System.Windows.Forms.Button();
            this.buttonPlayFetch = new System.Windows.Forms.Button();
            this.buttonFeedPet = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxRead = new System.Windows.Forms.RichTextBox();
            this.buttonListFoods = new System.Windows.Forms.Button();
            this.buttonListBalls = new System.Windows.Forms.Button();
            this.comboBoxPets = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.comboBoxBalls = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListPets
            // 
            this.buttonListPets.Location = new System.Drawing.Point(12, 110);
            this.buttonListPets.Name = "buttonListPets";
            this.buttonListPets.Size = new System.Drawing.Size(75, 23);
            this.buttonListPets.TabIndex = 1;
            this.buttonListPets.Text = "List Pets";
            this.buttonListPets.UseVisualStyleBackColor = true;
            this.buttonListPets.Click += new System.EventHandler(this.buttonListPets_Click);
            // 
            // buttonPlayFetch
            // 
            this.buttonPlayFetch.Location = new System.Drawing.Point(12, 52);
            this.buttonPlayFetch.Name = "buttonPlayFetch";
            this.buttonPlayFetch.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayFetch.TabIndex = 2;
            this.buttonPlayFetch.Text = "Play Fetch";
            this.buttonPlayFetch.UseVisualStyleBackColor = true;
            this.buttonPlayFetch.Click += new System.EventHandler(this.buttonPlayFetch_Click);
            // 
            // buttonFeedPet
            // 
            this.buttonFeedPet.Location = new System.Drawing.Point(12, 81);
            this.buttonFeedPet.Name = "buttonFeedPet";
            this.buttonFeedPet.Size = new System.Drawing.Size(75, 23);
            this.buttonFeedPet.TabIndex = 3;
            this.buttonFeedPet.Text = "Feed a Pet";
            this.buttonFeedPet.UseVisualStyleBackColor = true;
            this.buttonFeedPet.Click += new System.EventHandler(this.buttonFeedPet_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(12, 214);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 34);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About this program";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Joppes family of Pets";
            // 
            // richTextBoxRead
            // 
            this.richTextBoxRead.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxRead.Enabled = false;
            this.richTextBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRead.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxRead.Location = new System.Drawing.Point(93, 92);
            this.richTextBoxRead.Name = "richTextBoxRead";
            this.richTextBoxRead.ReadOnly = true;
            this.richTextBoxRead.Size = new System.Drawing.Size(357, 156);
            this.richTextBoxRead.TabIndex = 10;
            this.richTextBoxRead.Text = "";
            // 
            // buttonListFoods
            // 
            this.buttonListFoods.Location = new System.Drawing.Point(12, 139);
            this.buttonListFoods.Name = "buttonListFoods";
            this.buttonListFoods.Size = new System.Drawing.Size(75, 23);
            this.buttonListFoods.TabIndex = 11;
            this.buttonListFoods.Text = "List Foods";
            this.buttonListFoods.UseVisualStyleBackColor = true;
            this.buttonListFoods.Click += new System.EventHandler(this.buttonListFoods_Click);
            // 
            // buttonListBalls
            // 
            this.buttonListBalls.Location = new System.Drawing.Point(12, 168);
            this.buttonListBalls.Name = "buttonListBalls";
            this.buttonListBalls.Size = new System.Drawing.Size(75, 23);
            this.buttonListBalls.TabIndex = 12;
            this.buttonListBalls.Text = "List Balls";
            this.buttonListBalls.UseVisualStyleBackColor = true;
            this.buttonListBalls.Click += new System.EventHandler(this.buttonListBalls_Click);
            // 
            // comboBoxPets
            // 
            this.comboBoxPets.FormattingEnabled = true;
            this.comboBoxPets.Location = new System.Drawing.Point(3, 3);
            this.comboBoxPets.Name = "comboBoxPets";
            this.comboBoxPets.Size = new System.Drawing.Size(155, 21);
            this.comboBoxPets.TabIndex = 16;
            this.comboBoxPets.Text = "Choose a pet";
            this.comboBoxPets.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPets);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxBalls);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxFoods);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 34);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(3, 30);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(178, 21);
            this.comboBoxFoods.TabIndex = 17;
            this.comboBoxFoods.Text = "Choose a food";
            this.comboBoxFoods.Visible = false;
            // 
            // comboBoxBalls
            // 
            this.comboBoxBalls.FormattingEnabled = true;
            this.comboBoxBalls.Location = new System.Drawing.Point(164, 3);
            this.comboBoxBalls.Name = "comboBoxBalls";
            this.comboBoxBalls.Size = new System.Drawing.Size(144, 21);
            this.comboBoxBalls.TabIndex = 18;
            this.comboBoxBalls.Text = "Choose a ball";
            this.comboBoxBalls.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(419, 52);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(34, 34);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 400);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonListBalls);
            this.Controls.Add(this.buttonListFoods);
            this.Controls.Add(this.richTextBoxRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonFeedPet);
            this.Controls.Add(this.buttonPlayFetch);
            this.Controls.Add(this.buttonListPets);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Joppes family of Pets";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonListPets;
        private System.Windows.Forms.Button buttonPlayFetch;
        private System.Windows.Forms.Button buttonFeedPet;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxRead;
        private System.Windows.Forms.Button buttonListFoods;
        private System.Windows.Forms.Button buttonListBalls;
        private System.Windows.Forms.ComboBox comboBoxPets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxBalls;
        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.Button buttonOk;
    }
}

