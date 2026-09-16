using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    // die Klasse SmtpMailSender "implementiert" das Interface IMailSender
    //      => die Klasse muss alle Methoden dieses Interfaces ausprogrammieren
    public class SmtpMailSender : IMailSender
    {

        public bool Send(string to, string subject, string body)
        {
            // hier würde der Code für den Smtp-Versand stehen
            return true;
        }
    }
}
