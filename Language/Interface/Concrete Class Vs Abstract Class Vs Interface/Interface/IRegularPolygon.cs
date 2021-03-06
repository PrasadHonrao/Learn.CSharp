﻿namespace Learn.CSharp.Language
{
    public interface IRegularPolygon
    {
        int SideLength { get; }
        int NumberOfSides { get;}

        double GetArea();
        double GetPerimeter();
    }
}
