using System;
class HelloWorld
{
    static void Main()
    {
        //1
        //int a = 6; 
        //int b = 2;
        //Console.WriteLine("Сумма: " + (a + b));
        //Console.WriteLine();
        //Console.WriteLine("Разность: " + (a - b));
        //Console.WriteLine();
        //Console.WriteLine("Произведение: " + (a * b));
        //Console.WriteLine();
        //Console.WriteLine("Частное: " + (a / b));

        //2
        //double l;
        //l = Convert.ToDouble(Console.ReadLine());
        //double s, r;
        //r = l / (2 * 3.14);
        //s = 3.14 * r * r;
        //Console.WriteLine("S={0}  ", s);

        //3
        //int a = 6;
        //int b = 2;
        //double avgSquares = (Math.Pow(a, 2) + Math.Pow(b, 2)) / 2.0;
        //double avgAbs = (Math.Abs(a) + Math.Abs(b)) / 2.0;
        //Console.WriteLine("Среднее арифметическое квадратов чисел: " + avgSquares);
        //Console.WriteLine("Среднее арифметическое модулей чисел: " + avgAbs);

        //4
        //double plohad = 50;
        //double radius = Math.Sqrt(plohad / Math.PI);
        //double dlina = 2 * Math.PI * radius;
        //Console.WriteLine("Длина окружности: " + dlina);

        //5
        //double V = 20; // скорость лодки в стоячей воде
        //double U = 5; // скорость течения реки
        //double T1 = 2; // время движения лодки по озеру
        //double T2 = 3; // время движения лодки против течения
        //double distance = CalculatePathLength(V, U, T1, T2);
        //Console.WriteLine("Пройденное расстояние: " + distance + " км");

        //static double CalculatePathLength(double V, double U, double T1, double T2)
        //{
        //    double pathOnLake = V * T1; // путь по озеру
        //    double pathAgainstCurrent = (V - U) * T2; // путь против течения

        //    double totalPath = pathOnLake + pathAgainstCurrent; // общий пройденный путь

        //    return totalPath;
        //}

        //6
        //double a = 8; 
        //double b = 6; 
        //double alpha = Math.PI / 4;
        //double h = Math.Tan(alpha) * (a - b) / 2; 
        //double perimeter = a + b + 2 * Math.Sqrt(h * h + Math.Pow((a - b) / 2, 2)); 
        //double area = (a + b) * h / 2; 
        //Console.WriteLine("Периметр трапеции: " + perimeter);
        //Console.WriteLine("Площадь трапеции: " + area);

        //7
        //double V1 = 60; 
        //double V2 = 40; 
        //double S = 100; 
        //double T = 2; 
        //double finalDistance = DistanceBetweenCars(V1, V2, S, T);
        //Console.WriteLine("Расстояние между автомобилями через " + T + " часов: " + finalDistance + " км");

        //static double DistanceBetweenCars(double V1, double V2, double S, double T)
        //{
        //    double distance = S + (V1 + V2) * T;

        //    return distance;
        //}

        //8
        //double a = 8; 
        //double b = 6; 
        //double alpha = Math.PI / 4; 
        //double h = (a - b) / 2 * Math.Tan(alpha); 

        //double perimeter = a + b + 2 * h / Math.Cos(alpha); 
        //double area = (a + b) * h / 2; 

        //Console.WriteLine("Периметр трапеции: " + perimeter);
        //Console.WriteLine("Площадь трапеции: " + area);


        //9
        //double V1 = 60;
        //double V2 = 60;
        //double S = 100;
        //double T = 0.5;
        //double finalDistance = DistanceBetweenCars(V1, V2, S, T);
        //Console.WriteLine("Расстояние между автомобилями через " + T + " часов: " + finalDistance + " км");

        //static double DistanceBetweenCars(double V1, double V2, double S, double T)
        //{
        //    double distance = S - (V1 + V2) * T;

        //    return distance;
        //}



        //10
        //double x1 = 1;
        //double y1 = 2;
        //double x2 = 4;
        //double y2 = 6;

        //double distance = CalculateDistance(x1, y1, x2, y2);

        //Console.WriteLine("Расстояние между точками: " + distance);


        //static double CalculateDistance(double x1, double y1, double x2, double y2)
        //{
        //    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //    return distance;
        //}


        //11
        //double a = 3; 
        //double b = 4; 

        //double c = Math.Sqrt(a * a + b * b); 
        //double perimeter = a + b + c; 
        //double area = 0.5 * a * b; 

        //Console.WriteLine("Периметр прямоугольного треугольника: " + perimeter);
        //Console.WriteLine("Площадь прямоугольного треугольника: " + area);

        //12

        //double x1 = 1, y1 = 1; 
        //double x2 = 4, y2 = 5; 
        //double x3 = 7, y3 = 1; 

        //double a = Distance(x1, y1, x2, y2);
        //double b = Distance(x2, y2, x3, y3);
        //double c = Distance(x3, y3, x1, y1);

        //double perimeter = TrianglePerimeter(a, b, c);
        //double area = TriangleArea(a, b, c);

        //Console.WriteLine("Периметр треугольника: " + perimeter);
        //Console.WriteLine("Площадь треугольника: " + area);

        //static double Distance(double x1, double y1, double x2, double y2)
        //{
        //    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //}

        //static double TrianglePerimeter(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //static double TriangleArea(double a, double b, double c)
        //{
        //    double p = (a + b + c) / 2;
        //    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        //}




        //13
        //double circleArea = 50; 
        //double radius = Math.Sqrt(circleArea / Math.PI);
        //double circumference = 2 * Math.PI * radius; 

        //Console.WriteLine("Длина окружности: " + circumference);


        //14
        //double A = 1; 
        //double B = -5; 
        //double C = 6; 

        //double discriminant = B * B - 4 * A * C; 
        //if (discriminant >= 0)
        //{
        //    double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A); 
        //    double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);

        //    Console.WriteLine("Первый корень: " + x1);
        //    Console.WriteLine("Второй корень: " + x2);
        //}
        //else
        //{
        //    Console.WriteLine("Дискриминант отрицателен, корни не могут быть найдены.");
        //}



        //15
        //double radius = 5; 

        //double circumference = 2 * Math.PI * radius; 
        //double area = Math.PI * Math.Pow(radius, 2); 

        //Console.WriteLine("Длина окружности: " + circumference);
        //Console.WriteLine("Площадь круга: " + area);



        //16

        //double A1 = 2, B1 = 3, C1 = 8;
        //double A2 = 4, B2 = 5, C2 = 9;

        //double determinant = A1 * B2 - A2 * B1;
        //if (determinant != 0)
        //{
        //    double x = (C1 * B2 - C2 * B1) / determinant;
        //    double y = (A1 * C2 - A2 * C1) / determinant;

        //    Console.WriteLine("Решение: x = " + x + ", y = " + y);
        //}
        //else
        //{
        //    Console.WriteLine("Система уравнений не имеет единственного решения.");
        //}

        //17


        //double R1 = 3; 
        //double R2 = 5; 

        //double ringArea = CalculateRingArea(R1, R2);

        //Console.WriteLine("Площадь кольца: " + ringArea);

        //static double CalculateRingArea(double R1, double R2)
        //{
        //    double area = Math.PI * (R2 * R2 - R1 * R1); 

        //    return area;
        //}



        //18
        //int number = 1234; 

        //int sum = 0;
        //sum += number / 1000 % 10; 
        //sum += number / 100 % 10;  
        //sum += number / 10 % 10;   
        //sum += number % 10;        
        int fg = 6;
        //Console.WriteLine("Сумма цифр числа " + number + " равна: " + sum);


        //19
        //double a = 5;

        //double perimeter = 3 * a; 
        //double area = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);

        //Console.WriteLine("Периметр равностороннего треугольника: " + perimeter);
        //Console.WriteLine("Площадь равностороннего треугольника: " + area);

        //20 
        //int number = 1234; 

        //int sum = (number / 1000) % 10 + (number / 100) % 10 + (number / 10) % 10 + number % 10;

        //Console.WriteLine("Сумма цифр числа " + number + " равна: " + sum);
    }
}