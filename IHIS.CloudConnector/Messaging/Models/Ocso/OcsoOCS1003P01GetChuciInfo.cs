//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01GetChuciInfo")]
  public partial class OcsoOCS1003P01GetChuciInfo : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01GetChuciInfo() {}
    
    private string _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _group_key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"group_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string group_key
    {
      get { return _group_key; }
      set { _group_key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
