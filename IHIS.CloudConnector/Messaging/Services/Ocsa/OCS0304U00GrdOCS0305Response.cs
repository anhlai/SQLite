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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0304U00GrdOCS0305Response")]
  public partial class OCS0304U00GrdOCS0305Response : global::ProtoBuf.IExtensible
  {
    public OCS0304U00GrdOCS0305Response() {}
    
    private readonly global::System.Collections.Generic.List<OcsaOCS0304U00GrdOCS0305ListInfo> _list_info = new global::System.Collections.Generic.List<OcsaOCS0304U00GrdOCS0305ListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsaOCS0304U00GrdOCS0305ListInfo> list_info
    {
      get { return _list_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
