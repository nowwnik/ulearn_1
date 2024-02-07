using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
  
        bool tooLeft = r1.Left > r2.Left + r2.Width;
        bool tooRight = r2.Left > r1.Left + r1.Width;
        bool tooHigh = r1.Top > r2.Top + r2.Height;
        bool tooLow = r2.Top > r1.Top + r1.Height;
        return !(tooLeft || tooRight || tooHigh || tooLow);
    }

    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        if (!AreIntersected(r1, r2)) return 0;
        else if ((r1.Left <= r2.Left) && (r1.Top <= r2.Top))
            return Math.Min((r1.Top + r1.Height - r2.Top), Math.Min(r1.Height, r2.Height)) * Math.Min((r1.Left + r1.Width - r2.Left), Math.Min(r1.Width, r2.Width));
        else if ((r1.Left <= r2.Left) && (r2.Top <= r1.Top))
            return Math.Min((r1.Left + r1.Width - r2.Left), Math.Min(r1.Width, r2.Width)) * Math.Min((r2.Top + r2.Height - r1.Top), Math.Min(r1.Height, r2.Height));
        else if ((r2.Left <= r1.Left) && (r2.Top <= r1.Top))
            return Math.Min((r2.Top + r2.Height - r1.Top), Math.Min(r1.Height, r2.Height)) * Math.Min((r2.Left + r2.Width - r1.Left), Math.Min(r1.Width, r2.Width));
        else return Math.Min((r2.Left + r2.Width - r1.Left), Math.Min(r1.Width, r2.Width)) * Math.Min((r1.Top + r1.Height - r2.Top), Math.Min(r1.Height, r2.Height));
    }

    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        if ((r1.Left >= r2.Left) && (r1.Right <= r2.Right) &&
            (r1.Top >= r2.Top) && (r1.Bottom <= r2.Bottom)) return 0;
        else if ((r2.Left >= r1.Left) && (r2.Right <= r1.Right) &&
            (r2.Top >= r1.Top) && (r2.Bottom <= r1.Bottom)) return 1;
        else return -1;
    }
}