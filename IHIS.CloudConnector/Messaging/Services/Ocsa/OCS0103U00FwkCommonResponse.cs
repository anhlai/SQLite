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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U00FwkCommonResponse")]
  public partial class OCS0103U00FwkCommonResponse : global::ProtoBuf.IExtensible
  {
    public OCS0103U00FwkCommonResponse() {}
    
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _combo_item = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"combo_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> combo_item
    {
      get { return _combo_item; }
    }
  
    private readonly global::System.Collections.Generic.List<OCS0103U00FwkCommonInfo> _fwk_item = new global::System.Collections.Generic.List<OCS0103U00FwkCommonInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"fwk_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U00FwkCommonInfo> fwk_item
    {
      get { return _fwk_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
