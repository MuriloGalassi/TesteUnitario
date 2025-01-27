using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {  
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10Eretornar15()
    {
        //Arrenge
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
}
