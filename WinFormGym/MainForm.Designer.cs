namespace WinFormGym
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excersiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.lbMeals = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgwGym = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbFiber = new System.Windows.Forms.TextBox();
            this.tbFat = new System.Windows.Forms.TextBox();
            this.tbCarboHydrates = new System.Windows.Forms.TextBox();
            this.tbProtein = new System.Windows.Forms.TextBox();
            this.tbCalories = new System.Windows.Forms.TextBox();
            this.tbMealName = new System.Windows.Forms.TextBox();
            this.lbFiber = new System.Windows.Forms.Label();
            this.lbFat = new System.Windows.Forms.Label();
            this.lbCarboHydrates = new System.Windows.Forms.Label();
            this.lbProtein = new System.Windows.Forms.Label();
            this.lbCalories = new System.Windows.Forms.Label();
            this.lbMealName = new System.Windows.Forms.Label();
            this.addMealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGym)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mealsToolStripMenuItem,
            this.excersiToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mealsToolStripMenuItem
            // 
            this.mealsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMealsToolStripMenuItem,
            this.deleteMealsToolStripMenuItem});
            this.mealsToolStripMenuItem.Name = "mealsToolStripMenuItem";
            this.mealsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mealsToolStripMenuItem.Text = "Meals";
            // 
            // excersiToolStripMenuItem
            // 
            this.excersiToolStripMenuItem.Name = "excersiToolStripMenuItem";
            this.excersiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.excersiToolStripMenuItem.Text = "Exercises";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSearchText);
            this.panel1.Controls.Add(this.lbMeals);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 1;
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(157, 26);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(270, 20);
            this.tbSearchText.TabIndex = 2;
            // 
            // lbMeals
            // 
            this.lbMeals.AutoSize = true;
            this.lbMeals.Location = new System.Drawing.Point(113, 29);
            this.lbMeals.Name = "lbMeals";
            this.lbMeals.Size = new System.Drawing.Size(38, 13);
            this.lbMeals.TabIndex = 1;
            this.lbMeals.Text = "Meals:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(433, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgwGym
            // 
            this.dgwGym.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGym.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwGym.Location = new System.Drawing.Point(0, 321);
            this.dgwGym.Name = "dgwGym";
            this.dgwGym.Size = new System.Drawing.Size(800, 129);
            this.dgwGym.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.tbFiber);
            this.panel2.Controls.Add(this.tbFat);
            this.panel2.Controls.Add(this.tbCarboHydrates);
            this.panel2.Controls.Add(this.tbProtein);
            this.panel2.Controls.Add(this.tbCalories);
            this.panel2.Controls.Add(this.tbMealName);
            this.panel2.Controls.Add(this.lbFiber);
            this.panel2.Controls.Add(this.lbFat);
            this.panel2.Controls.Add(this.lbCarboHydrates);
            this.panel2.Controls.Add(this.lbProtein);
            this.panel2.Controls.Add(this.lbCalories);
            this.panel2.Controls.Add(this.lbMealName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 231);
            this.panel2.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbFiber
            // 
            this.tbFiber.Location = new System.Drawing.Point(158, 192);
            this.tbFiber.Name = "tbFiber";
            this.tbFiber.Size = new System.Drawing.Size(154, 20);
            this.tbFiber.TabIndex = 11;
            // 
            // tbFat
            // 
            this.tbFat.Location = new System.Drawing.Point(158, 158);
            this.tbFat.Name = "tbFat";
            this.tbFat.Size = new System.Drawing.Size(153, 20);
            this.tbFat.TabIndex = 10;
            // 
            // tbCarboHydrates
            // 
            this.tbCarboHydrates.Location = new System.Drawing.Point(158, 129);
            this.tbCarboHydrates.Name = "tbCarboHydrates";
            this.tbCarboHydrates.Size = new System.Drawing.Size(153, 20);
            this.tbCarboHydrates.TabIndex = 9;
            // 
            // tbProtein
            // 
            this.tbProtein.Location = new System.Drawing.Point(158, 98);
            this.tbProtein.Name = "tbProtein";
            this.tbProtein.Size = new System.Drawing.Size(154, 20);
            this.tbProtein.TabIndex = 8;
            // 
            // tbCalories
            // 
            this.tbCalories.Location = new System.Drawing.Point(158, 67);
            this.tbCalories.Name = "tbCalories";
            this.tbCalories.Size = new System.Drawing.Size(154, 20);
            this.tbCalories.TabIndex = 7;
            // 
            // tbMealName
            // 
            this.tbMealName.Location = new System.Drawing.Point(158, 35);
            this.tbMealName.Name = "tbMealName";
            this.tbMealName.Size = new System.Drawing.Size(154, 20);
            this.tbMealName.TabIndex = 6;
            // 
            // lbFiber
            // 
            this.lbFiber.AutoSize = true;
            this.lbFiber.Location = new System.Drawing.Point(119, 195);
            this.lbFiber.Name = "lbFiber";
            this.lbFiber.Size = new System.Drawing.Size(33, 13);
            this.lbFiber.TabIndex = 5;
            this.lbFiber.Text = "Fiber:";
            // 
            // lbFat
            // 
            this.lbFat.AutoSize = true;
            this.lbFat.Location = new System.Drawing.Point(127, 161);
            this.lbFat.Name = "lbFat";
            this.lbFat.Size = new System.Drawing.Size(25, 13);
            this.lbFat.TabIndex = 4;
            this.lbFat.Text = "Fat:";
            // 
            // lbCarboHydrates
            // 
            this.lbCarboHydrates.AutoSize = true;
            this.lbCarboHydrates.Location = new System.Drawing.Point(72, 132);
            this.lbCarboHydrates.Name = "lbCarboHydrates";
            this.lbCarboHydrates.Size = new System.Drawing.Size(80, 13);
            this.lbCarboHydrates.TabIndex = 3;
            this.lbCarboHydrates.Text = "CarboHydrates:";
            // 
            // lbProtein
            // 
            this.lbProtein.AutoSize = true;
            this.lbProtein.Location = new System.Drawing.Point(109, 101);
            this.lbProtein.Name = "lbProtein";
            this.lbProtein.Size = new System.Drawing.Size(43, 13);
            this.lbProtein.TabIndex = 2;
            this.lbProtein.Text = "Protein:";
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.Location = new System.Drawing.Point(105, 70);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(47, 13);
            this.lbCalories.TabIndex = 1;
            this.lbCalories.Text = "Calories:";
            // 
            // lbMealName
            // 
            this.lbMealName.AutoSize = true;
            this.lbMealName.Location = new System.Drawing.Point(91, 38);
            this.lbMealName.Name = "lbMealName";
            this.lbMealName.Size = new System.Drawing.Size(61, 13);
            this.lbMealName.TabIndex = 0;
            this.lbMealName.Text = "MealName:";
            // 
            // addMealsToolStripMenuItem
            // 
            this.addMealsToolStripMenuItem.Name = "addMealsToolStripMenuItem";
            this.addMealsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addMealsToolStripMenuItem.Text = "Add Meals";
            // 
            // deleteMealsToolStripMenuItem
            // 
            this.deleteMealsToolStripMenuItem.Name = "deleteMealsToolStripMenuItem";
            this.deleteMealsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMealsToolStripMenuItem.Text = "Delete Meals";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwGym);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gym";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGym)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excersiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwGym;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbFiber;
        private System.Windows.Forms.Label lbFat;
        private System.Windows.Forms.Label lbCarboHydrates;
        private System.Windows.Forms.Label lbProtein;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Label lbMealName;
        private System.Windows.Forms.TextBox tbFiber;
        private System.Windows.Forms.TextBox tbFat;
        private System.Windows.Forms.TextBox tbCarboHydrates;
        private System.Windows.Forms.TextBox tbProtein;
        private System.Windows.Forms.TextBox tbCalories;
        private System.Windows.Forms.TextBox tbMealName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbMeals;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.ToolStripMenuItem addMealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMealsToolStripMenuItem;
    }
}

