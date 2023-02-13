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

    [Test]
    public void SByteTest()
    {
        var value = (sbyte)-12;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadSByte();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void ShortTest()
    {
        var value = (short)-1233;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadShort();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void UShortTest()
    {
        var value = (ushort)123;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadUShort();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void IntTest()
    {
        var value = (int)-12;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadInt();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void UIntTest()
    {
        var value = (uint)1344342;
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadUInt();
        Assert.AreEqual(value, readValue);
    }

}
