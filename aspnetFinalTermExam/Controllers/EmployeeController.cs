using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetFinalTermExam.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        Models.CodeService codeService = new Models.CodeService();
        Models.EmployeeService employeeService = new Models.EmployeeService();

        /// <summary>
        /// 訂單查詢系統
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.EmpCodeData = this.codeService.GetEmp();
            ViewBag.EmpTitleData = this.codeService.GetEmpTitle();
            return View();
        }

        /// <summary>
        /// 訂單查詢結果
        /// </summary>
        /// <param name="sorder"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult SearchOrder(Models.SearchArg sorder)
        {
            ViewBag.EmpCodeData = this.codeService.GetEmp();
            //ViewBag.SearchResult = employeeService.GetEmpByCondtioin(sorder);
            return View("SearchOrder");
        }
    }
}