using System;

namespace WeekendExtention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sub = "Programming";
            string sub1 = "Design";
            string sub2 = "Enginer";

            Extention extention = new Extention(sub);
            Extention extention1 = new Extention(sub1);
            Extention extention2 = new Extention(sub2);

            Console.WriteLine(extention.getSubject(sub) + extention.Id);
            Console.WriteLine(extention1.getSubject(sub1) + extention1.Id);
            Console.WriteLine(extention2.getSubject(sub2) + extention2.Id);
        }
    }
}
