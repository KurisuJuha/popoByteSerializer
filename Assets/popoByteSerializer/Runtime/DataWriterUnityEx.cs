using UnityEngine;

namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public static class DataWriterUnityEx
    {
        public static DataWriter Puts(this DataWriter self, Vector2 value)
            => self.Puts(value.x).Puts(value.y);

        public static DataWriter Puts(this DataWriter self, Vector2Int value)
            => self.Puts(value.x).Puts(value.y);

    }
}