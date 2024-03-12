using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System.Windows.Forms;

namespace ModdusTCP
{
    public partial class Form1 : Form
    {
        TcpClient client;
        ModbusIpMaster master;
        bool value = true;
        ushort[] coil_addres = { 100, 101, 102, 103 };



        public Form1()
        {
            InitializeComponent();
            _disconnect.Enabled = false;


        }
        

        // bind the listening socket to the port


        private void Form1_Load(object sender, EventArgs e)
        {
            _cpanel.Enabled = false;


        }
        private void button2_Click(object sender, EventArgs e)
        {
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(Ip_box.Text, Convert.ToInt32(port_box.Text));
                master = ModbusIpMaster.CreateIp(client);
                _status.ForeColor = Color.Green;
                _status.Text = "Conected";
                _disconnect.Enabled = true;
                button3.Enabled = false;
                req_timer.Start();
                _cpanel.Enabled = true;
                _status.Text = "Conected";

            }
            catch
            {
                _status.ForeColor = Color.Red;
                _status.Text = "Not Conected";
                _disconnect.Enabled = false;
                button3.Enabled = true;
            }
            
           
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            try {
                master.Dispose();
                client.Dispose();
                _disconnect.Enabled = false;
                button3.Enabled = true;
                req_timer.Stop();
                _cpanel.Enabled = false;
                _status.Text = "Disconnect";
            } catch (Exception) { 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[2], false);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[0],true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[1], true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[2], true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[3], true);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[0], false);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[1], false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(coil_addres[3], false);
        }

        private void req_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                bool[] di_sensor = master.ReadInputs(100, 1);
                ushort[] reg_sensor = master.ReadHoldingRegisters(50, 1);
                p_sensor.Text = di_sensor[0].ToString();
                _temp.Text = reg_sensor[0].ToString();
            }
            catch (Exception) { }
           
        }
    }
    }

