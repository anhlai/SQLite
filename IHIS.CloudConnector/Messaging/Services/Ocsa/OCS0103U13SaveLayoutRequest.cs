//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U13SaveLayoutRequest")]
  public partial class OCS0103U13SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public OCS0103U13SaveLayoutRequest() {}
    
    private readonly global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo> _list_item_info = new global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo> list_item_info
    {
      get { return _list_item_info; }
    }
  
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private readonly global::System.Collections.Generic.List<DataStringListItemInfo> _row_state = new global::System.Collections.Generic.List<DataStringListItemInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DataStringListItemInfo> row_state
    {
      get { return _row_state; }
    }
  
    private string _caller_id = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"caller_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caller_id
    {
      get { return _caller_id; }
      set { _caller_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}