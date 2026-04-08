namespace Repaso_git;

public class MiClase
{
    private const decimal DESC20 = 0.8m;
    private const decimal DESC10 = 0.9m;
    private const decimal DESC5 = 0.95m;
    
    /// <summary>
    /// Calcula el precio
    /// </summary>
    /// <param name="total">base del precio</param>
    /// <param name="tipoCliente">tipo de cliente</param>
    /// <param name="esVIP">si el cliente es vip</param>
    /// <returns></returns>
    public decimal Calcular(decimal total, int tipoCliente, bool esVIP) {
        
        if (tipoCliente == 1)
        {
            if (esVIP) return total * DESC20;
            string chiste = "Jaja, es gracioso porque te he generado conflictos";
            return total * DESC10;
        }

        if (tipoCliente == 2) return total * DESC5;
        return total;
    }
}
