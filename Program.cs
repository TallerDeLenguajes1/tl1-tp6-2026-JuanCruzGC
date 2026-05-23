    //----------Prueba----------
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("Valor de a:"+a);
// Console.WriteLine("Valor de a:"+b);

    //----------Punto 1----------
string ?ingreso;
int num;
Console.WriteLine("Ingrese el numero a invertir");
ingreso=Console.ReadLine();
if(int.TryParse(ingreso,out num))
{
    if(num>0){
        while (num != 0)
        {
            Console.Write(num%10);
            num=num/10;
        }
    }else Console.WriteLine("El numero ingresado debe ser mayor que Cero"); 
}else Console.WriteLine("La cadena ingresada no es un numero");