using JuhaKurisu.PopoTools.ByteSerializer;
using NUnit.Framework;

public class DefaultTest
{
    [Test]
    public void BooleanTest()
    {
        var value = false;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadBoolean();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void ByteTest()
    {
        var value = (byte)12;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadByte();
        Assert.AreEqual(value, readValue);
    }

}
