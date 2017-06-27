using System;
using System.Windows.Forms;

namespace Enumerationen
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var result = MessageBox.Show(
                    text: "Bitte wenden Sie sich umgehend an Ihren Systemadministrator!",
                    caption: "Unbekannter Fehler!",
                    buttons: MessageBoxButtons.RetryCancel,
                    icon: MessageBoxIcon.Stop);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Retry:
                        Console.WriteLine("Nochmal nochmal.");
                        break;
                }
            }

            var tage = Wochentage.Montag | Wochentage.Freitag;

            Console.WriteLine(tage);

            Console.ReadKey();
        }
    }
}
