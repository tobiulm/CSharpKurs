using ItSchulungen.CSharpKurs.ClassLibrary;

namespace LibraryTestProject
{
    public class EmployeeTest
    {
        [Fact]
        public void Test_Invalid_Age()
        {
            Employee employee = new Employee();
            var exception = Assert.Throws<EmployeeToYoungException>(() => { employee.DateOfBirth = new DateOnly(2018, 1, 1); });
            Assert.Equal("Mitarbeiter müssen mindestens 16 Jahre alt sein!", exception.Message);
        }
    }
}