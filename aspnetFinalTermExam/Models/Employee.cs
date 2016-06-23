using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace aspnetFinalTermExam.Models
{
    public class Employee
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工編號")]
        public int EmployeeID { get; set; }

        /// <summary>
        /// 員工名字
        /// </summary>
        [DisplayName("員工姓名(Last Name)")]
        public String LastName { get; set; }

        /// <summary>
        /// 員工姓氏
        /// </summary>
        [DisplayName("員工姓名(First Name)")]
        public String FirstName { get; set; }

        /// <summary>
        /// 職稱編號
        /// </summary>
        [DisplayName("職稱編號")]
        public String Title { get; set; }

        /// <summary>
        /// 員工職稱
        /// </summary>
        [DisplayName("職稱")]
        public String TitleOfCourtesy { get; set; }

        /// <summary>
        /// 員工生日
        /// </summary>
        [DisplayName("生日")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
        [DisplayName("任職日期")]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// 員工地址
        /// </summary>
        [DisplayName("地址")]
        public String Address { get; set; }

        /// <summary>
        /// 員工城市
        /// </summary>
        [DisplayName("城市")]
        public String City { get; set; }

        /// <summary>
        /// 員工地區
        /// </summary>
        [DisplayName("地區")]
        public String Region { get; set; }

        /// <summary>
        /// 員工國家
        /// </summary>
        [DisplayName("國家")]
        public String Country { get; set; }

        /// <summary>
        /// 員工電話
        /// </summary>
        [DisplayName("電話")]
        public String Phone { get; set; }

        /// <summary>
        /// 直屬主管編號
        /// </summary>
        [DisplayName("直屬主管")]
        public int ManagerID { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("性別")]
        public String Gender { get; set; }

        /// <summary>
        /// 員工月薪
        /// </summary>
        [DisplayName("月薪")]
        public int MonthlyPayment { get; set; }

        /// <summary>
        /// 員工年薪
        /// </summary>
        [DisplayName("月薪")]
        public int YearlyPayment { get; set; }

    }
}