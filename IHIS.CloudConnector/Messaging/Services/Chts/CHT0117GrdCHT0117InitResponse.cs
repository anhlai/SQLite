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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHT0117GrdCHT0117InitResponse")]
  public partial class CHT0117GrdCHT0117InitResponse : global::ProtoBuf.IExtensible
  {
    public CHT0117GrdCHT0117InitResponse() {}
    
    private readonly global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo> _list_item_info = new global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo> list_item_info
    {
      get { return _list_item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
