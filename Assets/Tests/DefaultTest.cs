using JuhaKurisu.PopoTools.ByteSerializer;
using NUnit.Framework;

public class DefaultTest
{
    [Test]
    public void BooleanTest()
    {
        var value = false;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadBoolean();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void ByteTest()
    {
        var value = (byte)12;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadByte();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void SByteTest()
    {
        var value = (sbyte)-12;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadSByte();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void ShortTest()
    {
        var value = (short)-1233;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadShort();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void UShortTest()
    {
        var value = (ushort)123;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadUShort();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void IntTest()
    {
        var value = (int)-12;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadInt();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void UIntTest()
    {
        var value = (uint)1344342;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadUInt();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void LongTest()
    {
        var value = (long)-232333312;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadLong();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void ULongTest()
    {
        var value = (ulong)12312312;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadULong();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void CharTest()
    {
        var value = 't';
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadChar();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void FloatTest()
    {
        var value = 123.4f;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadFloat();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void DoubleTest()
    {
        var value = -12423423442.4324d;
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadDouble();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void BytesTest()
    {
        var value = new byte[] { 23, 43, 66, 23, 2, 0 };
        DataWriter writer = new DataWriter();
        writer.Append(value.Length);
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadBytes(reader.ReadInt());
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void BytesWithLengthTest()
    {
        var value = new byte[] { 23, 43, 66, 23, 2, 0 };
        DataWriter writer = new DataWriter();
        writer.AppendWithLength(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadBytes();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void StringTest()
    {
        var value = "new byte[] { 23, 43, 66, 23, 2, 0 }";
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadString();
        Assert.AreEqual(value, readValue);
    }

    [Test]

    public void GuidTest()
    {
        var value = System.Guid.NewGuid();
        DataWriter writer = new DataWriter();
        writer.Append(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadGuid();
        Assert.AreEqual(value, readValue);
    }
}
