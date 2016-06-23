using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace aspnetFinalTermExam.Models
{
    public class EmployeeService
    {
        /// <summary>
        /// 取得DB連線字串
        /// </summary>
        /// <returns></returns>
        private string GetDBConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }

        /// <summary>
        /// 依照條件取得員工資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Employee> GetEmpByCondtioin(Models.SearchArg arg)
        {

            DataTable dt = new DataTable();
            string sql = @"SELECT 
					A.EmployeeID,A.FirstName+' '+A.LastName As EmpName,
					A.Title,B.CodeID+'-'+B.CodeVal As CTitle,
					A.Gender,A.BirthDate,A.HireDate
					From HR.Employees As A 
					INNER JOIN dbo.CodeTable As B ON A.title=B.CodeID
					Where (A.FirstName Like @FirstName Or @FirstName='') AND
						  (A.LastName=@LastName Or @LastName='') AND
						  (A.Title=@Title Or @Title='') AND
                          (A.EmployeeID=@EmployeeID Or @EmployeeID='') AND
                          (A.HireDate=@HireDate Or @HireDate='') AND
                          (A.BirthDate=@BirthDate Or @BirthDate='')";


            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", arg.EmployeeID == null ? default(int) : arg.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@FirstName", arg.FirstName == null ? string.Empty : arg.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", arg.LastName == null ? string.Empty : arg.LastName));
                cmd.Parameters.Add(new SqlParameter("@Title", arg.Title == null ? string.Empty : arg.Title));
                cmd.Parameters.Add(new SqlParameter("@HireDate", arg.HireDate == null ? string.Empty : arg.HireDate));
                cmd.Parameters.Add(new SqlParameter("@BirthDate", arg.BirthDate == null ? string.Empty : arg.BirthDate));

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }


            return this.MapOrderDataToList(dt);
        }

        private List<Models.Employee> MapOrderDataToList(DataTable orderData)
        {
            List<Models.Employee> result = new List<Employee>();

            foreach (DataRow row in orderData.Rows)
            {
                result.Add(new Employee()
                {
                    EmployeeID = (int)row["EmployeeID"],
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Title = row["Title"].ToString(),
                    HireDate = row["HireDate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["HireDate"],
                    BirthDate = row["BirthDate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["BirthDate"]
                    //ShipAddress = row["ShipAddress"].ToString(),
                    //ShipCity = row["ShipCity"].ToString(),
                    //ShipCountry = row["ShipCountry"].ToString(),
                    //ShipName = row["ShipName"].ToString(),
                    //ShippedDate = row["ShippedDate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["ShippedDate"],
                    //ShipperId = (int)row["ShipperId"],
                    //ShipperName = row["ShipperName"].ToString(),
                    //ShipPostalCode = row["ShipPostalCode"].ToString(),
                    //ShipRegion = row["ShipRegion"].ToString()
                });
            }
            return result;
        }
    }
}