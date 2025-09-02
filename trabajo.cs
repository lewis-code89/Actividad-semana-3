//Ejercicio

Console.WriteLine("Bienvenido");
Console.WriteLine("Calculare tu promnedio final");
Console.Write("Ingrese su primera nota: ");
double t1 = Convet.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el peso de la primera nota: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese su segunda nota: ");
double t2 = Convet.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el peso de su segunda nota: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese su tercera nota: ");
double t3 = Convet.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el peso de su tercera nota: ");
double z = Convert.ToDouble(Console.ReadLine());

double notap1 = t1 * (x / 100);
double notap2 = t2 * (y / 100);
double notap3 = t3 * (z / 100);

double promediofinal = (notap1 + notap2 + notap3);

Console.WriteLine("Tu promedio final es " + promediofinal + " :D");
