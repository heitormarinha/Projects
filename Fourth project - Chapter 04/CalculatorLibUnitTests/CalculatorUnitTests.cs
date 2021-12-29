// I am importing the Packt namespace type.
using Packt;
using Xunit;

namespace CalculatorLibUnitTests;

public class UnitTest1
{
    [Fact]
    public void TestAdding2and2()
    {
        // Arrange.
        double a = 2;// I am declaring a variable with double type, ID name a and I am assigning it with literal value 2. 
        double b = 2; // The same action did in an.
        double expected  = 4; // I am declaring a variable with double type, ID name expected and assigning it with 4.
        var calculator = new Calculator(); // Writing a object with Calculator type.

        // Act.
        double actual = calculator.Add(a,b); // Declaring a variable with double type, ID name actual and assigning it with the value returned of calculator.add method of Calculator.

        //Assert
        Assert.Equal(expected, actual); // Function of Xunit type and ivocated the Equal method that have two parameters and need be passed with argument the expected argument and the real value of test.

    } // End of TestAdding2and2 test.
} // End of UnitTest1 class.