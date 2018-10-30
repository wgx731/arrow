// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::FlatBuffers;

/// ----------------------------------------------------------------------
/// user defined key value pairs to add custom metadata to arrow
/// key namespacing is the responsibility of the user
public struct KeyValue : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb) { return GetRootAsKeyValue(_bb, new KeyValue()); }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb, KeyValue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public KeyValue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Key { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetKeyBytes() { return __p.__vector_as_arraysegment(4); }
  public string Value { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(6); }

  public static Offset<KeyValue> CreateKeyValue(FlatBufferBuilder builder,
      StringOffset keyOffset = default(StringOffset),
      StringOffset valueOffset = default(StringOffset)) {
    builder.StartObject(2);
    KeyValue.AddValue(builder, valueOffset);
    KeyValue.AddKey(builder, keyOffset);
    return KeyValue.EndKeyValue(builder);
  }

  public static void StartKeyValue(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset) { builder.AddOffset(0, keyOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset) { builder.AddOffset(1, valueOffset.Value, 0); }
  public static Offset<KeyValue> EndKeyValue(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<KeyValue>(o);
  }
};


}