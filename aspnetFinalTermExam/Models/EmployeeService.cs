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

        /*/// <summary>
        /// 依照條件取得員工資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Employee> GetOrderByCondtioin(Models.SearchArg arg)
        {

            DataTable dt = new DataTable();
            string sql = @"SELECT 
					A.EmployeeID,A.FirstName+' '+A.LastName As EmpName,
					B.CodeID+'-'+B.CodeVal As Title,
					A.Gender,A.BirthDate,A.HireDate
					From HR.Employees As A 
					INNER JOIN dbo.CodeTable As B ON A.title=B.CodeID
					Where (EmpName Like @FirstName Or @FirstName='' Or @LastName Or @LastName='') AND 
						  (A.EmployeeID=@EmployeeID Or @EmployeeID='') AND
                          (A.EmployeeID=@EmployeeID Or @EmployeeID='') AND
                          (A.ShipperID=@ShipperID Or @ShipperID='') AND
                          (A.ShippedDate=@ShippedDate Or @ShippedDate='') AND
						  (A.Orderdate=@Orderdate Or @Orderdate='')AND
						  (A.RequireDdate=@RequireDdate Or @RequireDdate='')";


            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", arg.EmployeeID == null ? default(int) : arg.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@FirstName", arg.FirstName == null ? string.Empty : arg.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", arg.LastName == null ? string.Empty : arg.LastName));
                cmd.Parameters.Add(new SqlParameter("@ShipperId", arg.ShipperId == null ? string.Empty : arg.ShipperId));
                cmd.Parameters.Add(new SqlParameter("@OrderDate", arg.OrderDate == null ? string.Empty : arg.OrderDate));
                cmd.Parameters.Add(new SqlParameter("@ShippedDate", arg.ShippedDate == null ? string.Empty : arg.ShippedDate));
                cmd.Parameters.Add(new SqlParameter("@RequireDdate", arg.RequireDdate == null ? string.Empty : arg.RequireDdate));

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }


            return this.MapOrderDataToList(dt);
        }

        private List<Models.Employee> MapOrderDataToList(DataTable orderData)
        {
            List<Models.Order> result = new List<Order>();

            foreach (DataRow row in orderData.Rows)
            {
                result.Add(new Order()
                {
                    EmployeeId = row["CustomerID"].ToString(),
                    CustName = row["CustName"].ToString(),
                    EmpId = (int)row["EmployeeID"],
                    EmpName = row["EmpName"].ToString(),
                    Freight = (decimal)row["Freight"],
                    OrderDate = row["OrderDate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["OrderDate"],
                    OrderId = (int)row["OrderId"],
                    RequiredDate = row["RequireDdate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["RequiredDate"],
                    ShipAddress = row["ShipAddress"].ToString(),
                    ShipCity = row["ShipCity"].ToString(),
                    ShipCountry = row["ShipCountry"].ToString(),
                    ShipName = row["ShipName"].ToString(),
                    ShippedDate = row["ShippedDate"] == DBNull.Value ? (DateTime?)null : (DateTime)row["ShippedDate"],
                    ShipperId = (int)row["ShipperId"],
                    ShipperName = row["ShipperName"].ToString(),
                    ShipPostalCode = row["ShipPostalCode"].ToString(),
                    ShipRegion = row["ShipRegion"].ToString()
                });
            }
            return result;
        }*/
    }
}