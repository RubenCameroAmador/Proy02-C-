namespace Geometria
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cuadrado cuad = new Cuadrado();
            cuad.lado = 10;
            cuad.Nombre = "Mi cuadradito";
            cuad.LineColor = "#F00000";
            Console.WriteLine($"Nombre: {cuad.Nombre}");
            Console.WriteLine($"Id:     {cuad.Id}");
            Console.WriteLine($"Lado:   {cuad.lado} ");
            Console.WriteLine($"Área:   {cuad.getSize()}");
            Console.WriteLine($"Perímetro:   {cuad.getPerimetro()}");

            Triangulo tri = new Triangulo();
            tri.lado1 = 5;
            tri.lado2 = 3;
            tri.lado3 = 4;
            tri.Nombre = "Mi triagunlo";
            Console.WriteLine($"Nombre: {tri.Nombre}");
            Console.WriteLine($"Id:     {tri.Id}");
            Console.WriteLine($"Lado1:   {tri.lado1} ");
            Console.WriteLine($"Lado2:   {tri.lado2} ");
            Console.WriteLine($"Lado3:   {tri.lado3} ");
            Console.WriteLine($"Perímetro:   {tri.getPerimetro()}");
            Console.WriteLine($"Área:   {tri.getSize()}");

            List<Figura2D> miLista = new List<Figura2D>();
            miLista.Add(cuad);
            miLista.Add(tri);

            foreach (var item in miLista) //Polimorfismo por inclusion
            {
                Console.WriteLine($" Nombre: {item.Nombre} ");
                Console.WriteLine($" Tamaño: {item.getSize()} "); 
            }

        }
    }
}

