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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103SaveLayoutRequest")]
  public partial class OCS0103SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public OCS0103SaveLayoutRequest() {}
    
    private readonly global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo> _info_list = new global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"info_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U13GrdOrderListInfo> info_list
    {
      get { return _info_list; }
    }
  
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
