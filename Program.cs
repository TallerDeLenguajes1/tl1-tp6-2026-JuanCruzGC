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
// int num1=0;
// int num2=0;
// string ingreso1,ingreso2,seguirOperando,operacion;
// do
// {
//     //Ingreso de operacion
//     do
//     {
//         Console.WriteLine("---OPERACIONES---");
//         Console.WriteLine("1:Suma");
//         Console.WriteLine("2:Resta");
//         Console.WriteLine("3:Multiplicacion");
//         Console.WriteLine("4:Division");
//         operacion=Console.ReadLine();
//     }while(!operacion.Equals("1") && !operacion.Equals("2") && !operacion.Equals("3") && !operacion.Equals("4"));
//     //Ingreso de numeros a operar
//     do
//     {
//         Console.WriteLine("NUMERO 1");
//         ingreso1=Console.ReadLine();
//         Console.WriteLine("NUMERO 2");
//         ingreso2=Console.ReadLine();
//     }while(!int.TryParse(ingreso1,out num1) || !int.TryParse(ingreso2,out num2)); //Nos aseguramos de que sean numeros.
//     switch(operacion)
//     {
//         case "1":
//             Console.WriteLine("-RESULTADO:"+(num1+num2));
//         break;
//         case "2":
//             Console.WriteLine("-RESULTADO:"+(num1-num2));
//         break;
//         case "3":
//             Console.WriteLine("-RESULTADO:"+(num1*num2));
//         break;
//         case "4":
//             Console.WriteLine("-RESULTADO:"+(num1/num2));
//         break;
//     }
//     Console.WriteLine("Desea seguir operando?  1:Si");
//     seguirOperando=Console.ReadLine();
// }while(seguirOperando.Equals("1")); //Verifica que se ingresó el 1 para seguir operando
// Console.WriteLine("Terminando Programa...");
        
        //-----------Punto 3-----------
float numero=0;
int num1,num2;
string seguirOperando,ingreso1,ingreso2;
do
{
    Console.WriteLine("-----OPERACIONES BASICAS-----");
    Console.WriteLine("INGRESE UN NUMERO TIPO FLOAT");
    ingreso1=Console.ReadLine();
    if (float.TryParse(ingreso1,out numero))
    {
        //Valor absoluto
        Console.WriteLine("--VALOR ABSOLUTO:");
        if(numero>=0)   Console.WriteLine(numero);
        else    Console.WriteLine((-1)*numero);
        //Cuadrado
        Console.WriteLine("--CUADRADO DEL NUMERO:"+(numero*numero));
        //Raiz Cuadrada
        if(numero>=0) Console.WriteLine("RAIZ CUADRADA:"+ Math.Sqrt(numero));
        else    Console.WriteLine("EL NUMERO INGRESADO NO ES POSITIVO O 0");
        //Seno
        Console.WriteLine("--SENO: "+Math.Sin(numero));
        //Coseno
        Console.WriteLine("--COSENO:"+Math.Cos(numero));
        //Parte entera
        Console.WriteLine("--PARTE ENTERA:"+(int)numero);
    }else Console.WriteLine("LA CADENA INGRESADA NO ESTA PERMITIDA");

    do
    {
        Console.WriteLine("-----MAXIMO Y MINIMO-----");
        Console.WriteLine("Ingrese el primer numero");
        ingreso1=Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero");
        ingreso2=Console.ReadLine();  
    }while(!int.TryParse(ingreso1,out num1) || !int.TryParse(ingreso2,out num2));
    if (num1 >= num2)
    {
        Console.WriteLine("MAXIMO:"+num1);
        Console.WriteLine("MINIMO:"+num2);
    }
    else
    {
        Console.WriteLine("MAXIMO:"+num2);
        Console.WriteLine("MINIMO:"+num1);
    }

    Console.WriteLine("¿Desea seguir operando?  1:Si");
    seguirOperando=Console.ReadLine();
}while(seguirOperando.Equals("1"));
Console.WriteLine("Terminando Programa...");
