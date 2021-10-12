using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOilCollect
{
    public class Connect
    {
        public string ConnectName { get; set; }
        public bool ConnectState { get; set; }
        public int AddressStart { get; set; }
        public int AddressEnd { get; set; }
        public string Remark { get; set; }
        public ModbusPara ModbusPara { get; set; }       
    }

    public class ModbusPara
    { 
        public string SerialPort { get; set; }
        public TransWay TransWay { get; set; }
        public int BaudRate { get; set; }
        public CheckWay CheckWay { get; set; }
        public int StopBit { get; set; }
    }

    public class Channel
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public ModbusArea ModbusArea { get; set; }
        public int Address { get; set; }
        private int _byteNum;
        public int ByteNum { get { return _byteNum; } set { _byteNum = value; } }
        public int BitNum { get { return 2 * _byteNum; } }
        public int Coeff { get; set; }        
        public bool ReadMul { get; set; }
        public bool WriteMul { get; set; }
        public ModbusType DataType { get; set; }
        public OrderWay ByteOrder { get; set; }
        public OrderWay BitOrder { get; set; }
        public int OutTime { get; set; }
    }

    public enum ModbusArea
    {
        Q,
        I,
        V,
        AI
    }

    public enum ModbusType
    {
        Int16,
        UInt16,
        Int32,
        UInt32,
        Float,
        ASCII,
        UTF8
    }

    public enum OrderWay
    {
        大端,
        小端
    }

    public enum TransWay
    {
        MODBUS_RTU,
        MODBUS_ASCII
    }

    public enum CheckWay
    { 
        None,
        Odd,
        Even
    }


}
