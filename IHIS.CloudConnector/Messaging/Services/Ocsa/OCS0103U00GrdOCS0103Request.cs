//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U00GrdOCS0103Request")]
  public partial class OCS0103U00GrdOCS0103Request : global::ProtoBuf.IExtensible
  {
    public OCS0103U00GrdOCS0103Request() {}
    
    private string _slip_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"slip_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_code
    {
      get { return _slip_code; }
      set { _slip_code = value; }
    }
    private string _hangmog_inx = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hangmog_inx", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_inx
    {
      get { return _hangmog_inx; }
      set { _hangmog_inx = value; }
    }
    private string _slip_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"slip_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_gubun
    {
      get { return _slip_gubun; }
      set { _slip_gubun = value; }
    }
    private string _used_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"used_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string used_yn
    {
      get { return _used_yn; }
      set { _used_yn = value; }
    }
    private string _wonnae_yn = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"wonnae_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonnae_yn
    {
      get { return _wonnae_yn; }
      set { _wonnae_yn = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _page_number = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"page_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string page_number
    {
      get { return _page_number; }
      set { _page_number = value; }
    }
    private string _offset = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string offset
    {
      get { return _offset; }
      set { _offset = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}