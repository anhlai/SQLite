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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadSearchOrder1RequestInfo")]
  public partial class LoadSearchOrder1RequestInfo : global::ProtoBuf.IExtensible
  {
    public LoadSearchOrder1RequestInfo() {}
    
    private string _search_word = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"search_word", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string search_word
    {
      get { return _search_word; }
      set { _search_word = value; }
    }
    private string _gijun_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gijun_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gijun_date
    {
      get { return _gijun_date; }
      set { _gijun_date = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private string _wonnae_drg_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"wonnae_drg_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonnae_drg_yn
    {
      get { return _wonnae_drg_yn; }
      set { _wonnae_drg_yn = value; }
    }
    private string _page_number = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"page_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string page_number
    {
      get { return _page_number; }
      set { _page_number = value; }
    }
    private string _offset = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string offset
    {
      get { return _offset; }
      set { _offset = value; }
    }
    private string _protocol_id = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"protocol_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string protocol_id
    {
      get { return _protocol_id; }
      set { _protocol_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
