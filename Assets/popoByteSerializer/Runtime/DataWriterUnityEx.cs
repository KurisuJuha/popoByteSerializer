using UnityEngine;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public static class DataWriterUnityEx
    {
        public static DataWriter Puts(this DataWriter self, Vector2 value)
            => self.Puts(value.x).Puts(value.y);

        public static DataWriter Puts(this DataWriter self, Vector2Int value)
            => self.Puts(value.x).Puts(value.y);

        public static DataWriter Puts(this DataWriter self, Vector3 value)
            => self.Puts(value.x).Puts(value.y).Puts(value.z);

        public static DataWriter Puts(this DataWriter self, Vector3Int value)
            => self.Puts(value.x).Puts(value.y).Puts(value.z);

        public static DataWriter Puts(this DataWriter self, Vector4 value)
            => self.Puts(value.x).Puts(value.y).Puts(value.z).Puts(value.w);

        public static DataWriter Puts(this DataWriter self, Matrix4x4 value)
            => self.Puts(value.GetColumn(0)).Puts(value.GetColumn(1)).Puts(value.GetColumn(2)).Puts(value.GetColumn(3));

        public static DataWriter Puts(this DataWriter self, Color value)
            => self.Puts(value.r).Puts(value.g).Puts(value.b).Puts(value.a);
    }
}