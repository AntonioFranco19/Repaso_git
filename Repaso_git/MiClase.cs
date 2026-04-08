namespace Repaso_git;

public class MiClase
{
    public decimal Calcular(decimal total, int tipoCliente, bool esVIP) {
        decimal final = 0;
        if (tipoCliente == 1) {
            if (esVIP) {
                final = total * 0.8m;
            } else {
                final = total * 0.9m;
            }
        } else if (tipoCliente == 2) {
            final = total * 0.95m;
        } else {
            final = total;
        }
        return final;
    }
}