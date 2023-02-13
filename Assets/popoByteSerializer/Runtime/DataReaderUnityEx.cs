using UnityEngine;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public static class DataReaderUnityEx
    {
        public static Vector2 ReadVector2(this DataReader self)
            => new Vector2(self.ReadFloat(), self.ReadFloat());

        public static Vector2Int ReadVector2Int(this DataReader self)
            => new Vector2Int(self.ReadInt(), self.ReadInt());

        public static Vector3 ReadVector3(this DataReader self)
            => new Vector3(self.ReadFloat(), self.ReadFloat(), self.ReadFloat());

        public static Vector3Int ReadVector3Int(this DataReader self)
            => new Vector3Int(self.ReadInt(), self.ReadInt(), self.ReadInt());

    }
}