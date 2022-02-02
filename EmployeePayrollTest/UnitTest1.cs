using EmployeePayrollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh1", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh2", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh3", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india")); employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh4", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh5", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh6", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh7", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh8", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));

            EmployeePayrollOperation employeePayRollOperation = new EmployeePayrollOperation();
            //employeePayRollOperation.addEmployeeToPayroll(employeeDetails);
            employeePayRollOperation.addEmployeeToPayrollWithThread(employeeDetails);
        }
    }
}