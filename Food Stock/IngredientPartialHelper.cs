using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Stock
{
    public partial class Form1 : Form
    {
        //On Load
        void BindIngredientsTable()
        {
            ingredientsTable = new DataTable();
            ingredientsTable.Columns.Add("Ingredients", typeof(string));
            ingredientsTable.Columns.Add("In Stock", typeof(Int16));
            ingredientsTable.Columns.Add("Units", typeof(string));
            ingredientsTable.Columns.Add("Expected Stock", typeof(Int16));
            dgvIngredients.DataSource = ingredientsTable;

            //Load the values from a DB
            query = "SELECT * FROM Ingredients";

            conn = new SqlConnection(connectionString);
            command = new SqlCommand(query, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ingredientsTable.Rows.Add(reader["Ingredients"], reader["InStock"], reader["Units"], reader["ExpectedStock"]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        void DisableSortingDgvIngredients()
        {
            //Disable sorting
            foreach (DataGridViewColumn col in dgvIngredients.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void SetDgvIngredientsSize()
        {
            //Change Columns Width
            dgvIngredients.Columns["Ingredients"].Width = 100;
            dgvIngredients.Columns["In Stock"].Width = 68;
            dgvIngredients.Columns["Units"].Width = 40;
            dgvIngredients.Columns["Expected Stock"].Width = 65;
        }
        void UpdateIngredientsComboBox()
        {
            comboBox1.ValueMember = "Ingredients";
            comboBox1.DataSource = ingredientsTable;
            comboBox1.Text = "None";

            comboBox2.BindingContext = new BindingContext();
            comboBox2.ValueMember = "Ingredients";
            comboBox2.DataSource = ingredientsTable;
            comboBox2.Text = "None";

            comboBox3.BindingContext = new BindingContext();
            comboBox3.ValueMember = "Ingredients";
            comboBox3.DataSource = ingredientsTable;
            comboBox3.Text = "None";

            comboBox4.BindingContext = new BindingContext();
            comboBox4.ValueMember = "Ingredients";
            comboBox4.DataSource = ingredientsTable;
            comboBox4.Text = "None";

            comboBox5.BindingContext = new BindingContext();
            comboBox5.ValueMember = "Ingredients";
            comboBox5.DataSource = ingredientsTable;
            comboBox5.Text = "None";
        }

        //Buttons Actions
        void AddIngredientButton()
        {
            string newIngredient = txtIngredient.Text;
            string sNewQuantity = txtIngredientsActualQuantity.Text;
            string newUnit = txtIngredientsUnits.Text;

            Int16 newQuantity = 0;
            Int16.TryParse(sNewQuantity, out newQuantity);

            //add to table
            ingredientsTable.Rows.Add(newIngredient, newQuantity, newUnit);

            //save to DB
            query = string.Format("INSERT INTO Ingredients VALUES ('{0}', {1}, 0, '{2}')",
                newIngredient, newQuantity, newUnit);

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
        void UpdateIngredientsButton()
        {
            string updatedIngredient = txtIngredient.Text;
            string updatedStock = txtIngredientsActualQuantity.Text;
            string updatedUnits = txtIngredientsUnits.Text;

            int index = -2;

            try
            {
                index = dgvIngredients.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("Please select a valid ingredient first");
                return;
            }

            if (index > -1)
            {
                //add to table
                DataRow row = ingredientsTable.Rows[index];

                //save to DB
                StringBuilder sb = new StringBuilder();

                query = String.Format("UPDATE Ingredients SET Ingredients = '{0}', InStock = '{1}', Units = '{2}' WHERE Ingredients='{3}'", updatedIngredient, updatedStock, updatedUnits, row[0]);

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

                Int16 intUpdatedStock = 0;
                Int16.TryParse(updatedStock, out intUpdatedStock);

                Object[] obj = { updatedIngredient, intUpdatedStock, updatedUnits };

                ingredientsTable.Rows[index].ItemArray = obj;
            }
        }
        void DeleteIngredient()
        {
            //Read actual dgvIngredients Index
            int index = -2;
            try
            {
                index = dgvIngredients.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("Please select a valid ingredient");
            }

            if (index > -1)
            {
                string ingredientName = ingredientsTable.Rows[index].ItemArray[0].ToString();

                //Avoid dependency problems
                foreach(DataRow recipeRow in recipesTable.Rows)
                {
                    int recipeId = Convert.ToInt16(recipeRow.ItemArray[0]);
                    var ingredientsList = GetRecipeIngredientsFromDB(recipeId);

                    foreach (IngredientsQuantity ingredient in ingredientsList)
                    {
                        if(ingredient.ingredient == ingredientName)
                        {
                            MessageBox.Show("Error: Ingredient already in use in a recipe");
                            return;
                        }
                    }
                }

                //Delete Value from DB
                query = "DELETE FROM Ingredients WHERE Ingredients = '" + ingredientName + "'";

                try
                {
                    conn.Open();
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }

                //Delete Value from DataTable
                ingredientsTable.Rows[index].Delete();
            }
        }
        void ReadIngredient(int index)
        {
            if (index > -1)
            {
                var row = ingredientsTable.Rows[index].ItemArray;

                txtIngredient.Text = row[0].ToString();
                txtIngredientsActualQuantity.Text = row[1].ToString();
                txtIngredientsUnits.Text = row[2].ToString();
            }
        }

        //Others -Not being used
        int GetIndexFromIngredientsTable(string ingredient)
        {
            int index = -1;

            DataRow[] filteredRows = ingredientsTable.Select(string.Format("{0} LIKE %{1}% ", "Ingredients", ingredient));
            var v = filteredRows[0].ItemArray;

            return index;
        }
    }
}
