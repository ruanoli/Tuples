using Tuplas.Models;
// //FORMA RECOMENDADA (podemos nomear nossos dados.)
// (int Id, string Nome, string Sobrenome) datas = (1, "Ruan", "Oliveira");

// //Outra forma de representar uma tupla
// ValueTuple<int, string, string> otherTuple = (1, "Ruan", "Oliveira");

// //+1 Forma hehehe
// var getTuple = Tuple.Create(1, "Ruan", "Oliveira");

// Console.WriteLine($"Id: {datas.Item1}");
// Console.WriteLine($"Nome: {datas.Item2}");
// Console.WriteLine($"Sobrenome: {datas.Item3}");



ReadFile file = new ReadFile();
//Para fazer o descarte de alguma informação que não usaremos na tupla
//basta colocarmos o _ no lugar da informação.
var (Sucess, Lines, QuantityLines) = file.ReadingFile("Files/fileTest.txt");

if(Sucess)
{
    Console.WriteLine($"Quantidade de linhas: {QuantityLines}");
    foreach(var lines in Lines)
    {
        Console.WriteLine(lines);
    }
}
else
{
    Console.WriteLine("Não foi possível ler as linhas.");
}