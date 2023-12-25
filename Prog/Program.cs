namespace Prog
 {
     internal class Program
     {
         static void throwing(Byte a)
         {
             if (a != 3 && a != 4 && a != 5) { throw new ArgumentException(); }
         }
         public static int Main(string[] args)
         { 
             //N1
             Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных C#:");

             Console.WriteLine(
                 $"sbyte: минимальное значение = {sbyte.MinValue}, максимальное значение = {sbyte.MaxValue}");
             Console.WriteLine($"byte: минимальное значение = {byte.MinValue}, максимальное значение = {byte.MaxValue}");
             Console.WriteLine(
                 $"short: минимальное значение = {short.MinValue}, максимальное значение = {short.MaxValue}");
             Console.WriteLine(
                 $"ushort: минимальное значение = {ushort.MinValue}, максимальное значение = {ushort.MaxValue}");
             Console.WriteLine($"int: минимальное значение = {int.MinValue}, максимальное значение = {int.MaxValue}");
             Console.WriteLine($"uint: минимальное значение = {uint.MinValue}, максимальное значение = {uint.MaxValue}");
             Console.WriteLine($"long: минимальное значение = {long.MinValue}, максимальное значение = {long.MaxValue}");
             Console.WriteLine(
                 $"ulong: минимальное значение = {ulong.MinValue}, максимальное значение = {ulong.MaxValue}");

             Console.WriteLine(
                 $"float: минимальное значение = {float.MinValue}, максимальное значение = {float.MaxValue}");
             Console.WriteLine(
                 $"double: минимальное значение = {double.MinValue}, максимальное значение = {double.MaxValue}");
             Console.WriteLine(
                 $"decimal: минимальное значение = {decimal.MinValue}, максимальное значение = {decimal.MaxValue}");

             Console.WriteLine(
                 $"char: минимальное значение = {(int)char.MinValue}, максимальное значение = {(int)char.MaxValue}");

             Console.WriteLine(
                 $"DateTime: минимальное значение = {DateTime.MinValue}, максимальное значение = {DateTime.MaxValue}");
             
             //N2
             Console.WriteLine("------------------------");
             Console.WriteLine("2 Задание");
             Console.WriteLine($"enter side1");
             double side1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine($"enter side2");
             double side2 = Convert.ToDouble(Console.ReadLine());
             Rect rectangle = new Rect(side1, side2);
             Console.WriteLine($"Area: {rectangle.Area} Perimetr: {rectangle.Perimeter}");
          
             //N3
             Console.WriteLine("------------------------");
             Console.WriteLine("3 Задание");
             Console.WriteLine("Введите количество вершин фигуры:");
             Byte DotsCount = Convert.ToByte(Console.ReadLine());
             try
             {
                 throwing(DotsCount);
             }
             catch (ArgumentException)
             {
                 Console.WriteLine("Давайте что-нибудь попроще");
                 return -1;
             }
             
             Console.WriteLine("Введите координаты точки А:");
             int Ax = Convert.ToInt32(Console.ReadLine());
             int Ay = Convert.ToInt32(Console.ReadLine());
             Point A = new Point(Ax, Ay);
             Console.WriteLine("Введите координаты точки B:");
             int Bx = Convert.ToInt32(Console.ReadLine());
             int By = Convert.ToInt32(Console.ReadLine());
             Point B = new Point(Bx, By);
             Console.WriteLine("Введите координаты точки C:");
             int Cx = Convert.ToInt32(Console.ReadLine());
             int Cy = Convert.ToInt32(Console.ReadLine());
             Point C = new Point(Cx, Cy);
             Figure figure;
             if (DotsCount == 3) { figure = new Figure(A, B, C); }
             else
             {
                 Console.WriteLine("Введите координаты точки D:");
                 int Dx = Convert.ToInt32(Console.ReadLine());
                 int Dy = Convert.ToInt32(Console.ReadLine());
                 Point D = new Point(Dx, Dy);
                 if (DotsCount == 4) { figure = new Figure(A, B, C, D); }
                 else
                 {
                     Console.WriteLine("Введите координаты точки E:");
                     int Ex = Convert.ToInt32(Console.ReadLine());
                     int Ey = Convert.ToInt32(Console.ReadLine());
                     Point E = new Point(Ex, Ey);
                     figure = new Figure(A, B, C, D, E);
                 }
             }
             Console.WriteLine($"Периметр {figure.Name}a = {figure.PerimeterCalculator()}");
             return 0;
         }
     }
 }