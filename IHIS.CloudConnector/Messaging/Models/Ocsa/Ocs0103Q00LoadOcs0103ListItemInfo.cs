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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Ocs0103Q00LoadOcs0103ListItemInfo")]
  public partial class Ocs0103Q00LoadOcs0103ListItemInfo : global::ProtoBuf.IExtensible
  {
    public Ocs0103Q00LoadOcs0103ListItemInfo() {}
    
    private string _order_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun
    {
      get { return _order_gubun; }
      set { _order_gubun = value; }
    }
    private string _slip_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"slip_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_code
    {
      get { return _slip_code; }
      set { _slip_code = value; }
    }
    private string _slip_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"slip_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_name
    {
      get { return _slip_name; }
      set { _slip_name = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _hangmog_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"hangmog_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_name
    {
      get { return _hangmog_name; }
      set { _hangmog_name = value; }
    }
    private string _sg_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sg_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sg_code
    {
      get { return _sg_code; }
      set { _sg_code = value; }
    }
    private string _bulyong_check = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bulyong_check", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bulyong_check
    {
      get { return _bulyong_check; }
      set { _bulyong_check = value; }
    }
    private string _wonnae_drg_yn = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"wonnae_drg_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonnae_drg_yn
    {
      get { return _wonnae_drg_yn; }
      set { _wonnae_drg_yn = value; }
    }
    private string _select_yn = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"select_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string select_yn
    {
      get { return _select_yn; }
      set { _select_yn = value; }
    }
    private string _input_control = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"input_control", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_control
    {
      get { return _input_control; }
      set { _input_control = value; }
    }
    private string _bun_code = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"bun_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bun_code
    {
      get { return _bun_code; }
      set { _bun_code = value; }
    }
    private string _seq = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq
    {
      get { return _seq; }
      set { _seq = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
