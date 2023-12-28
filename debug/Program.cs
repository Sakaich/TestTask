using Geometry.Figures;
using Geometry.Interfaces;

namespace debug;

class Program
{
    static void Main(string[] args)
    {
        var arr = new IHaveArea[4];

        arr[0] = new Circle
        {
            Radius = 3
        };

        arr[2] = new Circle
        {
            Radius = 5
        };

        arr[1] = new Triangle
        {
            A = 1,
            B = 2,
            C = 2
        };

        arr[3] = new Triangle
        {
            A = 3,
            B = 4,
            C = 5
        };

        foreach (var elem in arr)
        {
            Console.WriteLine(elem.GetArea());

            if (elem is Triangle triangle)
            {
                Console.WriteLine(triangle.IsRight());
            }
        }
    }
}