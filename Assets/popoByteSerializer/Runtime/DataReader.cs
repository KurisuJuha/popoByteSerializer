using System;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public class DataReader
    {
        public ReadOnlyCollection<byte> bytes => Array.AsReadOnly(byteArray);
        public int position { get; private set; }

        private readonly byte[] byteArray;

        public DataReader(byte[] bytes)
        {
            byteArray = bytes;
        }

        public bool ReadBoolean()
            => BitConverter.ToBoolean(new byte[] { ReadByte() }, 0);

        public Byte ReadByte()
            => bytes[position++ - 1];

        public SByte ReadSByte()
            => (sbyte)ReadByte();

        public Int16 ReadInt16()
            => BitConverter.ToInt16(ReadBytes(2), 0);

        public UInt16 ReadUInt16()
            => BitConverter.ToUInt16(ReadBytes(2), 0);

        public Int32 ReadInt32()
            => BitConverter.ToInt32(ReadBytes(4), 0);

        public UInt32 ReadUInt32()
            => BitConverter.ToUInt32(ReadBytes(4), 0);

        public Int64 ReadInt64()
            => BitConverter.ToInt64(ReadBytes(8), 0);

    }
}