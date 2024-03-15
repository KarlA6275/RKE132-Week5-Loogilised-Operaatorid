//Math >= 90; Biology >= 90; Chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Kirjutage oma matemaatika tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Kirjutage oma bioloogia tulemus:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Kirjutage oma keemia tulemus:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Õnnitleme sisse saamise puhul.");
}
else
{
    Console.WriteLine("Teie taotlus on tagasi lükatud.");
}
