using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Food_Stock
{
    public partial class Form1:Form
    {
        //Loading
        void UpdatePlanComboBox()
        {
            cBoxRecipesPlan.BindingContext = new BindingContext();
            cBoxRecipesPlan.ValueMember = "Name";
            cBoxRecipesPlan.DataSource = recipesTable;
        }
        void BindPlanTable()
        {
            planTable = new DataTable();
            planTable.Columns.Add("Id", typeof(Int16));
            planTable.Columns.Add("RecipeId", typeof(Int16));
            planTable.Columns.Add("Recipe Name", typeof(string));
            planTable.Columns.Add("Date", typeof(DateTime));
            dgvPlan.DataSource = planTable;

            //Load the values from a DB
            query = "SELECT * FROM PlanTable";

            conn = new SqlConnection(connectionString);
            command = new SqlCommand(query, conn);
            SqlDataReader reader, reader2;
            SqlCommand command2;

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int recipeId = int.Parse(reader["RecipeId"].ToString());
                    string recipeName = "";

                    query = "SELECT Name FROM RecipesTable WHERE Id = " + recipeId;
                    command2 = new SqlCommand(query, conn);
                    //reader2 = command2.ExecuteReader();

                    reader2 = command2.ExecuteReader();
                    reader2.Read();
                    recipeName = reader2[0].ToString();

                    planTable.Rows.Add(reader["Id"], recipeId, recipeName, reader["Date"]);
                }
            }
            finally
            {
                conn.Close();
            }

            //Read RecipeNames
            try
            {
                conn.Open();

                int index=0;
                foreach (DataRow r in planTable.Rows)
                {
                    int Id = int.Parse(r.ItemArray[0].ToString());
                    var recipeId = r.ItemArray[1];
                    query = "SELECT Name FROM RecipesTable WHERE ID = " + recipeId;
                    command = new SqlCommand(query, conn);
                    //command.CommandText = query;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var recipeName = reader["Name"];
                        planTable.Rows[index].ItemArray[2] = recipeName;
                    }
                    index++;
                }
            }
            finally
            {
                conn.Close();
            }
            
        }
        void DisableSortingDgvPlan()
        {
            //Disable sorting
            foreach (DataGridViewColumn col in dgvPlan.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void SetDgvPlanSize()
        {
            dgvPlan.Columns["Id"].Visible = false;
            dgvPlan.Columns["RecipeId"].Visible = false;
        }

        //CRUD
        void CreatePlan(Plan plan)
        {
            //Create on DB
            command = new SqlCommand("INSERT INTO PlanTable VALUES (@RecipeId, @Date)", conn);
            command.Parameters.AddWithValue("@RecipeId", plan.RecipeId);
            command.Parameters.AddWithValue("@Date", plan.Date.Date);

            /*query = string.Format("INSERT INTO PlanTable VALUES ({0}, '{1}')", 
                plan.RecipeId, date);

            command.CommandText = query;*/

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            //Create on planTable
            string date = string.Format("{0:dd/MM/yyyy}", plan.Date);
            int id = GetIdFromPlanTable(plan.RecipeId);
            planTable.Rows.Add( id, plan.RecipeId, GetRecipeName(plan.RecipeId), date);
        }
        void ReadPlan(int index)
        {
            if (index > -1)
            {
                //Fill DataPicker and cBox with correct Values
                string recipeName = planTable.Rows[index].ItemArray[2].ToString();
                DateTime date = (DateTime)planTable.Rows[index].ItemArray[3]; 

                cBoxRecipesPlan.Text = recipeName;
                dTPickerPlan.Text = date.ToString();
            }
        }
        void UpdatePlan(int index, Plan plan)
        {
            //DB
            int id = int.Parse(dgvPlan.Rows[index].Cells["Id"].Value.ToString());
            
            command = new SqlCommand("UPDATE PlanTable SET RecipeId = @RecipeId, Date = @Date WHERE Id = @Id", conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RecipeId", plan.RecipeId);
            command.Parameters.AddWithValue("@Date", plan.Date.Date);
            command.Parameters.AddWithValue("@Id", id);

            /*query = string.Format("UPDATE PlanTable SET RecipeId = {0}, Date = '{1}' WHERE Id = {2}",
                plan.RecipeId, 
                string.Format("{0:MM/dd/yyyy}",plan.Date), 
                id);
            command.CommandText = query;*/
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            //table
            Object[] newPlan = { id, plan.RecipeId, GetRecipeName(plan.RecipeId), string.Format("{0:dd/MM/yyyy}", plan.Date)};
            planTable.Rows[index].ItemArray = newPlan;
        }
        void DeletePlan(int index)
        {
            int id = Convert.ToInt16(dgvPlan.Rows[index].Cells[0].Value);

            //Delete on DB
            query = "DELETE FROM PlanTable WHERE Id = " + id;
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

            //Delete on table
            dgvPlan.Rows.RemoveAt(index);
        }

        //Others
        Plan GetPlanFromForm()
        {
            DateTime date = dTPickerPlan.Value;
            int recipeId = GetRecipeId(cBoxRecipesPlan.Text);
            int id = -1; //NextId doesn't seem safe

            Plan plan = new Plan(id, recipeId, date);
            return plan;
        }
        int GetIdFromPlanTable(int RecipeId)
        {
            int id = -1;
            query = "SELECT Id FROM PlanTable WHERE RecipeId = " + RecipeId;
            command.CommandText = query;
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Read();
                id = (int)reader[0];
            }
            finally
            {
                conn.Close();
            }

            return id;
        }
        bool IsRecipeInPlan(int recipeId)
        {
            bool isRecipePlanned = false;
            foreach (DataRow rows in planTable.Rows)
            {
                int consideredRecipeId = Convert.ToInt16(rows.ItemArray[1]);
                if (recipeId == consideredRecipeId)
                {
                    isRecipePlanned = true;
                    return isRecipePlanned;
                }
            }

            return isRecipePlanned;
        }
    }
}
