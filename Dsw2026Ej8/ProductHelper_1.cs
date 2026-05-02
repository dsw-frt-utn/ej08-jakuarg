using System;

public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        return $"[{code}] {description} - {FormatearMoneda(price)}";
    }
}
