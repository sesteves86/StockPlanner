using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Stock
{
    public partial class Form1 : Form
    {
        DataTable ingredientsTable, recipesTable, planTable;
        string query;
        SqlConnection conn;
        SqlCommand command;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //CultureInfo.CurrentCulture = CultureInfo.

            //var v = CultureInfo.InstalledUICulture.Calendar;

            //Others
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""c:\users\sergio\documents\visual studio 2015\Projects\Food Stock\Food Stock\DBRecipes.mdf"";Integrated Security=True; MultipleActiveResultSets=true";

            //Ingredients
            BindIngredientsTable();
            DisableSortingDgvIngredients();
            SetDgvIngredientsSize();

            //Recipes
            UpdateIngredientsComboBox();
            BindRecipesTable();
            DisableSortingDgvRecipes();
            SetDgvRecipesSize();

            //Plans
            UpdatePlanComboBox();
            BindPlanTable();
            DisableSortingDgvPlan();
            SetDgvPlanSize();

        }

        //================================
        //Ingredients Tab
        //================================
        private void bttAddIngredient_Click(object sender, EventArgs e)
        {
            AddIngredientButton();
        }
        private void bttDeleteIngredient_Click(object sender, EventArgs e)
        {
            DeleteIngredient();
        }
        private void bttUpdateIngredient_Click(object sender, EventArgs e)
        {
            UpdateIngredientsButton();
        }
        private void IngredientsRead(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ReadIngredient(index);
        }
        
        //================================
        //Recipes Tab
        //================================
        private void bttUpdate_Click(object sender, EventArgs e)
        {
            Recipe recipe = GetRecipeFromForm();

            UpdateRecipe(recipe);
        }
        private void bttAddNewRecipe_Click(object sender, EventArgs e)
        {
            Recipe recipe = GetRecipeFromForm();

            AddNewRecipe(recipe);
        }
        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReadRecipe(e);
        }
        private void bttDelete_Click(object sender, EventArgs e)
        {
            DeleteRecipe();
        }
        private void cBox1Changed(object sender, EventArgs e)
        {
            //Update the units
            string ingredient = comboBox1.Text;
            string selector = string.Format("{0} LIKE '%{1}%'", "Ingredients", ingredient); ;
            DataRow filteredRow = ingredientsTable.Select(selector)[0];
            
            lblUnit1.Text = filteredRow.ItemArray[2].ToString();
        }
        private void cBox2Changed(object sender, EventArgs e)
        {
            //Update the units
            string ingredient = comboBox2.Text;
            string selector = string.Format("{0} LIKE '%{1}%'", "Ingredients", ingredient); ;
            DataRow filteredRow = ingredientsTable.Select(selector)[0];

            lblUnit2.Text = filteredRow.ItemArray[2].ToString();
        }
        private void cBox3Changed(object sender, EventArgs e)
        {
            //Update the units
            string ingredient = comboBox3.Text;
            string selector = string.Format("{0} LIKE '%{1}%'", "Ingredients", ingredient); ;
            DataRow filteredRow = ingredientsTable.Select(selector)[0];

            lblUnit3.Text = filteredRow.ItemArray[2].ToString();
        }
        private void cBox4Changed(object sender, EventArgs e)
        {
            //Update the units
            string ingredient = comboBox4.Text;
            string selector = string.Format("{0} LIKE '%{1}%'", "Ingredients", ingredient); ;
            DataRow filteredRow = ingredientsTable.Select(selector)[0];

            lblUnit4.Text = filteredRow.ItemArray[2].ToString();
        }
        private void cBox5Changed(object sender, EventArgs e)
        {
            //Update the units
            string ingredient = comboBox5.Text;
            string selector = string.Format("{0} LIKE '%{1}%'", "Ingredients", ingredient); ;
            DataRow filteredRow = ingredientsTable.Select(selector)[0];

            lblUnit5.Text = filteredRow.ItemArray[2].ToString();
        }

        //================================
        //Plan Tab
        //================================
        private void bttCreatePlan_Click(object sender, EventArgs e)
        {
            Plan plan = GetPlanFromForm();
            CreatePlan(plan);
        }
        private void bttUpdatePlan_Click(object sender, EventArgs e)
        {
            int index = dgvPlan.CurrentCell.RowIndex;
            Plan plan = GetPlanFromForm();
            UpdatePlan(index, plan);
        }
        private void bttDeletePlan_Click(object sender, EventArgs e)
        {
            int index = dgvPlan.CurrentCell.RowIndex;
            DeletePlan(index);
        }
        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ReadPlan(index);
        }
        
        //Update Stock
        private void bttUpdateStock_Click(object sender, EventArgs e)
        {
            //Reset the Expected stock == In Stock in ingredientsTable
            foreach(DataRow row in ingredientsTable.Rows)
            {
                Object[] o = row.ItemArray;
                int initQuantity = Convert.ToInt16(o[1]);
                string ingredientName = o[0].ToString();
                o[3] = initQuantity;
                row.ItemArray = o;

                //Save to DB
                query = string.Format("UPDATE Ingredients SET ExpectedStock = '{0}' WHERE Ingredients = '{1}'", 
                    initQuantity, ingredientName);
                command.CommandText = query;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }

            //Take ammount from each ingredient
            foreach(DataRow row in planTable.Rows)
            {
                int recipeId = Convert.ToInt16(row.ItemArray[1]);

                List<IngredientsQuantity> ingredientsList = 
                    GetRecipeIngredientsFromDB(recipeId);

                foreach (IngredientsQuantity i in ingredientsList)
                {
                    //Deduce ingredients from the expected quantity in ingredientsTable
                    int consumedQuantity = i.Quantity;

                    //int index = GetIndexFromIngredientsTable(i.ingredient);

                    //var newIngredient = ingredientsTable.Rows[index].ItemArray;

                    string sSelector = string.Format("{0} LIKE '%{1}%'", "Ingredients", i.ingredient);
                    var filteredTable = ingredientsTable.Select(sSelector);
                    var newIngredient = filteredTable[0].ItemArray;

                    int newExpectedQuantity = Convert.ToInt16(newIngredient[3]) - consumedQuantity;
                    //newIngredient[1] = newExpectedQuantity;
                    //ingredientsTable.Rows[index].ItemArray = newIngredient;
                    
                    //Update on DB
                    query = string.Format(
                        "UPDATE Ingredients " + 
                        "SET ExpectedStock = {0}" +
                        "WHERE Ingredients = '{1}'",
                        newExpectedQuantity, newIngredient[0]);

                    command.CommandText = query;
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    finally
                    {
                        conn.Close();
                    }

                    BindIngredientsTable();
                }
                
            }
        }

        //Handling TextBoxes to just accept numbers
        private void OnlyNumbersTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) 
                && !char.IsNumber(e.KeyChar) 
                && (e.KeyChar != '.' ))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1){
                e.Handled = true;
            }
        }
    }
    
}
