using System;
namespace Utility
{
    public class ReadSerialPortData
    {
        public ReadSerialPortData()
        {
        }
        public double ReadSerialPortCommunication()
        {
            double ReadSerialPortValue = 0.00;
            try
            {
                string str;
                /* Uncomment After developement complete                 */
      
               HyperTerminalAdapter ht = new HyperTerminalAdapter();
                ht.Connect();
                str = ht.ReadSerialPort().Replace("\u0002", "").Replace("\u0003", "").Replace("\r", "");
                if (double.TryParse(str, out ReadSerialPortValue))
                    return ReadSerialPortValue;
                return ReadSerialPortValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
