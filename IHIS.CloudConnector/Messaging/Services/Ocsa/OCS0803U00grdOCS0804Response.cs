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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0803U00grdOCS0804Response")]
  public partial class OCS0803U00grdOCS0804Response : global::ProtoBuf.IExtensible
  {
    public OCS0803U00grdOCS0804Response() {}
    
    private readonly global::System.Collections.Generic.List<OCS0803U00grdOCS0804ItemInfo> _item_info = new global::System.Collections.Generic.List<OCS0803U00grdOCS0804ItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0803U00grdOCS0804ItemInfo> item_info
    {
      get { return _item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
