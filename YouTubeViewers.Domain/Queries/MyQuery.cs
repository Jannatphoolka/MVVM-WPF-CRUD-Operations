using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

namespace YouTubeViewers.Domain.Queries
{
    class MyQuery
    {
        private static string cs = "Server=localhost;Username=postgres;Password=1234;Database=postgres";

        public NpgsqlConnection con = new NpgsqlConnection(cs);
        private static ObservableCollection<Employee> employeeobj;


        #region GETALL()
        public ObservableCollection<Employee> GetAll()
        {
            try
            {
                string select = "SELECT * FROM foundation";
                //string select = "SELECT * FROM foundation WHERE salary=4939834";


                NpgsqlCommand cmd = new NpgsqlCommand(select, con);
                con.Open();
                NpgsqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        employeeobj.Add(new Employee
                        {
                            IDProperty = read.GetInt32(0),
                            NamesProperty = read.GetString(1),
                            SalProperty = read.GetInt32(2),
                            DesignProperty = read.GetString(3)

                        });

                    }
                }
                else { Console.WriteLine("No rows found!"); }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return employeeobj;
        }
        #endregion
        #region TEST
        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public MyQuery()
        {
            employeeobj = new ObservableCollection<Employee>();
            LoadData();
        }
        private void LoadData() => Employees = new ObservableCollection<Employee>(GetAll());

        #endregion
    }
}
