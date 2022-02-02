using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollSystem
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public EmployeeDetails(int EmployeeId, string EmployeeName, string PhoneNumber, string Address, string Department,
            char Gender, double BasicPay, double Deduction, double TaxablePay, double Tax, double NetPay, string City, string Country, int EmployeeID)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
            this.City = City;
            this.Country = Country;
        }

        public EmployeeDetails(int EmployeeId, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, int BasicPay, int Deduction, int TaxablePay, int Tax, int NetPay, string City, string Country)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
            this.City = City;
            this.Country = Country;
        }
    }
}