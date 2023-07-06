using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormGym.Classes;

namespace WinFormGym
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeApplication();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataLayer.SelectMealByMealName(tbSearchText.Text);

            dgwGym.DataSource = dataTable;

            Log("User Searched: " + tbSearchText.Text);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedMealID = Convert.ToInt32(dgwGym.SelectedRows[0].Cells["MealID"].Value);

                DataLayer.UpdateMeals(selectedMealID, tbMealName.Text, tbCalories.Text, tbProtein.Text, tbCarboHydrates.Text, tbFat.Text, tbFiber.Text);

                RefreshMealsGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }



        private void RefreshMealsGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllMeals();

            dgwGym.DataSource = dataTable;
        }


        public void InitializeApplication()
        {

            StartPosition = FormStartPosition.CenterScreen;

            dgwGym.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RefreshMealsGridView();
        }

        // Log
        private void ErrorLog(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("ErrorLog.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        private void Log(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        
    }
}
