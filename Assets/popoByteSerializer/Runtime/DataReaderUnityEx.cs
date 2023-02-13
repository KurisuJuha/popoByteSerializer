using UnityEngine;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public static class DataReaderUnityEx
    {
        public static Vector2 ReadVector2(this DataReader self)
            => new Vector2(self.ReadFloat(), self.ReadFloat());

    }
}