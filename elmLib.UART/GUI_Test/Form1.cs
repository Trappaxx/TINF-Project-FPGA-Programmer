using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elmLib.UART;
using System.IO.Ports;
namespace GUI_Test
{
    public partial class Form1 : Form
    {
        UART rs232;
        public Form1()
        {
            InitializeComponent();
            rs232 = new UART();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rs232.UART_config("COM4", 57600, Parity.None, 8, StopBits.One);
            label2.Text = "Verbunden";
            label2.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string senden = textBoxsenden.Text;
            rs232.UART_Transmit(senden);
        }

        private void buttonsendcommand_Click(object sender, EventArgs e)
        {
            rs232.UART_setCommand(textBoxsetcommand.Text);
        }

        private void buttonsetargument_Click(object sender, EventArgs e)
        {
            rs232.UART_setArgument(textBoxsetargument.Text);
        }

        private void buttondatenwoerterempf_Click(object sender, EventArgs e)
        {
            byte[] save = new byte[Convert.ToInt16(textBoxanzahl.Text)];
            rs232.UART_Receive(save, 0, save.Length);
            string empfangen = Encoding.ASCII.GetString(save, 0, save.Length);
            listBoxdatenwoerter.Items.Add(empfangen);
        }

        private void buttongetcommand_Click(object sender, EventArgs e)
        {
            string empfangen = rs232.UART_getCommand(Convert.ToInt16(textBoxgetcommand.Text));
            listBoxcommand.Items.Add(empfangen);
        }

        private void buttongetargument_Click(object sender, EventArgs e)
        {
            string empfangen = rs232.UART_getArgument(Convert.ToInt16(textBoxgetargument.Text));
            listBoxargument.Items.Add(empfangen);
        }
    }
}