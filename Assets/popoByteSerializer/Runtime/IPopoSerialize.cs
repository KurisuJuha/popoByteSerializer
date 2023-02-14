namespace JuhaKurisu.PopoTools.ByteSerializer
{
    public interface IpopoSerialize
    {
        public void Serialize(DataWriter writer);
        public void Deserialize(DataReader reader);
    }
}