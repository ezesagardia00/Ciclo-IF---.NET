// 6. Una	casa	de	video	juegos otorga	un	descuento	dependiendo	del	importe	de	la	
// compra	realizada según	los	siguientes	valores:
// • Si	el	importe	es	menor	a	ARS	1000,	no	hay	descuento.
// • Si	el	importe	es ARS	1000	 o	más	pero	menor	a	ARS	5000,	aplica	un	
// descuento	del	10%.
// • Si	el	importe	es ARS	5000	o	más,	aplica	un	descuento	del	18%.

double importe, descuento;

Console.WriteLine("Ingrese el importe de la compra");
importe = double.Parse(Console.ReadLine());

if (importe >= 1000 && importe < 5000)
{
  // Descuento del 10%
  descuento = importe * 0.90;
  Console.WriteLine("Descuento de : " + descuento);
}
else if (importe >= 5000)
{
  descuento = importe * 0.82;
  Console.WriteLine("Descuento de : " + descuento);
}
else
{
  Console.WriteLine("No hay Descuento");
}