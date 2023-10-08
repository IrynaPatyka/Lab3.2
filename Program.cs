using System;
class Parent
{
    protected double Pole1;
    protected double Pole2;

    public Parent()
    {
        Pole1 = 0;
        Pole2 = 0;
    }

    public Parent(double pole1, double pole2)
    {
        Pole1 = pole1;
        Pole2 = pole2;
    }

    public virtual void Print(bool showDiagonals = true)
    {
        if (showDiagonals)
        {
            Console.WriteLine($"d1={Pole1}");
            Console.WriteLine($"d2={Pole2}");
        }
    }

    public double Metod1()
    {
        return 0.5 * Pole1 * Pole2;
    }

    public double Metod2()
    {
        return Math.Sqrt(0.5 * Pole1 * Pole1 + 0.5 * Pole2 * Pole2);
    }
}

class Child : Parent
{
    public Child(double diagonal)
        : base(diagonal, diagonal)
    {
    }
    public double Metod3()
    {
        return 0.25 * Math.PI * Pole1 * Pole1;
    }

    public double Metod4()
    {
        return Math.PI * Pole1;
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();
        double diagonal1, diagonal2;

        for (int i = 0; i < 5; i++)
        {
            diagonal1 = random.Next(1, 11);
            diagonal2 = random.Next(1, 11);

            Console.WriteLine($"d1={diagonal1} d2={diagonal2}");


            if (diagonal1 == diagonal2)
            {
                Child child = new Child(diagonal1);
                Console.WriteLine($"Квадрат:Площа вписаного кола: {child.Metod3()} Довжина вписаного кола: {child.Metod4()}");
            }
            else
            {
                Parent parent = new Parent(diagonal1, diagonal2);
                Console.WriteLine($"Ромб:Площа:{parent.Metod1()} Сторона:{parent.Metod2()}");

            }

            Console.WriteLine();
        }
    }
}