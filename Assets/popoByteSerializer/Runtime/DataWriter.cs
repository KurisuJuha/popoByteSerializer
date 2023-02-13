using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public class DataWriter
    {
        public ReadOnlyCollection<byte> bytes => byteList.AsReadOnly();
        private List<byte> byteList = new List<byte>();

        public DataWriter Append(Boolean value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Byte value)
        {
            byteList.Add(value);
            return this;
        }

        public DataWriter Append(SByte value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Int16 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(UInt16 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Int32 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(UInt32 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Int64 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(UInt64 value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Char value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Single value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(Double value)
        {
            byteList.AddRange(BitConverter.GetBytes(value));
            return this;
        }

        public DataWriter Append(byte[] bytes)
        {
            foreach (var b in bytes) Append(b);

            return this;
        }

        public DataWriter AppendWithLength(byte[] bytes)
        {
            Append(bytes.Length);
            Append(bytes);
            return this;
        }

    }
}