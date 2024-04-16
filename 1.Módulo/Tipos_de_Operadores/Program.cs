// Tipos de operadores
// atribuição (=)

// int a = 10;
// int b = 20;
// int c = a + b;

// c += 5;  
// Console.WriteLine(c);

// c -= 5;
// Console.WriteLine(c);

// c *= 5;
// Console.WriteLine(c);

// Convertendo um tipo string para inteiro | existem duas formas: 

// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// int a = int.Parse("5");
// Console.WriteLine(a);

// int b = Convert.ToInt32(null);
// Console.WriteLine($"{a}, {b}");

//Convertendo um tipo inteiro para string 

// int c = 32;
// string d = c.ToString();
// Console.WriteLine(d);

// Casting implicito

int a = 5;
double b = a; // não dá erro pois o double suporta int, daria erro se fosse o contrário pois pode existir um valor de double que o int não suporta (necessário conversão)
Console.WriteLine(b);
