using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Minimalistic_ALU
{
    public partial class MainWindow : Form
    {
        SerialPort UsbPort = new SerialPort();

        int a0 = 0, a1 = 0, b0 = 0, b1 = 0;

        String feedback = String.Empty;

        List<int> results = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void conn_Click(object sender, EventArgs e)
        {
            
            try
            {
                UsbPort.PortName = _port.Text;
                UsbPort.Open();
                if (UsbPort.IsOpen)
                {
                    MessageBox.Show($"Connected to {UsbPort.PortName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void exec_Click(object sender, EventArgs e)
        {
            if (UsbPort.IsOpen)
            {
                int index = ____opcode.SelectedIndex;
                var operand = $"{a1}{a0}{b1}{b0}";
                switch (index)
                {
                    case 0:
                        UsbPort.Write("0");
                        Thread.Sleep(100);
                        UsbPort.Write(operand);
                        Thread.Sleep(100);
                        break;
                    case 1:
                        UsbPort.Write("1");
                        Thread.Sleep(100);
                        UsbPort.Write(operand);
                        Thread.Sleep(100);
                        break;
                    case 2:
                        UsbPort.Write("2");
                        Thread.Sleep(100);
                        UsbPort.Write(operand);
                        Thread.Sleep(100);
                        break;
                    case 3:
                        UsbPort.Write("3");
                        Thread.Sleep(100);
                        UsbPort.Write(operand);
                        Thread.Sleep(100);
                        break;
                    case 4:
                        UsbPort.Write("4");
                        Thread.Sleep(100);
                        UsbPort.Write(operand);
                        Thread.Sleep(100);
                        break;
                    default:
                        MessageBox.Show("Choose a valid operation!");
                        break;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (UsbPort.IsOpen)
            {
                connStatus.Text = "Connected!";
            }
            else
            {
                connStatus.Text = "Disconnected!";
            }
        }


        int _1scomplement(int a)
        {
            if (a == 0) return 1;
            return 0;
        }

        void showOutput()
        {
            if (feedback == String.Empty)
            {
                return;
            }
            results.Clear();
            var Temp = feedback.Split(" ");
            foreach (var x in Temp)
            {
                results.Add(Convert.ToInt16(x));
            }
            Form newForm = new OutputWindow(results[0], results[1], results[2]);
            newForm.ShowDialog();

        }


        private async void showResult_Click(object sender, EventArgs e)
        {
            if (UsbPort.IsOpen)
            {
                UsbPort.Write("&");
                feedback = await Task.Run(() => UsbPort.ReadLine());
                //Thread.Sleep(100);
                showOutput();
            }
        }


        private void cmp_b0_Click(object sender, EventArgs e)
        {
            int content = Convert.ToInt16(_bnot.Text);
            b0 = content = _1scomplement(content);
            _bnot.Text = content.ToString();

        }

        private void cmp_b1_Click(object sender, EventArgs e)
        {
            int content = Convert.ToInt16(_bone.Text);
            b1 = content = _1scomplement(content);
            _bone.Text = content.ToString();
        }


        private void cmp_a0_Click(object sender, EventArgs e)
        {
            int content = Convert.ToInt16(_anot.Text);
            a0 = content = _1scomplement(content);
            _anot.Text = content.ToString();
        }


        private void cmp_a1_Click(object sender, EventArgs e)
        {
            int content = Convert.ToInt16(_aone.Text);
            a1 = content = _1scomplement(content);
            _aone.Text = content.ToString();
        }

    }

}
