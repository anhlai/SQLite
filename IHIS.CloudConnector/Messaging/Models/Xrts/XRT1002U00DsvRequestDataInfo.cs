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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"XRT1002U00DsvRequestDataInfo")]
  public partial class XRT1002U00DsvRequestDataInfo : global::ProtoBuf.IExtensible
  {
    public XRT1002U00DsvRequestDataInfo() {}
    
    private string _fkocs = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"fkocs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkocs
    {
      get { return _fkocs; }
      set { _fkocs = value; }
    }
    private string _in_out_gubun = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"in_out_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string in_out_gubun
    {
      get { return _in_out_gubun; }
      set { _in_out_gubun = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _gumsa_mokjuk = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"gumsa_mokjuk", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gumsa_mokjuk
    {
      get { return _gumsa_mokjuk; }
      set { _gumsa_mokjuk = value; }
    }
    private string _xray_method = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"xray_method", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string xray_method
    {
      get { return _xray_method; }
      set { _xray_method = value; }
    }
    private string _pandok_request_yn = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"pandok_request_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pandok_request_yn
    {
      get { return _pandok_request_yn; }
      set { _pandok_request_yn = value; }
    }
    private string _buha_gubun = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"buha_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buha_gubun
    {
      get { return _buha_gubun; }
      set { _buha_gubun = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
