using Basics.Models;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // von einer abstrakten Klasse kann keine Instanz erzeugt werden
            //      hinter new kann keine abstrakte Klasse angegeben werden
            // AbstractClass ac = new AbstractClass();

            // ac.Calculate();
            List<AbstractClass> list = new List<AbstractClass>();

            // Instanz einer abstrakten Klasse nicht möglich
            // list.Add(new AbstractClass());

            list.Add(new Kindklasse1());
            list.Add(new Kindklasse2());

            list[0].Value = 10;
            list[1].Value = 20;

            foreach (var c in list)
            {
                Console.WriteLine(c.Calculate());
            }

            // Interface
            // links wird immer das Interface verwendet (macht die Anwendung
            //      viel flexibler)
            // rechts wird die implementierende Klasse angegeben
            IMailSender ms = new SmtpMailSender();

            ms.Send("xyz@gmx.at", "Interfaces", "hallo");
        }
    }
}
