
List<string> listaString = new List<string>(); 

listaString.Add("PE");
listaString.Add("BA");
listaString.Add("RN");


Console.WriteLine("Percorrendo a lista com FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
} 


Console.WriteLine("Percorrendo a lista com FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
}


// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com FOREACH");
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }
