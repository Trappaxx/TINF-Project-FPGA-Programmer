using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using elmLib.UART; // Einbindung der Klasse
using System.IO.Ports; // Wird für die UART Schnittstelle benutzt

namespace UART_test
{
    
    class Program
    {

        
        static void Main(string[] args)
        {
            UART rs232;
            rs232 = new UART(); // Neues UART Objekt 
            string info = "";
            string info2 = "";
            int i = 1;
            int x = 0;
            byte[] test = new byte[1];
            rs232.UART_config("COM5", 57600, Parity.None, 8, StopBits.One); // Initialisieren des Ports
            // Die Datenfor,(Bautrate,Parity,...) sind wie beim Programm auf der MEGACARD eingestellt
            
            //While Schleife, weil man immer wieder Abfrage was ich bekomme
            while (i == 1)
            {
                // Es wird immer nur ein Byte abgefragt und dieses Direkt ausgegeben
                // Man kann auch mehrere bytes auslessen und diese dan Encoden und ausgeben
                // Aber beim ausgeben der encodeten Bytes entstehen lücken und es ist schwer zu lesen

                rs232.UART_Receive(test, 0, test.Length); //Empfangen eines Bytes 
                info = Encoding.ASCII.GetString(test); // Das Empfangene Byte wird in ASCII Encodiert und in ein String gewandelt
                // Dieser String wird in den String info gespeichert und in die Console geschrieben
                Console.Write(info);
                if (info == "[") // Wenn das ASCII Zeichen gleich [ ist bedeutet es, dass ein Commando kommt
                { 
                    byte[] test2 = new byte[5]; // Array erstellen zum einlesen der nächsten 5 bytes, weil die Commandos immer 6 bytes lang sind und man
                                                // das erste byte "[" schon abgefragt haben.
                    rs232.UART_Receive(test2, 0, test2.Length); //Einlessen der nächsten 5 bytes
                    info2 = Encoding.ASCII.GetString(test2); // ASCII Encoden der 5 eingelesenen bytes
                    Console.Write(info2);// Und diese dann in die Console ausgeben
                    
                    if ((info2 == "PROM]") & (x == 0)) // Wenn von der MEGACARD der Befehl PROM kommt,dann...
                    {
                        rs232.UART_setCommand("PROM"); // wird der commando PROM als bestätigung rückgesendet
                        info2 = "";
                        x++; // Wenn der Befehl PROM geschrieben wurde, kann dieser nicht nochmahl vorkommen
                    }
                }
            }   
        }
    }
}
