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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHT0117TransactionalRequest")]
  public partial class CHT0117TransactionalRequest : global::ProtoBuf.IExtensible
  {
    public CHT0117TransactionalRequest() {}
    
    private readonly global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo> _list_input1 = new global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list_input1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CHT0117GrdCHT0117InitListItemInfo> list_input1
    {
      get { return _list_input1; }
    }
  
    private readonly global::System.Collections.Generic.List<CHT0117GrdCHT0118InitListItemInfo> _list_input2 = new global::System.Collections.Generic.List<CHT0117GrdCHT0118InitListItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list_input2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CHT0117GrdCHT0118InitListItemInfo> list_input2
    {
      get { return _list_input2; }
    }
  
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
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
