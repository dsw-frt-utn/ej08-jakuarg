using System;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        //1.copiar originalValue en una variable local
        int copiaValue = originalValue;

        //2.incrementar la copia solamente
        copiaValue++;

        //3.copiar la ref de product en otra variable local
        Product productoCopiado = product;

        //4.modificar la desc del producto mediante el met disponible
        productoCopiado.Description = productoCopiado.Description + " - Modificado";

        //5.retornar la cadena con el formato...
        return $"{originalValue}-{copiaValue}-{productoCopiado.Description}";
    }
}
