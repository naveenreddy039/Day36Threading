using System;
using System.Collections.Generic;

namespace EmployeePayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh1", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 2, EmployeeName: "dinesh2", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 3, EmployeeName: "dinesh3", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india")); employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "dinesh", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 4, EmployeeName: "dinesh4", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 5, EmployeeName: "dinesh5", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 6, EmployeeName: "dinesh6", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 7, EmployeeName: "dinesh7", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 8, EmployeeName: "dinesh8", PhoneNumber: "7702053175", Address: "electrinicCity", Department: "HR", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));

            EmployeePayrollOperation employeePayRollOperation = new EmployeePayrollOperation();
            //employeePayRollOperation.addEmployeeToPayroll(employeeDetails);
            employeePayRollOperation.addEmployeeToPayrollWithThread(employeeDetails);
        }
    }
}