using System;

public partial class ProductHelper
{
    private string FormatearMoneda(decimal valor) => valor.ToString("C", CultureInfo.CurrentCulture);
}
