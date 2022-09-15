// // A. Hacer	un programa	para	ingresar	cuatro	números distintos y	luego	mostrar	por	
// // pantalla	el	mayor de	ellos.

// int num1, num2, num3, num4;
// int max = 0;
// Console.WriteLine("Ingrese el primer numero");
// num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo numero");
// num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el tercer numero");
// num3 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el cuarto numero");
// num4 = int.Parse(Console.ReadLine());

// if(num1 > num2)
// {
//   max = num1;
// }
// else
// {
//   max = num2;
// }

// if (num3 > max)
// {
//   max = num3;
// }
// if (num4 > max)
// {
//   max = num4;
// }
// Console.WriteLine("Numero mayor: " + max);



// // B. Hacer	un	programa	para	ingresar	cuatro	números distintos	y	luego	mostrar	por	
// // pantalla	el	menor	de	ellos.
// int a, b, c, d, menor;

// Console.WriteLine("Ingrese el primer numero");
// a = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo numero");
// b = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el tercer numero");
// c = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el cuarto numero");
// d = int.Parse(Console.ReadLine());

// if (a < b)
// {
//   menor = a;
// }
// else
// {
//   menor = b;
// }

// if (c < menor)
// {
//   menor = c;
// }

// if (d < menor)
// {
//   menor = d;
// }
// Console.WriteLine("Numero menor: " + menor);



// // C. Hacer	un	programa para	ingresar	cuatro	números	distintos	y	luego	mostrar	por	
// // pantalla	el	mayor	y	el	menor	de	ellos.
// int n1, n2, n3, n4, mnr, myr;

// Console.WriteLine("Ingrese el primer numero");
// n1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo numero");
// n2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el tercer numero");
// n3 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el cuarto numero");
// n4 = int.Parse(Console.ReadLine());

// if (n1 < n2)
// {
//   myr = n2;
//   mnr = n1;
// }
// else
// {
//   myr = n1;
//   mnr = n2;
// }

// if (n3 > myr)
// {
//   myr = n3;
// }
// else if (n3 < mnr)
// {
//   mnr = n3;
// }

// if (n4 > myr)
// {
//   myr = n4;
// }
// else if (n4 < mnr)
// {
//   mnr = n4;
// }

// Console.WriteLine("Numero Mayor " + myr);
// Console.WriteLine("Numero Menor :" + mnr);



// // D. Hacer	un	programa	para	ingresar	cuatro	números y	luego	mostrar	por	pantalla	
// // cuáles son	mayores	a	100.
// int a1, a2, a3 ,a4;

// Console.WriteLine("Ingrese el primer numero");
// a1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo numero");
// a2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el tercer numero");
// a3 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el cuarto numero");
// a4 = int.Parse(Console.ReadLine());

// if (a1 > 100)
// {
//   Console.WriteLine(a1 + " Es mayor a 100");
// }

// if (a2 > 100)
// {
//   Console.WriteLine(a2 + " Es mayor a 100");
// }

// if (a3 > 100)
// {
//   Console.WriteLine(a3 + " Es mayor a 100");
// }

// if (a4 > 100)
// {
//   Console.WriteLine(a4 + " Es mayor a 100");
// }



// E. Hacer	un	programa	para	ingresar cuatro	números	y	luego	mostrar	por	pantalla	
// cuántos son	menores	a	100.

int b1, b2, b3, b4;
int cont = 0;

Console.WriteLine("Ingrese el primer numero");
b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero");
b3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto numero");
b4 = int.Parse(Console.ReadLine());

if (b1 < 100)
{
  cont++;
}

if (b2 < 100)
{
  cont++;
}

if (b3 < 100)
{
  cont++;
}

if (b4 < 100)
{
  cont++;
}

Console.WriteLine("Hay " + cont + " numeros menores a 100");