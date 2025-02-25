using System;

class Producto 
{
    public string Nombre { get; set;}
    public double Precio {get; set;}
    public int Codigo {get; set;}

    public Producto(string nombre, double precio, int codigo)

    {
        Nombre = nombre;
        Precio = precio;
        Codigo = codigo;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Precio: {Precio}, codigo: {Precio:C}";
    }

    class Tienda
    {
        private Producto Producto1;
        private Producto Producto2;
        private Producto Producto3;
    }

    public Tienda(Producto producto1, Producto producto2, Producto producto3)
    {
        producto1 = producto1;
        producto2 = producto2;
        producto3 = producto3;
    }



}
