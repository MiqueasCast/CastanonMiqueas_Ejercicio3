Console.WriteLine("Seleccione según su rol:\n1. Estudiante \n2. Docente \n3. Administrativo \n4. Externo");
int rol = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese monto base: ");
double totalAmount = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese método de pago: \n1. Efectivo \n2. Tarjeta \n3. Transferencia ");
int paymentMethod = int.Parse(Console.ReadLine());

Console.WriteLine("Tiene cupón S/N: ");
string hasCoupon = Console.ReadLine();

if (hasCoupon == "S" || hasCoupon == "s")
{
    Console.WriteLine("Ingrese codigo: ");
    string couponCode = Console.ReadLine();
}
else
{
    Console.WriteLine("No tiene cupón");
}


