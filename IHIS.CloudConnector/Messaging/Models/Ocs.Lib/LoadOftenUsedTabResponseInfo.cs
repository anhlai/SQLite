//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadOftenUsedTabResponseInfo")]
  public partial class LoadOftenUsedTabResponseInfo : global::ProtoBuf.IExtensible
  {
    public LoadOftenUsedTabResponseInfo() {}
    
    private string _order_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun
    {
      get { return _order_gubun; }
      set { _order_gubun = value; }
    }
    private string _order_gubun_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order_gubun_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun_name
    {
      get { return _order_gubun_name; }
      set { _order_gubun_name = value; }
    }
    private string _memb = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"memb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb
    {
      get { return _memb; }
      set { _memb = value; }
    }
    private string _yn_value = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"yn_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yn_value
    {
      get { return _yn_value; }
      set { _yn_value = value; }
    }
    private string _sort = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"sort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sort
    {
      get { return _sort; }
      set { _sort = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}