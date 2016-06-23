using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace aspnetFinalTermExam.Models
{
    public class SearchArg
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工編號")]
        public int EmployeeID { get; set; }

        /// <summary>
        /// 員工名字
        /// </summary>
        [DisplayName("員工姓名")]
        public String LastName { get; set; }

        /// <summary>
        /// 員工姓氏
        /// </summary>
        [DisplayName("員工姓名")]
        public String FirstName { get; set; }

        /// <summary>
        /// 職稱編號
        /// </summary>
        [DisplayName("職稱")]
        public String Title { get; set; }

        /// <summary>
        /// 員工職稱
        /// </summary>
        [DisplayName("職稱")]
        public String TitleOfCourtesy { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
        [DisplayName("任職日期")]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [DisplayName("生日")]
        public DateTime? BirthDate { get; set; }
    }
}