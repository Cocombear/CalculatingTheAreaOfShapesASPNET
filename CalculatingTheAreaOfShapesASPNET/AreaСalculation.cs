namespace CalculatingTheAreaOfShapesASPNET
{
    public static class AreaСalculation
    {
        private static double CalculatingAreaOfCircle(double radiusCircle) 
        { return((radiusCircle * radiusCircle) * Math.PI); }
        private static double CalculatingAreaOfSquare(double sideSquare)
        { return (sideSquare * sideSquare); }
        private static double CalculatingAreaOfTriangle(double firstSideTriangle, double secondSideTriangle, double thirdSideTriangle) 
        { 
            double semiPerimeter = (firstSideTriangle + secondSideTriangle + thirdSideTriangle) / 2;
            return (Math.Sqrt(semiPerimeter*(semiPerimeter-firstSideTriangle) * 
                                            (semiPerimeter - secondSideTriangle) *
                                            (semiPerimeter - thirdSideTriangle)));
        }
        private static double CalculatingAreaOfTrapeze(double firstTrapezBaseLength, double secondTrapezBaseLength, double trapezHeight)//S = ((AD + BC) / 2) · BH,
        { return (((firstTrapezBaseLength + secondTrapezBaseLength) / 2) * trapezHeight); }
        private static double CalculatingAreaOfCylinder(double cylinderHeight,double radiusCylinder) 
        { return (2 * Math.PI * radiusCylinder * (cylinderHeight + radiusCylinder)); }
        public static string UsingClassMethods(double commonRadius, double commonFirstSide, double commonSecondSide, 
        double commonThirdSide, double commonFirstBaseLength, double commonSecondBaseLength,double commonHeight) 
        {return 
         $"Площадь треугольника:{CalculatingAreaOfTriangle(commonFirstSide, commonSecondSide, commonThirdSide)}\t" +
         $"Площадь квадрата:{CalculatingAreaOfSquare(commonFirstSide)}\t" +
         $"Площадь круга:{CalculatingAreaOfCircle(commonRadius)}\t" + 
         $"Площадь трапеции:{CalculatingAreaOfTrapeze(commonFirstBaseLength, commonSecondBaseLength, commonHeight)}\t" + 
         $"Площадь Цилиндра:{CalculatingAreaOfCylinder(commonHeight, commonRadius)}\t";
        }
    }
}
