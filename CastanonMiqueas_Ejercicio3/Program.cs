using System.Collections.Specialized;
using System.ComponentModel.Design;

Console.WriteLine("Seleccione según su rol:\n1. Estudiante \n2. Docente \n3. Administrativo \n4. Externo");
int rol = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese monto base: ");
double totalAmount = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese método de pago: \n1. Efectivo \n2. Tarjeta \n3. Transferencia ");
int paymentMethod = int.Parse(Console.ReadLine());

Console.WriteLine("Tiene cupón S/N: ");
string hasCoupon = Console.ReadLine();
string couponCode =  "";
if (hasCoupon == "S" || hasCoupon == "s")
{
    Console.WriteLine("Ingrese codigo: ");
    couponCode = Console.ReadLine();

}

Console.WriteLine("Reporte antifraude: \n1. Ninguno \n. Cupón inválido repetido \n3. Pagos rechazados múltiples");
int antifraudReport = int.Parse(Console.ReadLine());

if (totalAmount <= 0 || rol < 1 || rol > 4 || paymentMethod < 1 || paymentMethod > 3 || antifraudReport < 1 || antifraudReport > 3)
{
    Console.WriteLine("Datos inválidos");
}
else
{
    double discount = 0;
    double recargo = 0;

    if (antifraudReport != 1)
    {
        if (antifraudReport == 2)
        {
            recargo = 0.10;
            Console.WriteLine("Fraude tipo 2. Se cancelan descuentos y se aplicara un recargo de 10%");
        }
        else if (antifraudReport == 3)
        {
            recargo = 0.15;
            Console.WriteLine("Fraude tipo 3. Se cancelan descuentos y se aplica recargo del 20%");
        }
    }
    else
    {
        if (rol == 1 && paymentMethod == 1)
        {
            discount = 0.15;
        }
        else if (rol == 2 && paymentMethod == 2)
        {
            discount = 0.10;
        }

        if (hasCoupon == "s" || hasCoupon == "S" && couponCode.StartsWith("U"))
        {
            char lastChar = couponCode[couponCode.Length - 1];
            if (lastChar == '0' || lastChar == '2' || lastChar == '4' || lastChar == '6' || lastChar == '8')
            {
                discount += 0.05;
            }
        }
    }
}

