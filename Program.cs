// Operadores Determina los operadores para verificar las siguientes condiciones:
Console.WriteLine("---Operadores Logicos---");

// Un número es mayor o igual a 18
int num = 18;
Console.WriteLine(num>18 || num==18 );

// Un char es ‘a’
char texto = 'a';
Console.WriteLine( texto!='b');

// Se cumplen dos condiciones a la vez (ambas verdaderas)
int Num = 50;
int num1 = 10;
int num2 = 100;
Console.WriteLine( Num>num1 && Num<num2);

// Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine( Num>=num1 && Num<num2);
Console.WriteLine( Num<=num1 && Num==num2);









