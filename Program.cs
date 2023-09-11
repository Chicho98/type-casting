using System.Runtime.CompilerServices;
string z = "dammm son";
char b = '$';

bool jimmy = false;
double x = 3.14;
Console.WriteLine(x);
int y = Convert.ToInt32(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(jimmy);
Console.Write(b);
Console.WriteLine(jimmy.GetType());
Console.WriteLine(b.ToString());
Console.WriteLine(z);
Console.WriteLine(z.GetType());
Console.WriteLine(x.GetType());
Console.WriteLine(y.GetType());

Console.ReadKey();  

//type casting seria la forma de cambiar de tipo de dato de variables como la opcion tambien de sacar ese dato en crudo
/* por ejemplo para sacar el dato de un tipo de variable se deberia escribir Console.WriteLine(a'nombre de la variable'.GetType(());
 * y para cambiar el tipo de variable se deberia crear otra con el subfijo qe se requiere mas =Convert.ToInt32 para numero
 * ToString para string, ConvertToChar para 1 character, ConvertToDouble para un decimal, ConvertToBool para un verdadero falso
 */

