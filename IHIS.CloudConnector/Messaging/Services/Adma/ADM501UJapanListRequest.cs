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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADM501UJapanListRequest")]
  public partial class ADM501UJapanListRequest : global::ProtoBuf.IExtensible
  {
    public ADM501UJapanListRequest() {}
    
    private string _msg_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg_gubun
    {
      get { return _msg_gubun; }
      set { _msg_gubun = value; }
    }
    private string _search_msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"search_msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string search_msg
    {
      get { return _search_msg; }
      set { _search_msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
