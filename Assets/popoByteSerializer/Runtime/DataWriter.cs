using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public class DataWriter
    {
        public ReadOnlyCollection<byte> bytes => byteList.AsReadOnly();
        private List<byte> byteList = new List<byte>();

    }
}