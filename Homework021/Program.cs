System.Console.WriteLine("Введите координаты точки А по оси Х: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B по оси Х: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси Z: ");
int zB = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
System.Console.WriteLine("Расстояние между точками составляет:");
System.Console.WriteLine(distance);