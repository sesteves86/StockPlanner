using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Food_Stock
{
    public partial class Form1 : Form
    {
        //On Loading
        public void BindRecipesTable()
        {
            recipesTable = new DataTable();
            recipesTable.Columns.Add("Id", typeof(Int16));
            recipesTable.Columns.Add("Name", typeof(string));
            recipesTable.Columns.Add("People Served", typeof(Int16));
            recipesTable.Columns.Add("Cooking Time", typeof(Int16));
            dgvRecipes.DataSource = recipesTable;

            //Load the values from a DB
            query = "SELECT * FROM RecipesTable";

            conn = new SqlConnection(connectionString);
            command = new SqlCommand(query, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipesTable.Rows.Add(reader["Id"], reader["Name"], reader["PeopleServed"], reader["CookingTime"]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void DisableSortingDgvRecipes()
        {
            //Disable sorting
            foreach (DataGridViewColumn col in dgvRecipes.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void SetDgvRecipesSize()
        {
            //Change Columns Width
            dgvRecipes.Columns["Id"].Visible = false;
            dgvRecipes.Columns["People Served"].Width = 60;
            dgvRecipes.Columns["Cooking Time"].Width = 57;
        }
        
        Recipe GetRecipeFromForm()
        {
            string name = txtRecipeName.Text;
            string sPeopleServed = txtPeopleServed.Text;
            string sCookingTime = txtCookingTime.Text;

            Int16 peopleServed = 0;
            Int16.TryParse(sPeopleServed, out peopleServed);

            Int16 cookingTime = 0;
            Int16.TryParse(sCookingTime, out cookingTime);

            //ingredientsList
            List<IngredientsQuantity> ingredientsList = new List<IngredientsQuantity>();

            IngredientsQuantity ingredientQuantity = new IngredientsQuantity();

            if (!(comboBox1.Text == "" || comboBox1.Text == "none" || comboBox1.Text == "None" || txtQty1.Text==""))
            {
                ingredientQuantity.ingredient = comboBox1.Text;
                ingredientQuantity.Quantity = int.Parse(txtQty1.Text);
                ingredientQuantity.unit = lblUnit1.Text;
                ingredientsList.Add(ingredientQuantity);
            }

            if (!(comboBox2.Text == "" || comboBox2.Text == "none" || comboBox2.Text == "None" || txtQty2.Text == ""))
            {
                ingredientQuantity = new IngredientsQuantity();
                ingredientQuantity.ingredient = comboBox2.Text;
                ingredientQuantity.Quantity = int.Parse(txtQty2.Text);
                ingredientQuantity.unit = lblUnit2.Text;
                ingredientsList.Add(ingredientQuantity);
            }

            if (!(comboBox3.Text == "" || comboBox3.Text == "none" || comboBox3.Text == "None" || txtQty3.Text == ""))
            {
                ingredientQuantity = new IngredientsQuantity();
                ingredientQuantity.ingredient = comboBox3.Text;
                ingredientQuantity.Quantity = int.Parse(txtQty3.Text);
                ingredientQuantity.unit = lblUnit3.Text;
                ingredientsList.Add(ingredientQuantity);
            }

            if (!(comboBox4.Text == "" || comboBox4.Text == "none" || comboBox4.Text == "None" || txtQty4.Text == ""))
            {
                ingredientQuantity = new IngredientsQuantity();
                ingredientQuantity.ingredient = comboBox4.Text;
                ingredientQuantity.Quantity = int.Parse(txtQty4.Text);
                ingredientQuantity.unit = lblUnit4.Text;
                ingredientsList.Add(ingredientQuantity);
            }

            if (!(comboBox5.Text == "" || comboBox5.Text == "none" || comboBox5.Text == "None" || txtQty5.Text == ""))
            {
                ingredientQuantity = new IngredientsQuantity();
                ingredientQuantity.ingredient = comboBox5.Text;
                ingredientQuantity.Quantity = int.Parse(txtQty5.Text);
                ingredientQuantity.unit = lblUnit5.Text;
                ingredientsList.Add(ingredientQuantity);
            }

            //int Id = GetNextRecipeId();

            Recipe recipe = new Recipe(ingredientsList, peopleServed, cookingTime, name);

            return recipe;
        }
        Recipe GetRecipeFromDB(int Id)
        {
            Recipe recipe;
            string name;
            int peopleServed, cookingTime;

            query = "SELECT * FROM RecipesTable WHERE Id = " + Id.ToString();
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                name = reader["Name"].ToString();
                peopleServed = (int)reader["PeopleServed"];
                cookingTime = (int)reader["CookingTime"];
            }
            finally
            {
                conn.Close();
            }

            List<IngredientsQuantity> ingredientsList = GetRecipeIngredientsFromDB(Id);

            recipe = new Recipe(ingredientsList, peopleServed, cookingTime, name, Id);

            return recipe;
        }
        List<IngredientsQuantity> GetRecipeIngredientsFromDB(int RecipeId)
        {
            List<IngredientsQuantity> ingredientsList = new List<IngredientsQuantity>();
            SqlDataReader reader;

            query = "SELECT * FROM RecipesIngredientsTable WHERE RecipeId = " + RecipeId.ToString();
            command = new SqlCommand(query, conn);
            try
            {
                conn.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IngredientsQuantity ingredient = new IngredientsQuantity();
                    ingredient.ingredient = reader["Ingredient"].ToString();
                    ingredient.Quantity = (int)reader["Quantity"];
                    ingredient.unit = reader["Unit"].ToString();

                    ingredientsList.Add(ingredient);
                }

            }
            finally
            {
                conn.Close();
            }

            return ingredientsList;
        }

        void UpdateRecipe(Recipe recipe)
        {
            //Check if cell in table selected
            int index = -2;

            try
            {
                index = dgvRecipes.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("Please select a valid recipe first from the list");
                return;
            }

            if (index > -1)
            {
                //Get RecipeId
                int recipeId = 0;

                query = string.Format("SELECT Id " +
                        "FROM RecipesTable " +
                        "WHERE Name = '{0}'", recipe.name);

                command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    recipeId = (int)reader[0];
                }
                finally
                {
                    conn.Close();
                }

                //save to RecipesTable
                StringBuilder sb = new StringBuilder();

                query = String.Format(
                    "UPDATE RecipesTable " +
                    "SET PeopleServed = '{0}', CookingTime = '{1}', Name = '{2}' " +
                    "WHERE Id='{3}'", 
                    recipe.nPeopleServed, recipe.minutesToPrepare, recipe.name, recipeId);

                command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }

                //Save to RecipesIngredientsTable
                try
                {
                    conn.Open();

                    query = "DELETE FROM RecipesIngredientsTable " +
                        "WHERE RecipeId = " + recipeId;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    foreach(IngredientsQuantity i in recipe.ingredientsList)
                    {
                        query = string.Format("INSERT INTO RecipesIngredientsTable " +
                           "VALUES ({0}, '{1}', {2}, '{3}')", 
                           recipeId, i.ingredient, i.Quantity, i.unit);

                        command.CommandText = query;

                        command.ExecuteNonQuery();
                    }

                }
                finally
                {
                    conn.Close();
                }


                //add to recipesTable
                Object[] newRecipe = { recipeId, recipe.name, recipe.nPeopleServed, recipe.minutesToPrepare };
                recipesTable.Rows[index].ItemArray = newRecipe;
            }

        }
        void AddNewRecipe(Recipe recipe)
        {
            if (recipe.ingredientsList.Count == 0 || recipe.minutesToPrepare == 0 || recipe.nPeopleServed == 0)
            {
                MessageBox.Show("Please fill all fields to create a new recipe.");
            }
            else
            {
                //Recipe Table
                query = string.Format("INSERT INTO RecipesTable " +
                    "VALUES ({0}, {1}, '{2}')", recipe.nPeopleServed, recipe.minutesToPrepare, recipe.name);

                command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }

                //Recipe Ingredients Table
                int recipeId = 0;

                query = string.Format("SELECT Id " +
                        "FROM RecipesTable " +
                        "WHERE Name = '{0}'", recipe.name);

                command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    recipeId = (int)reader[0];
                }
                finally
                {
                    conn.Close();
                }

                try
                {
                    conn.Open();
                    foreach (var i in recipe.ingredientsList)
                    {
                        query = string.Format("INSERT INTO RecipesIngredientsTable " +
                            "VALUES ({0}, '{1}', {2}, '{3}')", recipeId, i.ingredient, i.Quantity, i.unit);

                        command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                    }
                }
                finally
                {
                    conn.Close();
                }

                //recipesTable
                recipesTable.Rows.Add(
                    recipeId,
                    recipe.name,
                    recipe.nPeopleServed,
                    recipe.minutesToPrepare
                );
            }
        }
        void ReadRecipe(DataGridViewCellEventArgs e)
        {
            //Fill the text boxes
            int index = e.RowIndex;
            if (index > -1)
            {
                var row = recipesTable.Rows[index].ItemArray;

                int id = int.Parse(row[0].ToString());
                txtRecipeName.Text = row[1].ToString();
                txtPeopleServed.Text = row[2].ToString();
                txtCookingTime.Text = row[3].ToString();
                
                Recipe recipe = GetRecipeFromDB(id);
                //ToDo: Protect from null entries
                IngredientsQuantity ingredients;

                //1
                ingredients = recipe.ingredientsList[0];

                if (recipe.name == "None" || recipe.name == null || recipe.name == "")
                {
                    comboBox1.Text = "None";
                }
                else
                {
                    comboBox1.Text = ingredients.ingredient;
                    txtQty1.Text = ingredients.Quantity.ToString();
                    lblUnit1.Text = ingredients.unit;
                }

                //2
                if (recipe.ingredientsList.Count < 2 )
                {
                    comboBox2.Text = "None";
                    txtQty2.Text = "0";
                    lblUnit2.Text = "";
                    
                }
                else
                {
                    ingredients = recipe.ingredientsList[1];
                    comboBox2.Text = ingredients.ingredient;
                    txtQty2.Text = ingredients.Quantity.ToString();
                    lblUnit2.Text = ingredients.unit;
                }

                //3
                if (recipe.ingredientsList.Count < 3)
                {
                    comboBox3.Text = "None";
                    txtQty3.Text = "0";
                    lblUnit3.Text = "";
                    
                }
                else
                {
                    ingredients = recipe.ingredientsList[2];
                    comboBox3.Text = ingredients.ingredient;
                    txtQty3.Text = ingredients.Quantity.ToString();
                    lblUnit3.Text = ingredients.unit;
                }

                //4
                if (recipe.ingredientsList.Count < 4)
                {
                    comboBox4.Text = "None";
                    txtQty4.Text = "0";
                    lblUnit4.Text = "";
                    
                }
                else
                {
                    ingredients = recipe.ingredientsList[3];
                    comboBox4.Text = ingredients.ingredient;
                    txtQty4.Text = ingredients.Quantity.ToString();
                    lblUnit4.Text = ingredients.unit;
                }

                //5
                if (recipe.ingredientsList.Count < 5)
                {
                    comboBox5.Text = "None";
                    txtQty5.Text = "0";
                    lblUnit5.Text = "";
                    return;
                }
                else
                {
                    ingredients = recipe.ingredientsList[4];
                    comboBox5.Text = ingredients.ingredient;
                    txtQty5.Text = ingredients.Quantity.ToString();
                    lblUnit5.Text = ingredients.unit;
                }
            }
        }
        void DeleteRecipe()
        {
            int id = int.Parse(dgvRecipes.CurrentRow.Cells[0].Value.ToString());
            int index = dgvRecipes.CurrentCell.RowIndex;

            if (IsRecipeInPlan(id))
            {
                MessageBox.Show("Cannot delete this recipe. \n This Recipe is already included in a plan.");
                return;
            }
                

            //Delete from recipeTable
            recipesTable.Rows.RemoveAt(index);

            //Delete from RecipesIngredientsTable
            query = "DELETE FROM RecipesIngredientsTable WHERE RecipeId = " + id;
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            //Delete from RecipesTable
            query = "DELETE FROM RecipesTable WHERE Id = "+id;
            command = new SqlCommand(query, conn);

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

        //DB
        int GetNextRecipeId()
        {
            int maxId = 0;

            query = "SELECT TOP 1 Id FROM RecipesTable ORDER BY Id DESC";

            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                maxId = (int)reader[0];
            }
            finally
            {
                conn.Close();
            }

            return maxId+1;
        }
        string GetRecipeName(int recipeId)
        {
            SqlDataReader reader;
            string recipeName = "Error";
            query = "SELECT Name FROM RecipesTable WHERE Id = " + recipeId;
            command.CommandText = query;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Read();
                recipeName = reader[0].ToString();
            }
            finally
            {
                conn.Close();
            }

            return recipeName;
        }
        int GetRecipeId(string name)
        {
            int id = -1;

            query = string.Format("SELECT Id FROM RecipesTable WHERE Name = '{0}'",
                name);
            command.CommandText = query;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                id = (int)reader[0];
            }
            finally
            {
                conn.Close();
            }
            

            return id;
        }
    }
}
