namespace Repaso_git.Tests;

using Xunit;

public class CalculadorDescuentosTests
{
    private readonly MiClase _calculador = new MiClase();

    [Fact]
    public void Calcular_ClienteTipo1_VIP_AplicaVeintePorCiento()
    {
        // Arrange
        decimal total = 100m;
        int tipo = 1;
        bool esVIP = true;

        // Act
        decimal resultado = _calculador.Calcular(total, tipo, esVIP);

        // Assert
        Assert.Equal(80m, resultado);
    }

    [Fact]
    public void Calcular_ClienteTipo1_NoVIP_AplicaDiezPorCiento()
    {
        // Arrange
        decimal total = 100m;
        int tipo = 1;
        bool esVIP = false;

        // Act
        decimal resultado = _calculador.Calcular(total, tipo, esVIP);

        // Assert
        Assert.Equal(90m, resultado);
    }

    [Fact]
    public void Calcular_ClienteTipo2_CualquierEstado_AplicaCincoPorCiento()
    {
        // Arrange
        decimal total = 100m;
        int tipo = 2;
        bool esVIP = false; // El código actual ignora esVIP si tipo es 2

        // Act
        decimal resultado = _calculador.Calcular(total, tipo, esVIP);

        // Assert
        Assert.Equal(95m, resultado);
    }

    [Fact]
    public void Calcular_ClienteTipoDesconocido_NoAplicaDescuento()
    {
        // Arrange
        decimal total = 100m;
        int tipo = 99; // Caso 'else'
        bool esVIP = true;

        // Act
        decimal resultado = _calculador.Calcular(total, tipo, esVIP);

        // Assert
        Assert.Equal(100m, resultado);
    }
}