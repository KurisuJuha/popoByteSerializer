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

    }
}