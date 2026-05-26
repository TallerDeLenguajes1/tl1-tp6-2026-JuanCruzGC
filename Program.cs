            //----------Prueba----------
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("Valor de a:"+a);
// Console.WriteLine("Valor de a:"+b);

            //----------Punto 1 (Invertir)----------
// string ingreso;
// int num;
// Console.WriteLine("Ingrese el numero a invertir");
// ingreso=Console.ReadLine();
// if(int.TryParse(ingreso,out num))
// {
//     if(num>0){
//         while (num != 0)
//         {
//             Console.Write(num%10);
//             num=num/10;
//         }
//     }else Console.WriteLine("El numero ingresado debe ser mayor que Cero"); 
// }else Console.WriteLine("La cadena ingresada no es un numero");

            //----------Punto 2 (Calculadora 1)----------
int seguirOperando,operacion,num1,num2;
string ingreso1,ingreso2;
do
{
    //Ingreso de operacion
    do
    {
        Console.WriteLine("---OPERACIONES---");
        Console.WriteLine("1:Suma");
        Console.WriteLine("2:Resta");
        Console.WriteLine("3:Multiplicacion");
        Console.WriteLine("4:Division");
        operacion=Console.ReadLine();
    }while(operacion=='1' || operacion=='2' || operacion=='3' || operacion=='4');
    //Ingreso de numeros a operar
    do
    {
        Console.WriteLine("NUMERO 1");
        ingreso1=Console.ReadLine();
        Console.WriteLine("NUMERO 2");
        ingreso2=Console.ReadLine();
    }while(int.TryParse(ingreso1,out num1) && int.TryParse(ingreso2,out num2)); //Nos aseguramos de que sean numeros.
    
    switch(operacion)
    {
        case 49:
            Console.WriteLine("-RESULTADO:"+(num1+num2));
        break;
        case 50:
            Console.WriteLine("-RESULTADO:"+(num1-num2));
        break;
        case 51:
            Console.WriteLine("-RESULTADO:"+(num1*num2));
        break;
        case 52:
            Console.WriteLine("-RESULTADO:"+(num1/num2));
        break;
    }
    Console.WriteLine("Desea seguir operando? 1:Si  Cualquier otro valor:No");
    seguirOperando=Console.ReadLine();
}while(seguirOperando=='1'); //Verifica que se ingresó el 1 para seguir operando

