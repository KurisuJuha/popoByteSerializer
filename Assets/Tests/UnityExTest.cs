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

}