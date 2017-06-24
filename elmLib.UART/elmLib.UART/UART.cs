using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace elmLib.UART
{
    public class UART
    {
        // Einstellungen für den Serial-Port
        private int _baudrate = 115200;
        private string _port;
        private Parity _parity = Parity.None;
        private StopBits _stopbit = StopBits.One;
        private int _datasize = 8;

        private bool _closed = false; // Zum überprüfen ob der PORT offen oder geschlossen ist
        
        // Verbinder für den Serial-Port
        private SerialPort _connector;

        // Konfiguration für denn Serial-Port
        public void UART_config(string port, int baudrate, Parity parity, int datasize, StopBits stopbit)
        {
            
            _port = port;
            _baudrate = baudrate;
            _parity = parity;
            _datasize = datasize;
            _stopbit = stopbit;
            _connector = new SerialPort(port, baudrate, parity, datasize, stopbit);
            if (_closed == false)
            {
                _connector.Open();
                _closed = true;
            }
        }

        // PORT ändern
        public void UART_Port(string port)
        {
            _port = port;
            _connector.PortName = port;
        }

        // Datenübertragung eines Strings (Wird in ASCII encodiert zu einem Byte-Array)
        public void UART_Transmit(string data)
        {
            byte[] toBytes = Encoding.ASCII.GetBytes(data);
            _connector.Write(data);
        }

        // Datenübertragung eines byte-Array
        public void UART_Transmit(byte[] data)
        {
            _connector.Write(data, 0, data.Length);
        }

        // Datenübertragung eines char-Array
        public void UART_Transmit(char[] data)
        {
            _connector.Write(data, 0, data.Length);
        }

        // !!!! Nach dem Empfangen der Daten muss man sie in ASCII umwandeln !!!!
        // Datenempfang und speichern in ein byte-Array
        public void UART_Receive(byte[] data, int startadresse, int stopadresse)
        {
            _connector.Read(data, startadresse, stopadresse);
        }

        // Datenempfang und speichern in ein char-Array
        public void UART_Receive(char[] data, int startadresse, int stopadresse)
        {
            _connector.Read(data, startadresse, stopadresse);
        }
        

        // !!! Beim Senden eines Commando sind keine "[]" einzugeben !!!
        // Senden eines Commandos
        public void UART_setCommand(string Command)
        {
            Command = "[" + Command + "]";
            byte[] toBytes = Encoding.ASCII.GetBytes(Command);
            UART_Transmit(toBytes);
        }

        // Empfangen eines Commando
        public string UART_getCommand(int durchlaufe)
        {
            int i = 0;
            string SaveCommand = "";
            while (i < durchlaufe)
            {
                byte[] save = new byte[5];
                _connector.Read(save, 0, 1);
                SaveCommand = Encoding.ASCII.GetString(save, 0, 1);

                if (SaveCommand == "[")
                {
                    _connector.Read(save, 0, save.Length);
                    SaveCommand = Encoding.ASCII.GetString(save, 0, save.Length);

                    if (SaveCommand == "%]")
                    {
                        return "[" + SaveCommand;
                    }
                 }

                i++;
            }
            return "[FAIL]";
        }


        // !!! Beim Senden eines Argument sind keine "{}" einzugeben !!!
        // Senden eines Argument 
        public void UART_setArgument(string Argument)
        {
            Argument = "{" + Argument + "}";
            byte[] toBytes = Encoding.ASCII.GetBytes(Argument);
            UART_Transmit(toBytes);
        }

        // Empfangen eines Argument
        public string UART_getArgument(int durchlaufe)
        {
            int i = 0;
            string SaveArgument = "";
            while (i < durchlaufe)
            {
                byte[] save = new byte[5];
                _connector.Read(save, 0, 1);
                SaveArgument = Encoding.ASCII.GetString(save, 0, 1);

                if (SaveArgument == "{")
                {
                    _connector.Read(save, 0, save.Length);
                    SaveArgument = Encoding.ASCII.GetString(save, 0, save.Length);

                    if (SaveArgument == "%}")
                    {
                        return "{" + SaveArgument;
                    }
                }

                i++;

            }
            return "{FAIL}";
        }


        // Properties
    
        public int Baud
        {
            get
            {
                return _baudrate;
            }
        }

        public string Port
        {
            get
            {
                return _port;
            }
        }

        public Parity Parity
        {
            get
            {
                return _parity;
            }
        }

        public StopBits Stobit
        {
            get
            {
                return _stopbit;
            }
        }

        public int Datasize
        {
            get
            {
                return _datasize;
            }
        }

    }
}
