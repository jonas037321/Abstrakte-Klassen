using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    // Interfaces in C# beginnen normalerweise mit einem I
    //      ein Interface definiert eine/ mehrere Methodenköpfe
    //      die Implementierung fehlt allerdings

    // die Methoden müssen in den implementierenden Klassen
    //              ausprogrammiert werden
    public interface IMailSender
    {

        bool Send(string to, string subject, string body);
        // hier können weitere Methodenköpfe stehen



    }
}
