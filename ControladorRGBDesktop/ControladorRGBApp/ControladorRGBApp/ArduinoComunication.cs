using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Management;

namespace ControladorRGBApp
{
    class ArduinoComunication
    {
        SerialPort serialPort;
        string message;
        bool sensorExisting = false;
        public ArduinoComunication()
        {
        }
        public bool IsSensorConected
        {
            get { return sensorExisting; }
        }
        public void initializeSensor(int portNum,string[] ports)
        {
            serialPort = new SerialPort();
            if (ports.Length <= 0)
            {
                sensorExisting = false;
                message = "Arduino no detectado";
                SensorNotFoundExceptio ex = new SensorNotFoundExceptio(message);
                throw ex;
            }
            else
            {
                sensorExisting = true;
                serialPort.PortName = ports[portNum];
                serialPort.BaudRate = 9600;

                try
                {
                    serialPort.Open();
                }
                catch (Exception e)
                {
                    message = "No se pudo establecer comunicacion con el arduino";
                    SensorNotFoundExceptio ex = new SensorNotFoundExceptio(message);
                    throw ex;
                }
            }
        }
        public string[] ExistingPorts()
        {
            //string[] ports = SerialPort.GetPortNames();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length > 0)
            {
                using (var searcher = new ManagementObjectSearcher
                    ("SELECT * FROM WIN32_SerialPort"))
                {

                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                    var tList = (from n in portnames
                                 join p in ports on n equals p["DeviceID"].ToString()
                                 select n + " - " + p["Caption"]).ToList();
                    return tList.ToArray();


                }
            }
            else
            {
                message = "Arduino no detectado";
                SensorNotFoundExceptio ex = new SensorNotFoundExceptio(message);
                throw ex;
            }
        }
        public string[] ExistingPortsOnly()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length <= 0)
            {
                sensorExisting = false;
                message = "Arduino no detectado";
                SensorNotFoundExceptio ex = new SensorNotFoundExceptio(message);
                throw ex;
            }
            else
            {
                return ports;
            }
        }
        public string getErrorMessage()
        {
            return message;
        }
        public void Dispose()
        {
            serialPort.Dispose();
        }
        public void WriteColorRGB(Int16 r, Int16 g, Int16 b)
        {
            string rgb = r.ToString() + "," + g.ToString() + "," + b.ToString() + ",";
            try
            {
                serialPort.Write(rgb);
            }
            catch (Exception e)
            {
                message = "Error al escribir";
                SensorNotFoundExceptio ex = new SensorNotFoundExceptio(message);
                throw ex;
            }
        }
    }
}
