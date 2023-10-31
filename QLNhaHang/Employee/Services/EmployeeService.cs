using Form1.Employee.Model;
using System.Data;

namespace Form1.Employee.Services
{
    public class EmployeeService
    {
        public EmployeeService() { }
        public void ShowListEmployee(DataGridView dgv)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.ShowListEmployee(dgv);
        }

        public void ShowNameEmployee(ComboBox cb)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.ShowNameEmployee(cb);
        }

        public void GetIdEmployee(TextBox txt, string? name)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.GetIdEmployee(txt, name);
        }

        public string CreateEmployee(string? id, string? name, string? sex, string? date, string? numphone, string? role, int salary)
        {
            EmployeeModel employee = new EmployeeModel(id, name, sex, date, numphone, role, salary);
            return employee.CreateEmployee();
        }

        public string UpdateEmployee(string? id, string? name, string? sex, string? date, string? numphone, string? role, int salary)
        {
            EmployeeModel employee = new EmployeeModel(id, name, sex, date, numphone, role, salary);
            return employee.UpdateEmployee();
        }

        public string DeleteEmployee(string? id)
        {
            EmployeeModel employee = new EmployeeModel(id);
            return employee.DeleteEmployee();
        }
    }
}
