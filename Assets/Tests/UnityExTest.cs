using UnityEngine;
using JuhaKurisu.PopoTools.ByteSerializer;
using NUnit.Framework;

public class UnityExTest
{
    [Test]
    public void Vector2Test()
    {
        var value = new Vector2(2.4f, 3234.4f);
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadVector2();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void Vector2IntTest()
    {
        var value = new Vector2Int(2, -3234);
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadVector2Int();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void Vector3Test()
    {
        var value = new Vector3(2.4f, 3234.4f, 342f);
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadVector3();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void Vector3IntTest()
    {
        var value = new Vector3Int(234, -3234, 3);
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadVector3Int();
        Assert.AreEqual(value, readValue);
    }

    [Test]
    public void Vector4Test()
    {
        var value = new Vector4(2.4f, 3234.4f, -42f, 0);
        DataWriter writer = new DataWriter();
        writer.Puts(value);
        DataReader reader = new DataReader(writer.bytes);
        var readValue = reader.ReadVector4();
        Assert.AreEqual(value, readValue);
    }

}