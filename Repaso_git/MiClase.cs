namespace Repaso_git;

public class MiClase
{
    private const decimal DESC20 = 0.8m;
    private const decimal DESC10 = 0.9m;
    private const decimal DESC5 = 0.95m;
    public decimal Calcular(decimal total, int tipoCliente, bool esVIP) {
        
        if (tipoCliente == 1)
        {
            if (esVIP) return total * DESC20;
            return total * DESC10;
        }

        if (tipoCliente == 2) return total * DESC5;
        return total;
    }
}