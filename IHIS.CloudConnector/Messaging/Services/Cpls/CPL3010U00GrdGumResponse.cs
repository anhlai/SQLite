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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3010U00GrdGumResponse")]
  public partial class CPL3010U00GrdGumResponse : global::ProtoBuf.IExtensible
  {
    public CPL3010U00GrdGumResponse() {}
    
    private readonly global::System.Collections.Generic.List<CPL3010U00GrdGumListItemInfo> _grd_gum_item = new global::System.Collections.Generic.List<CPL3010U00GrdGumListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_gum_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL3010U00GrdGumListItemInfo> grd_gum_item
    {
      get { return _grd_gum_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
