using System;

// Classe base abstrata (com abstração)
abstract class Forma
{
    public abstract double CalcularArea(); // Método abstrato para abstração
}

// Subclasse que herda de Forma
class Retangulo : Forma
{
    private double baseRetangulo;
    private double altura;

    public Retangulo(double Base, double Altura)
    {
        baseRetangulo = Base;
        altura = Altura;
    }

    public override double CalcularArea()
    {
        return baseRetangulo * altura;
    }
}

// Subclasse que herda de Forma
class Circulo : Forma
{
    private double raio;

    public Circulo(double Raio)
    {
        raio = Raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * raio * raio;
    }
}

class Program
{
    static void Main()
    {
        // Criar uma forma de retângulo
        Retangulo retangulo = new Retangulo(5.0, 4.0);

        // Calcular e imprimir a área do retângulo
        Console.WriteLine("Área do Retângulo: " + retangulo.CalcularArea());

        // Criar uma forma de círculo
        Circulo circulo = new Circulo(3.0);

        // Calcular e imprimir a área do círculo
        Console.WriteLine("Área do Círculo: " + circulo.CalcularArea());
    }
}
