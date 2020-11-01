using System;

namespace UM_Monitor
{
    public class CMData
    {
        public DateTime Timestamp = DateTime.Now;

        public int ModelId;

        public double Voltage;
        public double Amperage;
        public double Wattage;

        public double TemperatureC;
        public double TemperatureF;

        public int DataGroupIndex;

        public double UsbPos;
        public double UsbNeg;


        public int ChargingMode;



        public CMData(byte[] data)
        {
            if (data.Length == 130)
            {
                this.Voltage = 256 * data[2] + data[3];
                this.Voltage /= 100;

                this.Amperage = 256 * data[4] + data[5];
                this.Amperage /= 1000;

                this.Wattage = 1024 * data[6] + 512 * data[7] + 256 * data[8] + data[9];
                this.Wattage /= 1000;

                this.TemperatureC = 256 * data[10] + data[11];
                this.TemperatureF = 256 * data[12] + data[13];

                this.UsbPos = 256 * data[96] + data[97];
                this.UsbPos /= 100;

                this.UsbNeg = 256 * data[98] + data[99];
                this.UsbNeg /= 100;

                this.ChargingMode = 256 * data[100] + data[101];



                //if (this.Voltage > 6
                //    || this.Amperage > 2)
                //{
                //    throw new Exception();
                //}
            }
            else
            { }
        }

    }
}
