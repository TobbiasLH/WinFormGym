using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WinFormGym.Classes
{
    internal class DataLayer
    {

        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


        //Meals

        public static DataTable SelectMealByMealName(string mealName)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Meals
              WHERE MealName like '%' + @MealName + '%'
            ";

            sqlCommand.Parameters.AddWithValue("@MealName", mealName);

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public static int InsertMeals(string mealName, string calories, string protein, string carboHydrates, string fat, string fiber)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO Meals(MealName, Calories, Protein, CarboHydrates, Fat, Fiber) VALUES (@MealName, @Calories, @Protein, @CarboHydrates, @Fat, @Fiber)";

            sqlCommand.Parameters.AddWithValue("@MealName", mealName);
            sqlCommand.Parameters.AddWithValue("@Calories", calories);
            sqlCommand.Parameters.AddWithValue("@Protein", protein);
            sqlCommand.Parameters.AddWithValue("@CarboHydrates", carboHydrates);
            sqlCommand.Parameters.AddWithValue("@Fat", fat);
            sqlCommand.Parameters.AddWithValue("@Fiber", fiber);


            result = UpdateData(sqlCommand);

            return result;
        }




        public static int UpdateMeals(int mealID, string mealName, string calories, string protein, string carboHydrates, string fat, string fiber)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            UPDATE Meals
            SET MealName = @MealName,
                Calories = @Calories,
                Protein = @Protein,
                CarboHydrates = @CarboHydrates
                Fat = @Fat
                Fiber = @Fiber
            
            WHERE MealID = @MealID
            ";

            sqlCommand.Parameters.AddWithValue("@MealID", mealID);
            sqlCommand.Parameters.AddWithValue("@MealName", mealName);
            sqlCommand.Parameters.AddWithValue("@Calories", calories);
            sqlCommand.Parameters.AddWithValue("@Protein", protein);
            sqlCommand.Parameters.AddWithValue("@CarboHydrates", carboHydrates);
            sqlCommand.Parameters.AddWithValue("@Fat", fat);
            sqlCommand.Parameters.AddWithValue("@Fiber", fiber);

            result = UpdateData(sqlCommand);

            return result;
        }


        public static DataTable SelectAllMeals()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Meals
            ";

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }



        // DB Functions

        private static int UpdateData(SqlCommand sqlCommand)
        {
            int affectedRows = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    affectedRows = sqlCommand.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        public static DataTable SelectData(SqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    dataTable.Load(sqlCommand.ExecuteReader());
                }
            }

            return dataTable;
        }
    }
}
