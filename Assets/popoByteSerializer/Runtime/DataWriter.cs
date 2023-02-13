using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public class DataWriter
    {
        public ReadOnlyCollection<byte> bytes => byteList.AsReadOnly();
        private List<byte> byteList = new List<byte>();

        public DataWriter Puts(Boolean value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(Byte value)
        {
            byteList.Add(value);
            return this;
        }

        public DataWriter Puts(SByte value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(Int16 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(UInt16 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(Int32 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(UInt32 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Puts(Int64 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }
    }
}