//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ORDERTRANSSangSendAllInfo")]
  public partial class ORDERTRANSSangSendAllInfo : global::ProtoBuf.IExtensible
  {
    public ORDERTRANSSangSendAllInfo() {}
    
    private string _ifs_key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ifs_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ifs_key
    {
      get { return _ifs_key; }
      set { _ifs_key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
