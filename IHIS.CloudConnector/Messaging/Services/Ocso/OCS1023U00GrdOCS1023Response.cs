//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS1023U00GrdOCS1023Response")]
  public partial class OCS1023U00GrdOCS1023Response : global::ProtoBuf.IExtensible
  {
    public OCS1023U00GrdOCS1023Response() {}
    
    private readonly global::System.Collections.Generic.List<OCS1023U00GrdOCS1023Info> _list_info = new global::System.Collections.Generic.List<OCS1023U00GrdOCS1023Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS1023U00GrdOCS1023Info> list_info
    {
      get { return _list_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
