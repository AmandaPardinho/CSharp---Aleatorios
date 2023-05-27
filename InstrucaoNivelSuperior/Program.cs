/* INSTRUÇÕES DE NÍVEL SUPERIOR - PROGRAMAS SEM MÉTODO MAIN
 * o método Main não é declarado explicitamente;
 * uso de instruções de alto nível => minimiza a quantidade de código que será escrita;
 * compilador gera uma classe e um ponto de entrada do método Main para a aplicação;
 * usabilidade de instruções de nível superior =>
 * ** apenas um ponto de entrada por aplicativo;
 *  *** é possível escrever um método Main explicito além do arquivo que contém as instruções de nível superior => porém o compilador retornará um erro
 * ** apenas um arquivo com instruções de nível superior por projeto => mais de um arquivo no mesmo projeto resulta em erro;
 *  *** projetos podem ter vários arquivos de código-fonte adicionais que não contenham instruções de nível superior;
 * ** as diretivas (using) devem ser colocadas em primeiro lugar no arquivo;
 * ** instruções de nível superior estão no namespace global;
 * ** o arquivo com instruções de nível superior pode conter namespaces e definições de tipo => devem ser colocados após as instruções de nível superior;
 * ** podem fazer referência à variável args para acessar quaisquer argumentos de linha de comando que foram inseridos;
 *  *** variável args => nunca é nula;
 *  *** possui Lenght = 0 caso nenhum argumento de linha de comando seja fornecido;
 * ** método assíncrono => pode ser chamado usando 'await';
 * ** retornando o valor de um int quando o aplicativo terminar => usar a instrução 'return'
 * 
 */

//Console.WriteLine("Hello world!");

#region DIRETIVAS
using System.Text;

StringBuilder builder = new();
builder.AppendLine("Hello");
builder.AppendLine("world");

Console.WriteLine(builder.ToString());
#endregion

#region NAMESPACE E TIPO
/*using System;
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello world!");
    }
}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello world from MyNamespace.MyClass.myMethod!");
        }
    }
}*/
#endregion

#region ARGS
/*if(args.Length > 0)
{
    foreach(var arg in args)
    {
        Console.WriteLine($"Argumento = {arg}");
    }
}
else
{
    Console.WriteLine("Nenhum argumento");
}*/
#endregion

#region AWAIT
Console.WriteLine("Hello ");
await Task.Delay(3000);
Console.WriteLine(" world!");
#endregion

#region RETURN
string? s = Console.ReadLine();

int retornaValor = int.Parse(s ?? "-1");
return retornaValor;
#endregion