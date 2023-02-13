using UnityEngine;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public static class DataWriterUnityEx
    {
        public static DataWriter Append(this DataWriter self, Vector2 value)
            => self.Append(value.x).Append(value.y);

        public static DataWriter Append(this DataWriter self, Vector2Int value)
            => self.Append(value.x).Append(value.y);

        public static DataWriter Append(this DataWriter self, Vector3 value)
            => self.Append(value.x).Append(value.y).Append(value.z);

        public static DataWriter Append(this DataWriter self, Vector3Int value)
            => self.Append(value.x).Append(value.y).Append(value.z);

        public static DataWriter Append(this DataWriter self, Vector4 value)
            => self.Append(value.x).Append(value.y).Append(value.z).Append(value.w);

        public static DataWriter Append(this DataWriter self, Matrix4x4 value)
            => self.Append(value.GetColumn(0)).Append(value.GetColumn(1)).Append(value.GetColumn(2)).Append(value.GetColumn(3));

        public static DataWriter Append(this DataWriter self, Color value)
            => self.Append(value.r).Append(value.g).Append(value.b).Append(value.a);

        public static DataWriter Append(this DataWriter self, Quaternion value)
            => self.Append(value.x).Append(value.y).Append(value.z).Append(value.w);
    }
}