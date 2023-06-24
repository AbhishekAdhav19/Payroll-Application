using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;

namespace TestCase
{
    [TestClass]
    public class PayrollTests
    {
        [TestMethod]
        public void TestProgrammerSalaryCalculation()
        {
            // Arrange
            decimal expectedSalary = 4250m;
            Programmer programmer = new Programmer("John Doe", 5000m);

            // Act
            decimal actualSalary = programmer.Calculate_Salary();

            // Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestManagerSalaryCalculation()
        {
            // Arrange
            decimal expectedSalary = 7200m;
            Manager manager = new Manager("Jane Smith", 8000m);

            // Act
            decimal actualSalary = manager.Calculate_Salary();

            // Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestSaleExeSalaryCalculation()
        {
            // Arrange
            decimal expectedSalary = 5700m;
            Sale_Exe saleExe = new Sale_Exe("Michael Johnson", 6000m);

            // Act
            decimal actualSalary = saleExe.Calculate_Salary();

            // Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }
    }
}
