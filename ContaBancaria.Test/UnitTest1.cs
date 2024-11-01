using ContaBancaria.Servicos;

namespace ContaBancaria.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(012345, 30000)]
    public void Deve_Depositar_Valor_Na_Conta_Test(int numeroConta, decimal saldo)
    {
        //Arrange
        Conta conta= new Conta(numeroConta, saldo); 
        decimal valorDeposito = 5000; 

        //Act
        decimal resultado = conta.Depositar(numeroConta, valorDeposito);

        //Assert
        Assert.Equal(35000, resultado);
    }

    [Theory]
    [InlineData(12345, 40000)]
    public void Deve_Retirar_Valor_Na_Conta_Test(int numeroConta, decimal saldo)
    {
        //Arrange
        Conta conta= new Conta(numeroConta, saldo);
        decimal valorSaque = 2000;

        //Act
        var resultado = conta.Sacar(numeroConta, valorSaque);

        //Assert
        Assert.Equal(38000, resultado);
    }

    [Theory]
    [InlineData(12345, 4000)]
    public void Deve_Consultar_Saldo_Disponivel_Na_Conta_E_Retornar_O_Saldo(int numeroConta, decimal saldo)
    {
        //Arrange
        Conta conta= new Conta(numeroConta, saldo);

        //Act
        var resultado = conta.ConsultarSaldo();
        //Assert
        Assert.NotEqual(4000, resultado);
    }
}