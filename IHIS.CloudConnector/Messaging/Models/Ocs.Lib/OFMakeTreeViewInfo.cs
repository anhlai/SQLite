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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OFMakeTreeViewInfo")]
  public partial class OFMakeTreeViewInfo : global::ProtoBuf.IExtensible
  {
    public OFMakeTreeViewInfo() {}
    
    private string _memb = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"memb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb
    {
      get { return _memb; }
      set { _memb = value; }
    }
    private string _pk_seq = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pk_seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_seq
    {
      get { return _pk_seq; }
      set { _pk_seq = value; }
    }
    private string _yaksok_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"yaksok_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yaksok_gubun
    {
      get { return _yaksok_gubun; }
      set { _yaksok_gubun = value; }
    }
    private string _yaksok_gubun_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"yaksok_gubun_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yaksok_gubun_name
    {
      get { return _yaksok_gubun_name; }
      set { _yaksok_gubun_name = value; }
    }
    private string _seq = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq
    {
      get { return _seq; }
      set { _seq = value; }
    }
    private string _memb_gubun = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"memb_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb_gubun
    {
      get { return _memb_gubun; }
      set { _memb_gubun = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private string _exist_data = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"exist_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string exist_data
    {
      get { return _exist_data; }
      set { _exist_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
