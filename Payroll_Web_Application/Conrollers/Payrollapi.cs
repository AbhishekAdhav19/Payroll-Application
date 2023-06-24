using Microsoft.AspNetCore.Mvc;
using Payroll;
using System.Collections;

namespace Payroll_Web_Application.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class PayrollApiController : ControllerBase
    {
        [HttpPost]
        public ArrayList AddEmployee()
        {
            string emp_name = Request.Form["emp_name"];
            string form_salary = Request.Form["basic_salary"];
            string emp_type = Request.Form["emp_type"];

            int basic_salary = int.Parse(form_salary);

            ArrayList employees = new ArrayList();

            if (emp_type == "pro" && emp_name != null)
            {
                Programmer pro = new Programmer(emp_name, basic_salary);
                employees.Add(pro);
            }
            else if (emp_type == "man" && emp_name != null)
            {
                Manager man = new Manager(emp_name, basic_salary);
                employees.Add(man);
            }
            else if (emp_type == "exec" && emp_name != null)
            {
                Sale_Exe exec = new Sale_Exe(emp_name, basic_salary);
                employees.Add(exec);
            }

            return employees;
        }
    }
}

