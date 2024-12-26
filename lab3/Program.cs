using System;
using System.Collections.Generic;

public interface ITetrisFigure
{
    void Display();
}

public class Square : ITetrisFigure
{
    public void Display()
    {
        Console.WriteLine("Фигура: Квадрат (2x2)");
    }
}

public class Line : ITetrisFigure
{
    public void Display()
    {
        Console.WriteLine("Фигура: Линия (4x1)");
    }
}

public class TShape : ITetrisFigure
{
    public void Display()
    {
        Console.WriteLine("Фигура: Т-образная (3x2)");
    }
}

public class SuperSquare : ITetrisFigure
{
    public void Display()
    {
        Console.WriteLine("Супер-фигура: Большой квадрат (4x4)");
    }
}

public class SuperLine : ITetrisFigure
{
    public void Display()
    {
        Console.WriteLine("Супер-фигура: Большая линия (6x1)");
    }
}

public abstract class TetrisFigureCreator
{
    public abstract ITetrisFigure FactoryMethod();
}

public class SquareCreator : TetrisFigureCreator
{
    public override ITetrisFigure FactoryMethod() => new Square();
}

public class LineCreator : TetrisFigureCreator
{
    public override ITetrisFigure FactoryMethod() => new Line();
}

public class TShapeCreator : TetrisFigureCreator
{
    public override ITetrisFigure FactoryMethod() => new TShape();
}

public class SuperSquareCreator : TetrisFigureCreator
{
    public override ITetrisFigure FactoryMethod() => new SuperSquare();
}

public class SuperLineCreator : TetrisFigureCreator
{
    public override ITetrisFigure FactoryMethod() => new SuperLine();
}

public class TetrisGame
{
    private static readonly List<TetrisFigureCreator> creators = new()
    {
        new SquareCreator(),
        new LineCreator(),
        new TShapeCreator(),
        new SuperSquareCreator(),
        new SuperLineCreator()
    };

    private static readonly Random random = new();

    public ITetrisFigure GetRandomFigure()
    {
        int index = random.Next(creators.Count);
        return creators[index].FactoryMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var game = new TetrisGame();

        Console.WriteLine("Создание случайных фигур для игры Тетрис:\n");

        for (int i = 0; i < 5; i++)
        {
            var figure = game.GetRandomFigure();
            figure.Display();
        }
    }
}