using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{ 
    //             ClassSyntax
    // <Class modifier> class <class name>
    //<Class modifier> -> public, internal (default)
    public class Employee
    {
        // constant      -> < access modifier >  const < data type > <constant name> = < initial value>;
        public static double TAX = 0.03;

        // Fieles      -> < access modifier > < data type > <field name> = < initial value>;
        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        private double CalculateSalary() => Wage * LoggedHours;
        private double CalculateTax () => CalculateSalary() * TAX;
        private double CalculateNet() => CalculateSalary() * CalculateTax();

        public string PrintSlip()
        {
            return $@" First Name: {FName} 
Last Name: {LName}  
Wage : {Wage} 
Logged Hours: {LoggedHours} 
----------------------------------
salary : ${CalculateSalary()}
Deducatble tax ({TAX * 100}%), Amount: ${CalculateTax()}
Net salary : {CalculateNet()} ";
        }

    }
}
