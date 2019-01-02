using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Voulez-vous remportez un magnifique cadeau oui ou non?");
            string choise = Console.ReadLine();
            {
                if (choise == "oui")
                {
                    Console.Clear();
                    Console.WriteLine("Parfait, marquez noel sur le terminal.");
                }
                else if (choise == "non")
                {
                    Console.Clear();
                    Console.WriteLine("Dommage pour vous, passez quand même de bonne fêtes.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Je n'ai pas compris votre réponse");
                }
                string numb = Console.ReadLine();
                if (numb == "noel")
                {
                    Console.Clear();
                    Console.WriteLine("Vous avez gagné une image de noel");
                    Console.WriteLine("……………….., -‘’ ; ; ; _,,---,,_; ;’’-,…………………………….._,,,---,,_………………");
                    Console.WriteLine("……………….,’ ; ; ;,-‘ , , , , , ‘-, ; ;’-,,,,---~~’’’’’’~--,,,_…..,,-~’’ ; ; ; ; __;’-,……………");
                    Console.WriteLine("……………….| ; ; ;,’ , , , _,,-~’’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ¯’’~’-,,_ ,,-~’’ , , ‘, ;’, …………");
                    Console.WriteLine("……………….’, ; ; ‘-, ,-~’’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;’’-, , , , , ,’ ; |…………");
                    Console.WriteLine("…………………’, ; ;,’’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;’-, , ,-‘ ;,-‘…………");
                    Console.WriteLine("………………….,’-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;’’-‘ ;,,-‘…………..");
                    Console.WriteLine("………………..,’ ; ; ; ; ; ; ; ; ; ; ; ; __; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ‘-,’……………..");
                    Console.WriteLine("………………, -‘ ; ; ; ; ; ; ; ; ; ;,-‘’¯: : ’’-, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; _; ; ; ; ;’,……………..");
                    Console.WriteLine("……………..,’ ; ; ; ; ; ; ; ; ; ; ;| : : : : : :| ; ; ; ; ; ; ; ; ; ; ; ; ,-‘’¯: ¯’’-, ; ; ;’,…………….");
                    Console.WriteLine("…………….,’ ; ; ; ; ; ; ; ; ; ; ; ‘-,_: : _,-‘ ; ; ; ; ; ; ; ; ; ; ; ; | : : : : : :| ; ; ; |……………");
                    Console.WriteLine("……………,’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ¯¯ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;’-,,_ : :,-‘ ; ; ; ;|……………");
                    Console.WriteLine("…………..,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ,,-~’’ , , , , ,,,-~~-,, , , , _ ; ; ;¯¯ ; ; ; ; ;|……");
                    Console.WriteLine("…………,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,’ , , , , , , ,( : : : : : ) , , , ,’’-, ; ; ; ; ; ; ; ;|…………");
                    Console.WriteLine("……….,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;’, , , , , , , , ,’~---~’’ , , , , , ,’ ; ; ; ; ; ; ; ;’,…………..");
                    Console.WriteLine("…….,-‘’ ; _, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ‘’~-,,,,--~~’’’¯’’’~-,,_ , ,_,-‘ ; ; ; ; ; ; ; ; ; ‘,………….");
                    Console.WriteLine("….,-‘’-~’’,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; | ; ; | . . . . . . ,’; ,’’¯ ; ; ; ; ; ; ; ; ; ,_ ; ‘-,………..");
                    Console.WriteLine("……….,’ ; ;,-, ; ;, ; ; ;, ; ; ; ; ; ; ; ; ; ; ‘, ; ;’, . . . . .,’ ;,’ ; ; ; ;, ; ; ;,’-, ; ;,’ ‘’~--‘’’………");
                    Console.WriteLine("………,’-~’ ,-‘-~’’ ‘, ,-‘ ‘, ,,- ; ; ; ; ; ; ; ; ‘, ; ; ‘~-,,,-‘’ ; ,’ ; ; ; ; ‘, ;,-‘’ ; ‘, ,-‘,……………..");
                    Console.WriteLine("……….,-‘’ ; ; ; ; ; ‘’ ; ; ;’’ ; ; ; ; ; ; ; ; ; ; ‘’-,,_ ; ; ; _,-‘ ; ; ; ; ; ;’-‘’ ; ; ; ‘’ ; ;’-,…………..");
                    Console.WriteLine("……..,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;¯¯’’¯ ; ; ; ; ; ; ; ; , ; ; ; ; ; ; ; ; ;’’-,……….");
                    Console.WriteLine("……,-‘ ; ; ; ; ; ; ; ,, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; |, ; ; ; ; ; ; ; ; ; ; ‘-,…….");
                    Console.WriteLine("…..,’ ; ; ; ; ; ; ; ;,’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;|..’-,_ ; ; ; , ; ; ; ; ; ‘,…..");
                    Console.WriteLine("….,’ ; ; ; ; ; ; ; ; | ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,’…….’’’,-~’ ; ; ; ; ; ,’…..");
                    Console.WriteLine("…,’ ; ; ; ; ; ; ; ; ;’~-,,,,,--~~’’’’’’~-,, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,’…..,-~’’ ; ; ; ; ; ; ,-‘……");
                    Console.WriteLine("…| ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ‘, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,’…,-‘ ; ; ; ; ; ; ; ;,-‘……..");
                    Console.WriteLine("…’, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ,-‘ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ,’….’, ; ; ; ; _,,-‘’…………");
                    Console.WriteLine("….’, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ,-‘’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,’…….’’~~’’¯………………");
                    Console.WriteLine("…..’’-, ; ; ; ; ; ; ; ; ; ; ; ; ; ;_,,-‘’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ,-‘…………………………….");
                    Console.WriteLine("………’’~-,,_ ; ; ; ; _,,,-~’’ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,-‘……………………………..");
                    Console.WriteLine("………..| ; ; ;¯¯’’’’¯ ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,,-‘……………………………….");
                    Console.WriteLine("………..’, ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;,-‘…………………………………");
                    Console.WriteLine("…………| ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;|…………………………………..");
                    Console.WriteLine("…………’, ; ; ; ; ; ; ; ; ; ~-,,___ ; ; ; ; ; ; ; ; ; ; ; ; ; ;’,………………………………….");
                    Console.WriteLine("………….’, ; ; ; ; ; ; ; ; ; ; ;,-‘….’’-, ; ; ; ; ; ; ; ; ; ; ; ; ‘,…………………………………");
                    Console.WriteLine("………..,’ ‘- ; ; ; ; ; ; ; ; ;,-‘’……….’-, ; ; ; ; ; ; ; ; ; ; ; ‘,………………………………..");
                    Console.WriteLine("……….,’ ; ;’ ; ; ; ; ; ; ,,-‘…………….’, ; ; ; ; ; ; ; ; ; ; ;’,……………………………….");
                    Console.WriteLine("………,’ ; ; ; ; ; ; ; ;,-‘’…………………’’-, ; ; ; ; ; ; ; ; ; |……………………………….");
                    Console.WriteLine("……..,’ ; ; ; ; ; ; ;,,-‘………………………’’, ; ; ; ; ; ; ; ; |………………………………");
                    Console.WriteLine("……..| ; ; ; ; ; ; ;,’…………………………,’ ; ; ; ; ; ; ; ;,’……………………………….");
                    Console.WriteLine("……..| ; ; ; ; ; ; ,’………………………..,-‘ ; ; ; ; ; ; ; ,’’………………………………..");
                    Console.WriteLine("……..| ; ; ; ; ; ;,’……………………….,-‘ ; ; ; ; ; ; ; ,-‘………………………………….");
                    Console.WriteLine("……..’,_ , ; , ;,’……………………….,’ ; ; ; ; ; ; ; ,-‘……………………………………");
                    Console.WriteLine("………’,,’,¯,’,’’|……………………….| ; ; ; ; ; ; ; ; ‘--,,………………………………….");
                    Console.WriteLine("………….¯…’’………………………..’-, ; ; ; ; ; ; ; ; ; ;’’~,,…………………………….");
                    Console.WriteLine("……………………………………………’’-,, ; ; ; ; ; ; ; ; ; ;’’~-,,……………………….");
                    Console.WriteLine("………………………………………………..’’-, ; ; ; ; ; ,,_ ; ;’-,’’-,……………………..");
                    Console.WriteLine("…………………………………………………..’, ; ; ; ; ; ; ‘-,__,\\--\\...........................");
                    Console.WriteLine("……………………………………………………’-, ; ; ;,,-~’’’ \\ , ,|, |……………………");
                    Console.WriteLine("………………………………………………………’’~-‘’_ , , ,,’,_/--‘……………………");
                    Console.WriteLine("…………………………………………………………….’’~-~’………………….…….");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue");
                }
            }
        }
    }
}