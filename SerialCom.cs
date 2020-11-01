namespace UM_Monitor
{
    using System;
    using System.Collections.Generic;
    using System.IO.Ports;


    internal static class SerialCom
    {
        private static SerialPort port;

        private static readonly List<byte> response;

        private static Action<byte[]> _callback;


        static SerialCom()
        {
            response = new List<byte>();
        }


        public static bool Connect(string comport)
        {
            if (port != null)
            {
                Disconnect();
            }


            try
            {
                port = new SerialPort(comport, 9600, Parity.None, 8, StopBits.One);

                port.WriteTimeout = 250;
                port.ReadTimeout = 250;

                // Attach a method to be called when there
                // is data waiting in the port's buffer
                port.DataReceived += Port_DataReceived;

                // Begin communications
                port.Open();
            }
            catch (Exception ex)
            {
                Disconnect();
                return false;
            }

            return true;
        }

        public static bool Disconnect()
        {
            port.Close();
            port.Dispose();
            return true;
        }

        public static bool IsConnected
        {
            get { return port != null && port.IsOpen; }
        }

        private static void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort port = (System.IO.Ports.SerialPort)sender;
            int count = port.BytesToRead;
            byte[] data = new byte[count];
            port.Read(data, 0, data.Length);

            try
            {
                response.AddRange(data);
            }
            catch { }

            if (response.Count == 130)
                CompleteAnswerReceived();
        }

        private static void CompleteAnswerReceived()
        {
            _callback.Invoke(response.ToArray());
            response.Clear();
        }


        private static void writeBytes(byte[] data)
        {
            try
            {
                port.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            { }
        }



        public static void GetStatus(Action<byte[]> callback)
        {
            if (!IsConnected)
                return;

            _callback = callback;

            response.Clear();

            writeBytes(new byte[] { 0xF0 });
        }


        public static void ScreenNext()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF1 });
        }

        public static void ScreenRotate()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF2 });
        }

        public static void GroupNext()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF3 });
        }

        public static void GroupClear()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF4 });
        }

        public static void f5()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF5 });
        }

        public static void f6()
        {
            if (!IsConnected)
                return;

            writeBytes(new byte[] { 0xF6 });
        }
    }
}
