
namespace VacationPlanner
{
    partial class Form1
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
            this.departureCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bostonLoganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_calcCost = new System.Windows.Forms.Button();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suite_btn = new System.Windows.Forms.RadioButton();
            this.prsuite_btn = new System.Windows.Forms.RadioButton();
            this.double_btn = new System.Windows.Forms.RadioButton();
            this.single_btn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ld_btn = new System.Windows.Forms.RadioButton();
            this.full_btn = new System.Windows.Forms.RadioButton();
            this.dinn_btn = new System.Windows.Forms.RadioButton();
            this.noMeal_btn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departureCityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departureCityToolStripMenuItem
            // 
            this.departureCityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jFKToolStripMenuItem,
            this.bostonLoganToolStripMenuItem,
            this.lAXToolStripMenuItem});
            this.departureCityToolStripMenuItem.Name = "departureCityToolStripMenuItem";
            this.departureCityToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departureCityToolStripMenuItem.Text = "Departure City";
            this.departureCityToolStripMenuItem.Click += new System.EventHandler(this.departureCityToolStripMenuItem_Click);
            // 
            // jFKToolStripMenuItem
            // 
            this.jFKToolStripMenuItem.Name = "jFKToolStripMenuItem";
            this.jFKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jFKToolStripMenuItem.Text = "JFK";
            this.jFKToolStripMenuItem.Click += new System.EventHandler(this.jFKToolStripMenuItem_Click);
            // 
            // bostonLoganToolStripMenuItem
            // 
            this.bostonLoganToolStripMenuItem.Name = "bostonLoganToolStripMenuItem";
            this.bostonLoganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bostonLoganToolStripMenuItem.Text = "Boston Logan";
            this.bostonLoganToolStripMenuItem.Click += new System.EventHandler(this.bostonLoganToolStripMenuItem_Click);
            // 
            // lAXToolStripMenuItem
            // 
            this.lAXToolStripMenuItem.Name = "lAXToolStripMenuItem";
            this.lAXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lAXToolStripMenuItem.Text = "LAX";
            this.lAXToolStripMenuItem.Click += new System.EventHandler(this.lAXToolStripMenuItem_Click);
            // 
            // btn_calcCost
            // 
            this.btn_calcCost.Location = new System.Drawing.Point(352, 327);
            this.btn_calcCost.Name = "btn_calcCost";
            this.btn_calcCost.Size = new System.Drawing.Size(75, 23);
            this.btn_calcCost.TabIndex = 5;
            this.btn_calcCost.Text = "Generate Cost";
            this.btn_calcCost.UseVisualStyleBackColor = true;
            this.btn_calcCost.Click += new System.EventHandler(this.btn_calcCost_Click);
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(355, 372);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(34, 13);
            this.lbl_cost.TabIndex = 6;
            this.lbl_cost.Text = "Cost: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.suite_btn);
            this.groupBox1.Controls.Add(this.prsuite_btn);
            this.groupBox1.Controls.Add(this.double_btn);
            this.groupBox1.Controls.Add(this.single_btn);
            this.groupBox1.Location = new System.Drawing.Point(352, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Selection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // suite_btn
            // 
            this.suite_btn.AutoSize = true;
            this.suite_btn.Location = new System.Drawing.Point(6, 42);
            this.suite_btn.Name = "suite_btn";
            this.suite_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.suite_btn.Size = new System.Drawing.Size(54, 17);
            this.suite_btn.TabIndex = 3;
            this.suite_btn.TabStop = true;
            this.suite_btn.Text = "Suite";
            this.suite_btn.UseVisualStyleBackColor = true;
            this.suite_btn.CheckedChanged += new System.EventHandler(this.suite_btn_CheckedChanged);
            // 
            // prsuite_btn
            // 
            this.prsuite_btn.AutoSize = true;
            this.prsuite_btn.Location = new System.Drawing.Point(81, 42);
            this.prsuite_btn.Name = "prsuite_btn";
            this.prsuite_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.prsuite_btn.Size = new System.Drawing.Size(111, 17);
            this.prsuite_btn.TabIndex = 2;
            this.prsuite_btn.TabStop = true;
            this.prsuite_btn.Text = "Presidential Suite";
            this.prsuite_btn.UseVisualStyleBackColor = true;
            this.prsuite_btn.CheckedChanged += new System.EventHandler(this.prsuite_btn_CheckedChanged);
            // 
            // double_btn
            // 
            this.double_btn.AutoSize = true;
            this.double_btn.Location = new System.Drawing.Point(97, 19);
            this.double_btn.Name = "double_btn";
            this.double_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.double_btn.Size = new System.Drawing.Size(95, 17);
            this.double_btn.TabIndex = 1;
            this.double_btn.TabStop = true;
            this.double_btn.Text = "Double Room";
            this.double_btn.UseVisualStyleBackColor = true;
            this.double_btn.CheckedChanged += new System.EventHandler(this.double_btn_CheckedChanged);
            // 
            // single_btn
            // 
            this.single_btn.AutoSize = true;
            this.single_btn.Location = new System.Drawing.Point(6, 19);
            this.single_btn.Name = "single_btn";
            this.single_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.single_btn.Size = new System.Drawing.Size(90, 17);
            this.single_btn.TabIndex = 0;
            this.single_btn.TabStop = true;
            this.single_btn.Text = "Single Room";
            this.single_btn.UseVisualStyleBackColor = true;
            this.single_btn.CheckedChanged += new System.EventHandler(this.single_btn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ld_btn);
            this.groupBox2.Controls.Add(this.full_btn);
            this.groupBox2.Controls.Add(this.dinn_btn);
            this.groupBox2.Controls.Add(this.noMeal_btn);
            this.groupBox2.Location = new System.Drawing.Point(352, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal Choice";
            // 
            // ld_btn
            // 
            this.ld_btn.AutoSize = true;
            this.ld_btn.Location = new System.Drawing.Point(68, 19);
            this.ld_btn.Name = "ld_btn";
            this.ld_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ld_btn.Size = new System.Drawing.Size(115, 17);
            this.ld_btn.TabIndex = 3;
            this.ld_btn.TabStop = true;
            this.ld_btn.Text = "Lunch and Dinner";
            this.ld_btn.UseVisualStyleBackColor = true;
            this.ld_btn.CheckedChanged += new System.EventHandler(this.ld_btn_CheckedChanged);
            // 
            // full_btn
            // 
            this.full_btn.AutoSize = true;
            this.full_btn.Location = new System.Drawing.Point(6, 42);
            this.full_btn.Name = "full_btn";
            this.full_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.full_btn.Size = new System.Drawing.Size(84, 17);
            this.full_btn.TabIndex = 2;
            this.full_btn.TabStop = true;
            this.full_btn.Text = "Full Access";
            this.full_btn.UseVisualStyleBackColor = true;
            this.full_btn.CheckedChanged += new System.EventHandler(this.full_btn_CheckedChanged);
            // 
            // dinn_btn
            // 
            this.dinn_btn.AutoSize = true;
            this.dinn_btn.Location = new System.Drawing.Point(6, 19);
            this.dinn_btn.Name = "dinn_btn";
            this.dinn_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dinn_btn.Size = new System.Drawing.Size(61, 17);
            this.dinn_btn.TabIndex = 1;
            this.dinn_btn.TabStop = true;
            this.dinn_btn.Text = "Dinner";
            this.dinn_btn.UseVisualStyleBackColor = true;
            this.dinn_btn.CheckedChanged += new System.EventHandler(this.dinn_btn_CheckedChanged);
            // 
            // noMeal_btn
            // 
            this.noMeal_btn.AutoSize = true;
            this.noMeal_btn.Location = new System.Drawing.Point(91, 42);
            this.noMeal_btn.Name = "noMeal_btn";
            this.noMeal_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.noMeal_btn.Size = new System.Drawing.Size(75, 17);
            this.noMeal_btn.TabIndex = 0;
            this.noMeal_btn.TabStop = true;
            this.noMeal_btn.Text = "No Meals";
            this.noMeal_btn.UseVisualStyleBackColor = true;
            this.noMeal_btn.CheckedChanged += new System.EventHandler(this.noMeal_btn_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VacationPlanner.Properties.Resources.Tropical_beach;
            this.pictureBox2.Location = new System.Drawing.Point(47, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.btn_calcCost);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vacation Planner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departureCityToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_calcCost;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton suite_btn;
        private System.Windows.Forms.RadioButton prsuite_btn;
        private System.Windows.Forms.RadioButton double_btn;
        private System.Windows.Forms.RadioButton single_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ld_btn;
        private System.Windows.Forms.RadioButton full_btn;
        private System.Windows.Forms.RadioButton dinn_btn;
        private System.Windows.Forms.RadioButton noMeal_btn;
        private System.Windows.Forms.ToolStripMenuItem jFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bostonLoganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAXToolStripMenuItem;
    }
}

