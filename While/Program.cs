﻿// See https://aka.ms/new-console-template for more information

//Loop1();
Loop2();

void Loop1()
{   
    //contador
    int cont = 1;

    while (cont <= 10)
    {
        Console.WriteLine(cont);
        cont++;
    }
}

void Loop2()
{
    string input = null;
    //criando uma lista
    List<string> lista = new List<string>();

    
    Console.WriteLine("Registre os produtos do mercado: \n\n"); 

    while (input != "parar")
    {
        input = Console.ReadLine();
        lista.Add(input);
        
    }
    lista.Remove("parar");
    Console.WriteLine("\n\n Encerrando o registro dos produtos...\n\n");
   
    int contador = 0;
    while (contador <lista.Count)
    {
        Console.WriteLine($"Produto {contador+1}: {lista[contador]}");
        contador++;
    }
}