// See https://aka.ms/new-console-template for more information
using Calculadora;
void TestSumar()
{
    int valor1 = 5;
    int valor2 = 4;

    //Es el valor que tu sabes de antemano que es el resultado correcto
    int valorEsperado = 9;

    //Verificar si tu función devuelve el resultado correcto
    int resultado = Operaciones.Sumar(4, 5);

    if (resultado == valorEsperado)
        Console.WriteLine("Prueba satisfactoria");
    else
        Console.WriteLine("Error en la prueba");
}
void TestRestar()
{
    int valor1 = 5;
    int valor2 = 4;

    //Es el valor que tu sabes de antemano que es el resultado correcto
    int valorEsperado = 1;

    //Verificar si tu función devuelve el resultado correcto
    int resultado = Operaciones.Restar(5, 4);

    if (resultado == valorEsperado)
        Console.WriteLine("Prueba satisfactoria");
    else
        Console.WriteLine("Error en la prueba");
}
//Casos de prueba dividir (funcion prueba divir)

//Escenario 01
void TestDividir()
{
    int valor1 = 10;
    int valor2 = 5;

    //Es el valor que tu sabes de antemano que es el resultado correcto
    int valorEsperado = 2;

    //Verificar si tu función devuelve el resultado correcto
    int resultado = Operaciones.Dividir(valor1, valor2);

    if (resultado == valorEsperado)
        Console.WriteLine("Prueba satisfactoria");
    else
        Console.WriteLine("Error en la prueba");
}

//Escenario 02
void TestDividir2()
{
    int valor1 = 0;
    int valor2 = 5;

    //Es el valor que tu sabes de antemano que es el resultado correcto
    int valorEsperado = 0;

    //Verificar si tu función devuelve el resultado correcto
    int resultado = Operaciones.Dividir(valor1, valor2);

    if (resultado == valorEsperado)
        Console.WriteLine("Prueba satisfactoria");
    else
        Console.WriteLine("Error en la prueba");
}
void TestRegistrarUsuario()
{
    bool valorEsperado = true;

    bool resultado;
    resultado= Usuario.Registrar("Hugo", "Torrico");

    if (resultado == valorEsperado)
        Console.WriteLine("TestRegistrarUsuario Prueba satisfactoria");
    else
        Console.WriteLine("TestRegistrarUsuario Error en la prueba");


}
void TestPaisesContinente()
{
    List<string> valorEsperado = new List<string>();
    valorEsperado.Add("Perú");
    valorEsperado.Add("Argentina");
    valorEsperado.Add("Brasil");

    var resultado = Pais.ListarPaises("America");
    bool resulTest = true;

    for (int i = 0; i < 3; i++)
    {
        if( valorEsperado[i] != resultado[i])        
        {
            resulTest = false;
            break;
        }
    }

    if (resulTest)
        Console.WriteLine("TestPaisesContinente Prueba satisfactoria");
    else
        Console.WriteLine("TestPaisesContinente Error en la prueba");


}



TestSumar();
TestRestar();
TestDividir();
TestDividir2();
TestRegistrarUsuario();
TestPaisesContinente();
Console.Read();