Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Seja bem vindo ao nosso Pet Hotel!");
Console.WriteLine("------- Pet Hotel Check-in -------\n");
Console.Write("Espécie......: ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
string especie = Console.ReadLine()!;
 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Raça.........: ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
string raca = Console.ReadLine()!;
 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Alcunha/nome.: ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
string alcunha = Console.ReadLine()!;
 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Idade (anos).: ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
string idade = Console.ReadLine()!;
 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Pelagem/cor..: ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
string pelagemCor = Console.ReadLine()!;
Console.WriteLine();
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
 
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pet Hotel \"Nem um pio\"");
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("                  |");
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(" | Raça: ");
 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" |");
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pela alcunha/nome de: ");
 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(alcunha.Trim().ToUpper().PadLeft(26, '.').Substring(0, 26));
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" |");
Console.Write("| Idade: ");
 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(" | Pelagem/cor: ");
 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" |");
 
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("+=========================================================+"); Console.ResetColor();
Console.WriteLine();
Console.WriteLine();