//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadSearchOrderInfo")]
  public partial class LoadSearchOrderInfo : global::ProtoBuf.IExtensible
  {
    public LoadSearchOrderInfo() {}
    
    private string _slip_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"slip_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_code
    {
      get { return _slip_code; }
      set { _slip_code = value; }
    }
    private string _slip_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"slip_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_name
    {
      get { return _slip_name; }
      set { _slip_name = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _hangmog_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hangmog_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_name
    {
      get { return _hangmog_name; }
      set { _hangmog_name = value; }
    }
    private string _wonnae_drg_yn = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"wonnae_drg_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonnae_drg_yn
    {
      get { return _wonnae_drg_yn; }
      set { _wonnae_drg_yn = value; }
    }
    private string _yak_kijun_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"yak_kijun_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yak_kijun_code
    {
      get { return _yak_kijun_code; }
      set { _yak_kijun_code = value; }
    }
    private string _trial_flag = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"trial_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string trial_flag
    {
      get { return _trial_flag; }
      set { _trial_flag = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
