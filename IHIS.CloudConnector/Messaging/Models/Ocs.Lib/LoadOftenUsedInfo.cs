//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ocs.lib_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadOftenUsedInfo")]
  public partial class LoadOftenUsedInfo : global::ProtoBuf.IExtensible
  {
    public LoadOftenUsedInfo() {}
    
    private string _memb_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"memb_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb_gubun
    {
      get { return _memb_gubun; }
      set { _memb_gubun = value; }
    }
    private string _memb = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"memb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb
    {
      get { return _memb; }
      set { _memb = value; }
    }
    private string _order_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"order_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun
    {
      get { return _order_gubun; }
      set { _order_gubun = value; }
    }
    private string _wonnae_drg_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"wonnae_drg_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonnae_drg_yn
    {
      get { return _wonnae_drg_yn; }
      set { _wonnae_drg_yn = value; }
    }
    private string _search_word = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"search_word", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string search_word
    {
      get { return _search_word; }
      set { _search_word = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
