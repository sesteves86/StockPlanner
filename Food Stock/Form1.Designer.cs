namespace Food_Stock
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
            this.tabIngredients = new System.Windows.Forms.TabControl();
            this.tabIngredients1 = new System.Windows.Forms.TabPage();
            this.txtIngredientsUnits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIngredientsActualQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttUpdateIngredient = new System.Windows.Forms.Button();
            this.bttDeleteIngredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.bttAddIngredient = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.tabRecipes = new System.Windows.Forms.TabPage();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCookingTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeopleServed = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtQty5 = new System.Windows.Forms.TextBox();
            this.txtQty4 = new System.Windows.Forms.TextBox();
            this.txtQty3 = new System.Windows.Forms.TextBox();
            this.txtQty2 = new System.Windows.Forms.TextBox();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttAddNewRecipe = new System.Windows.Forms.Button();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.bttDeletePlan = new System.Windows.Forms.Button();
            this.bttUpdatePlan = new System.Windows.Forms.Button();
            this.bttCreatePlan = new System.Windows.Forms.Button();
            this.dTPickerPlan = new System.Windows.Forms.DateTimePicker();
            this.cBoxRecipesPlan = new System.Windows.Forms.ComboBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.bttUpdateStock = new System.Windows.Forms.Button();
            this.tabIngredients.SuspendLayout();
            this.tabIngredients1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.tabRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.tabPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIngredients
            // 
            this.tabIngredients.Controls.Add(this.tabIngredients1);
            this.tabIngredients.Controls.Add(this.tabRecipes);
            this.tabIngredients.Controls.Add(this.tabPlan);
            this.tabIngredients.Location = new System.Drawing.Point(-1, 2);
            this.tabIngredients.Name = "tabIngredients";
            this.tabIngredients.SelectedIndex = 0;
            this.tabIngredients.Size = new System.Drawing.Size(540, 368);
            this.tabIngredients.TabIndex = 0;
            // 
            // tabIngredients1
            // 
            this.tabIngredients1.Controls.Add(this.txtIngredientsUnits);
            this.tabIngredients1.Controls.Add(this.label5);
            this.tabIngredients1.Controls.Add(this.txtIngredientsActualQuantity);
            this.tabIngredients1.Controls.Add(this.label4);
            this.tabIngredients1.Controls.Add(this.label3);
            this.tabIngredients1.Controls.Add(this.bttUpdateIngredient);
            this.tabIngredients1.Controls.Add(this.bttDeleteIngredient);
            this.tabIngredients1.Controls.Add(this.txtIngredient);
            this.tabIngredients1.Controls.Add(this.bttAddIngredient);
            this.tabIngredients1.Controls.Add(this.dgvIngredients);
            this.tabIngredients1.Location = new System.Drawing.Point(4, 22);
            this.tabIngredients1.Name = "tabIngredients1";
            this.tabIngredients1.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngredients1.Size = new System.Drawing.Size(532, 342);
            this.tabIngredients1.TabIndex = 3;
            this.tabIngredients1.Text = "Ingredients";
            this.tabIngredients1.UseVisualStyleBackColor = true;
            // 
            // txtIngredientsUnits
            // 
            this.txtIngredientsUnits.Location = new System.Drawing.Point(393, 136);
            this.txtIngredientsUnits.MaxLength = 5;
            this.txtIngredientsUnits.Name = "txtIngredientsUnits";
            this.txtIngredientsUnits.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientsUnits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Units";
            // 
            // txtIngredientsActualQuantity
            // 
            this.txtIngredientsActualQuantity.Location = new System.Drawing.Point(393, 98);
            this.txtIngredientsActualQuantity.Name = "txtIngredientsActualQuantity";
            this.txtIngredientsActualQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientsActualQuantity.TabIndex = 7;
            this.txtIngredientsActualQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Actual Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredient:";
            // 
            // bttUpdateIngredient
            // 
            this.bttUpdateIngredient.Location = new System.Drawing.Point(295, 184);
            this.bttUpdateIngredient.Name = "bttUpdateIngredient";
            this.bttUpdateIngredient.Size = new System.Drawing.Size(75, 23);
            this.bttUpdateIngredient.TabIndex = 4;
            this.bttUpdateIngredient.Text = "Update";
            this.bttUpdateIngredient.UseVisualStyleBackColor = true;
            this.bttUpdateIngredient.Click += new System.EventHandler(this.bttUpdateIngredient_Click);
            // 
            // bttDeleteIngredient
            // 
            this.bttDeleteIngredient.Location = new System.Drawing.Point(295, 238);
            this.bttDeleteIngredient.Name = "bttDeleteIngredient";
            this.bttDeleteIngredient.Size = new System.Drawing.Size(75, 23);
            this.bttDeleteIngredient.TabIndex = 3;
            this.bttDeleteIngredient.Text = "Delete";
            this.bttDeleteIngredient.UseVisualStyleBackColor = true;
            this.bttDeleteIngredient.Click += new System.EventHandler(this.bttDeleteIngredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(393, 63);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(100, 20);
            this.txtIngredient.TabIndex = 2;
            // 
            // bttAddIngredient
            // 
            this.bttAddIngredient.Location = new System.Drawing.Point(393, 184);
            this.bttAddIngredient.Name = "bttAddIngredient";
            this.bttAddIngredient.Size = new System.Drawing.Size(119, 23);
            this.bttAddIngredient.TabIndex = 1;
            this.bttAddIngredient.Text = "Add Ingredient";
            this.bttAddIngredient.UseVisualStyleBackColor = true;
            this.bttAddIngredient.Click += new System.EventHandler(this.bttAddIngredient_Click);
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AllowUserToResizeColumns = false;
            this.dgvIngredients.AllowUserToResizeRows = false;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIngredients.Location = new System.Drawing.Point(9, 6);
            this.dgvIngredients.MultiSelect = false;
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.RowHeadersVisible = false;
            this.dgvIngredients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvIngredients.Size = new System.Drawing.Size(276, 332);
            this.dgvIngredients.TabIndex = 0;
            this.dgvIngredients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientsRead);
            // 
            // tabRecipes
            // 
            this.tabRecipes.Controls.Add(this.lblUnit5);
            this.tabRecipes.Controls.Add(this.lblUnit4);
            this.tabRecipes.Controls.Add(this.lblUnit3);
            this.tabRecipes.Controls.Add(this.lblUnit2);
            this.tabRecipes.Controls.Add(this.lblUnit1);
            this.tabRecipes.Controls.Add(this.txtRecipeName);
            this.tabRecipes.Controls.Add(this.label10);
            this.tabRecipes.Controls.Add(this.label9);
            this.tabRecipes.Controls.Add(this.txtCookingTime);
            this.tabRecipes.Controls.Add(this.label8);
            this.tabRecipes.Controls.Add(this.label7);
            this.tabRecipes.Controls.Add(this.label6);
            this.tabRecipes.Controls.Add(this.txtPeopleServed);
            this.tabRecipes.Controls.Add(this.comboBox5);
            this.tabRecipes.Controls.Add(this.comboBox4);
            this.tabRecipes.Controls.Add(this.comboBox3);
            this.tabRecipes.Controls.Add(this.comboBox2);
            this.tabRecipes.Controls.Add(this.comboBox1);
            this.tabRecipes.Controls.Add(this.txtQty5);
            this.tabRecipes.Controls.Add(this.txtQty4);
            this.tabRecipes.Controls.Add(this.txtQty3);
            this.tabRecipes.Controls.Add(this.txtQty2);
            this.tabRecipes.Controls.Add(this.txtQty1);
            this.tabRecipes.Controls.Add(this.bttDelete);
            this.tabRecipes.Controls.Add(this.bttUpdate);
            this.tabRecipes.Controls.Add(this.label2);
            this.tabRecipes.Controls.Add(this.label1);
            this.tabRecipes.Controls.Add(this.bttAddNewRecipe);
            this.tabRecipes.Controls.Add(this.dgvRecipes);
            this.tabRecipes.Location = new System.Drawing.Point(4, 22);
            this.tabRecipes.Name = "tabRecipes";
            this.tabRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipes.Size = new System.Drawing.Size(532, 342);
            this.tabRecipes.TabIndex = 1;
            this.tabRecipes.Text = "Recipes";
            this.tabRecipes.UseVisualStyleBackColor = true;
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Location = new System.Drawing.Point(456, 194);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(10, 13);
            this.lblUnit5.TabIndex = 33;
            this.lblUnit5.Text = " ";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(456, 153);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(10, 13);
            this.lblUnit4.TabIndex = 32;
            this.lblUnit4.Text = " ";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(456, 115);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(10, 13);
            this.lblUnit3.TabIndex = 31;
            this.lblUnit3.Text = " ";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(456, 75);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(10, 13);
            this.lblUnit2.TabIndex = 30;
            this.lblUnit2.Text = " ";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(456, 36);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(10, 13);
            this.lblUnit1.TabIndex = 29;
            this.lblUnit1.Text = " ";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(342, 295);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(167, 20);
            this.txtRecipeName.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Recipe name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "minutes";
            // 
            // txtCookingTime
            // 
            this.txtCookingTime.Location = new System.Drawing.Point(343, 254);
            this.txtCookingTime.Name = "txtCookingTime";
            this.txtCookingTime.Size = new System.Drawing.Size(34, 20);
            this.txtCookingTime.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cooking time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "people";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Serves";
            // 
            // txtPeopleServed
            // 
            this.txtPeopleServed.Location = new System.Drawing.Point(316, 225);
            this.txtPeopleServed.Name = "txtPeopleServed";
            this.txtPeopleServed.Size = new System.Drawing.Size(32, 20);
            this.txtPeopleServed.TabIndex = 21;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(272, 191);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.cBox5Changed);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(272, 149);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.cBox4Changed);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(272, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.cBox3Changed);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(272, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.cBox2Changed);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cBox1Changed);
            // 
            // txtQty5
            // 
            this.txtQty5.Location = new System.Drawing.Point(399, 191);
            this.txtQty5.Name = "txtQty5";
            this.txtQty5.Size = new System.Drawing.Size(51, 20);
            this.txtQty5.TabIndex = 10;
            this.txtQty5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // txtQty4
            // 
            this.txtQty4.Location = new System.Drawing.Point(399, 150);
            this.txtQty4.Name = "txtQty4";
            this.txtQty4.Size = new System.Drawing.Size(51, 20);
            this.txtQty4.TabIndex = 9;
            this.txtQty4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // txtQty3
            // 
            this.txtQty3.Location = new System.Drawing.Point(399, 112);
            this.txtQty3.Name = "txtQty3";
            this.txtQty3.Size = new System.Drawing.Size(51, 20);
            this.txtQty3.TabIndex = 8;
            this.txtQty3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(399, 72);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.Size = new System.Drawing.Size(51, 20);
            this.txtQty2.TabIndex = 7;
            this.txtQty2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(399, 33);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(51, 20);
            this.txtQty1.TabIndex = 6;
            this.txtQty1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersTextBox_keyPress);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(9, 319);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(100, 319);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(75, 23);
            this.bttUpdate.TabIndex = 4;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingredients";
            // 
            // bttAddNewRecipe
            // 
            this.bttAddNewRecipe.Location = new System.Drawing.Point(183, 319);
            this.bttAddNewRecipe.Name = "bttAddNewRecipe";
            this.bttAddNewRecipe.Size = new System.Drawing.Size(127, 23);
            this.bttAddNewRecipe.TabIndex = 1;
            this.bttAddNewRecipe.Text = "Create Recipe";
            this.bttAddNewRecipe.UseVisualStyleBackColor = true;
            this.bttAddNewRecipe.Click += new System.EventHandler(this.bttAddNewRecipe_Click);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.AllowUserToResizeColumns = false;
            this.dgvRecipes.AllowUserToResizeRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(9, 6);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.RowHeadersVisible = false;
            this.dgvRecipes.Size = new System.Drawing.Size(220, 305);
            this.dgvRecipes.TabIndex = 0;
            this.dgvRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellClick);
            // 
            // tabPlan
            // 
            this.tabPlan.Controls.Add(this.bttDeletePlan);
            this.tabPlan.Controls.Add(this.bttUpdatePlan);
            this.tabPlan.Controls.Add(this.bttCreatePlan);
            this.tabPlan.Controls.Add(this.dTPickerPlan);
            this.tabPlan.Controls.Add(this.cBoxRecipesPlan);
            this.tabPlan.Controls.Add(this.dgvPlan);
            this.tabPlan.Location = new System.Drawing.Point(4, 22);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlan.Size = new System.Drawing.Size(532, 342);
            this.tabPlan.TabIndex = 2;
            this.tabPlan.Text = "Plan";
            this.tabPlan.UseVisualStyleBackColor = true;
            // 
            // bttDeletePlan
            // 
            this.bttDeletePlan.Location = new System.Drawing.Point(260, 123);
            this.bttDeletePlan.Name = "bttDeletePlan";
            this.bttDeletePlan.Size = new System.Drawing.Size(75, 23);
            this.bttDeletePlan.TabIndex = 5;
            this.bttDeletePlan.Text = "Delete";
            this.bttDeletePlan.UseVisualStyleBackColor = true;
            this.bttDeletePlan.Click += new System.EventHandler(this.bttDeletePlan_Click);
            // 
            // bttUpdatePlan
            // 
            this.bttUpdatePlan.Location = new System.Drawing.Point(340, 93);
            this.bttUpdatePlan.Name = "bttUpdatePlan";
            this.bttUpdatePlan.Size = new System.Drawing.Size(75, 23);
            this.bttUpdatePlan.TabIndex = 4;
            this.bttUpdatePlan.Text = "Update";
            this.bttUpdatePlan.UseVisualStyleBackColor = true;
            this.bttUpdatePlan.Click += new System.EventHandler(this.bttUpdatePlan_Click);
            // 
            // bttCreatePlan
            // 
            this.bttCreatePlan.Location = new System.Drawing.Point(259, 93);
            this.bttCreatePlan.Name = "bttCreatePlan";
            this.bttCreatePlan.Size = new System.Drawing.Size(75, 23);
            this.bttCreatePlan.TabIndex = 3;
            this.bttCreatePlan.Text = "Create";
            this.bttCreatePlan.UseVisualStyleBackColor = true;
            this.bttCreatePlan.Click += new System.EventHandler(this.bttCreatePlan_Click);
            // 
            // dTPickerPlan
            // 
            this.dTPickerPlan.Location = new System.Drawing.Point(259, 54);
            this.dTPickerPlan.Name = "dTPickerPlan";
            this.dTPickerPlan.Size = new System.Drawing.Size(200, 20);
            this.dTPickerPlan.TabIndex = 2;
            // 
            // cBoxRecipesPlan
            // 
            this.cBoxRecipesPlan.FormattingEnabled = true;
            this.cBoxRecipesPlan.Location = new System.Drawing.Point(259, 17);
            this.cBoxRecipesPlan.Name = "cBoxRecipesPlan";
            this.cBoxRecipesPlan.Size = new System.Drawing.Size(121, 21);
            this.cBoxRecipesPlan.TabIndex = 1;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeColumns = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(9, 6);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowHeadersVisible = false;
            this.dgvPlan.Size = new System.Drawing.Size(244, 348);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // bttUpdateStock
            // 
            this.bttUpdateStock.Location = new System.Drawing.Point(12, 372);
            this.bttUpdateStock.Name = "bttUpdateStock";
            this.bttUpdateStock.Size = new System.Drawing.Size(122, 23);
            this.bttUpdateStock.TabIndex = 1;
            this.bttUpdateStock.Text = "Update Stock";
            this.bttUpdateStock.UseVisualStyleBackColor = true;
            this.bttUpdateStock.Click += new System.EventHandler(this.bttUpdateStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 400);
            this.Controls.Add(this.bttUpdateStock);
            this.Controls.Add(this.tabIngredients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabIngredients.ResumeLayout(false);
            this.tabIngredients1.ResumeLayout(false);
            this.tabIngredients1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.tabRecipes.ResumeLayout(false);
            this.tabRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.tabPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngredients;
        private System.Windows.Forms.TabPage tabRecipes;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtQty5;
        private System.Windows.Forms.TextBox txtQty4;
        private System.Windows.Forms.TextBox txtQty3;
        private System.Windows.Forms.TextBox txtQty2;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAddNewRecipe;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.TabPage tabPlan;
        private System.Windows.Forms.TabPage tabIngredients1;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Button bttDeleteIngredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button bttAddIngredient;
        private System.Windows.Forms.Button bttUpdateIngredient;
        private System.Windows.Forms.TextBox txtIngredientsUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIngredientsActualQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCookingTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeopleServed;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttDeletePlan;
        private System.Windows.Forms.Button bttUpdatePlan;
        private System.Windows.Forms.Button bttCreatePlan;
        private System.Windows.Forms.DateTimePicker dTPickerPlan;
        private System.Windows.Forms.ComboBox cBoxRecipesPlan;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.Button bttUpdateStock;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit1;
    }
}

