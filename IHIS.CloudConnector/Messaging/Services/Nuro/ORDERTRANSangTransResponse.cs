//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ORDERTRANSangTransResponse")]
  public partial class ORDERTRANSangTransResponse : global::ProtoBuf.IExtensible
  {
    public ORDERTRANSangTransResponse() {}
    
    private readonly global::System.Collections.Generic.List<ORDERTRANSangTransInfo> _sangtrans_info = new global::System.Collections.Generic.List<ORDERTRANSangTransInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"sangtrans_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ORDERTRANSangTransInfo> sangtrans_info
    {
      get { return _sangtrans_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
