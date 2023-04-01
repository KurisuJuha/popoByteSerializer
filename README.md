# popoByteSerializer

[![openupm](https://img.shields.io/npm/v/jp.juhakurisu.popobyteserializer?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/jp.juhakurisu.popobyteserializer/) [![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

## 概要

popoByteSerializerは、情報のByteシリアライズをサポートします。Byte配列へ変換する拡張メソッドが26種類追加されます。

## 特徴

- .NET標準ライブラリに内包するクラスだけでなく、Unityのクラスもシリアライズ可能
- 独自クラスをシリアライズする拡張メソッドを記述可能

## 要件

- Unity 2021.3以上

## インストール

``` cli
openupm add jp.juhakurisu.popobyteserializer
```

## 使用方法

``` csharp
using System.Linq;
using UnityEngine;
using JuhaKurisu.PopoTools.ByteSerializer;

public class Example : Monobehaviour
{
    private void Start()
    {
        DataWriter writer = new DataWriter();

        writer.Append(334);                             // Appendメソッドでwriter内部のbyte配列に追加
        writer.Append("nhk")                            // 文字列も追加可能    
        writer.Append(new Vector2(33f, 4f));            // 当然Vector2も可能

        byte[] bytes = writer.bytes.ToArray();          // 実際のデータはwriter内のbytesから取得可能

        DataReader reader = new DataReader();

        int intValue = reader.ReadInt();                // int型はReadIntで取得できる
        string stringValue = reader.ReadString();       // 型によってそれぞれ関数が用意されている
        Vector2 vector2Value = reader.ReadVector2();    // Read処理は追加した順番と同じ順番で実行しなければならない
    }
}
```

## 読み書き可能な型

- bool
- byte
- sbyte
- short
- ushort
- int
- uint
- long
- ulong
- char
- float
- double
- byte[]
- string
- Guid
- DataWriter
- DataReader
- Vector2
- Vector2Int
- Vector3
- Vector3Int
- Vector4
- Matrix4x4
- Color
- Quaternion

## ライセンス

[MIT License](LICENSE)
