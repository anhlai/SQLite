//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: adma_service.proto
// Note: requires additional types generated from: adma_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADM201UGrdDicMasterResponse")]
  public partial class ADM201UGrdDicMasterResponse : global::ProtoBuf.IExtensible
  {
    public ADM201UGrdDicMasterResponse() {}
    
    private readonly global::System.Collections.Generic.List<ADM201UGrdDicMasterItemInfo> _grd_dic_master_item_info = new global::System.Collections.Generic.List<ADM201UGrdDicMasterItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_dic_master_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ADM201UGrdDicMasterItemInfo> grd_dic_master_item_info
    {
      get { return _grd_dic_master_item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
