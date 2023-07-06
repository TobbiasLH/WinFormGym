namespace WinFormGym
{
    partial class AddMealsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.tbProducerCredits = new System.Windows.Forms.TextBox();
            this.tbWritersCredits = new System.Windows.Forms.TextBox();
            this.tbSongGenre = new System.Windows.Forms.TextBox();
            this.tbSongName = new System.Windows.Forms.TextBox();
            this.lbCarboHydrates = new System.Windows.Forms.Label();
            this.lbProtein = new System.Windows.Forms.Label();
            this.lbCalories = new System.Windows.Forms.Label();
            this.lbMealName = new System.Windows.Forms.Label();
            this.lbFat = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbFiber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbProducerCredits
            // 
            this.tbProducerCredits.Location = new System.Drawing.Point(112, 149);
            this.tbProducerCredits.Name = "tbProducerCredits";
            this.tbProducerCredits.Size = new System.Drawing.Size(201, 20);
            this.tbProducerCredits.TabIndex = 16;
            // 
            // tbWritersCredits
            // 
            this.tbWritersCredits.Location = new System.Drawing.Point(112, 119);
            this.tbWritersCredits.Name = "tbWritersCredits";
            this.tbWritersCredits.Size = new System.Drawing.Size(201, 20);
            this.tbWritersCredits.TabIndex = 15;
            // 
            // tbSongGenre
            // 
            this.tbSongGenre.Location = new System.Drawing.Point(112, 86);
            this.tbSongGenre.Name = "tbSongGenre";
            this.tbSongGenre.Size = new System.Drawing.Size(201, 20);
            this.tbSongGenre.TabIndex = 14;
            // 
            // tbSongName
            // 
            this.tbSongName.Location = new System.Drawing.Point(112, 53);
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.Size = new System.Drawing.Size(201, 20);
            this.tbSongName.TabIndex = 13;
            // 
            // lbCarboHydrates
            // 
            this.lbCarboHydrates.AutoSize = true;
            this.lbCarboHydrates.Location = new System.Drawing.Point(19, 152);
            this.lbCarboHydrates.Name = "lbCarboHydrates";
            this.lbCarboHydrates.Size = new System.Drawing.Size(80, 13);
            this.lbCarboHydrates.TabIndex = 12;
            this.lbCarboHydrates.Text = "CarboHydrates:";
            // 
            // lbProtein
            // 
            this.lbProtein.AutoSize = true;
            this.lbProtein.Location = new System.Drawing.Point(56, 119);
            this.lbProtein.Name = "lbProtein";
            this.lbProtein.Size = new System.Drawing.Size(43, 13);
            this.lbProtein.TabIndex = 11;
            this.lbProtein.Text = "Protein:";
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.Location = new System.Drawing.Point(52, 89);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(47, 13);
            this.lbCalories.TabIndex = 10;
            this.lbCalories.Text = "Calories:";
            // 
            // lbMealName
            // 
            this.lbMealName.AutoSize = true;
            this.lbMealName.Location = new System.Drawing.Point(38, 53);
            this.lbMealName.Name = "lbMealName";
            this.lbMealName.Size = new System.Drawing.Size(61, 13);
            this.lbMealName.TabIndex = 9;
            this.lbMealName.Text = "MealName:";
            // 
            // lbFat
            // 
            this.lbFat.AutoSize = true;
            this.lbFat.Location = new System.Drawing.Point(74, 181);
            this.lbFat.Name = "lbFat";
            this.lbFat.Size = new System.Drawing.Size(25, 13);
            this.lbFat.TabIndex = 18;
            this.lbFat.Text = "Fat:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 20;
            // 
            // lbFiber
            // 
            this.lbFiber.AutoSize = true;
            this.lbFiber.Location = new System.Drawing.Point(64, 208);
            this.lbFiber.Name = "lbFiber";
            this.lbFiber.Size = new System.Drawing.Size(33, 13);
            this.lbFiber.TabIndex = 21;
            this.lbFiber.Text = "Fiber:";
            // 
            // AddMealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 317);
            this.Controls.Add(this.lbFiber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbProducerCredits);
            this.Controls.Add(this.tbWritersCredits);
            this.Controls.Add(this.tbSongGenre);
            this.Controls.Add(this.tbSongName);
            this.Controls.Add(this.lbCarboHydrates);
            this.Controls.Add(this.lbProtein);
            this.Controls.Add(this.lbCalories);
            this.Controls.Add(this.lbMealName);
            this.Name = "AddMealsForm";
            this.Text = "AddMealsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbProducerCredits;
        private System.Windows.Forms.TextBox tbWritersCredits;
        private System.Windows.Forms.TextBox tbSongGenre;
        private System.Windows.Forms.TextBox tbSongName;
        private System.Windows.Forms.Label lbCarboHydrates;
        private System.Windows.Forms.Label lbProtein;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Label lbMealName;
        private System.Windows.Forms.Label lbFat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbFiber;
    }
}