using System;

public class Problema2
{

    public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
    {
        decimal totalCalculado = 0;

        if (quantity >= 0) { totalCalculado = quantity * unitPrice; }

        var resumenVenta = new
        {
            Code = productCode,
            Description = productDescription,
            Quantity = quantity,
            Total = totalCalculado
        };

        return $"{resumenVenta.Code} - {resumenVenta.Description} - {resumenVenta.Total:C2}";
    }
}
