using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

        public void addEmployeeToPayroll(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being Added:" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee addes:" + employeeData.EmployeeName);
            }
              );

            Console.WriteLine(this.employeeDetails.ToString());


        }
        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being Added:" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee addes:" + employeeData.EmployeeName);
                }
                  );
                thread.Start();
            }
              );
        }

    }
}
