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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0203U00GrdOcs0203P1Info")]
  public partial class OCS0203U00GrdOcs0203P1Info : global::ProtoBuf.IExtensible
  {
    public OCS0203U00GrdOcs0203P1Info() {}
    
    private string _memb = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"memb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb
    {
      get { return _memb; }
      set { _memb = value; }
    }
    private string _slip_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"slip_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_code
    {
      get { return _slip_code; }
      set { _slip_code = value; }
    }
    private string _value_999 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"value_999", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value_999
    {
      get { return _value_999; }
      set { _value_999 = value; }
    }
    private string _n_value = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"n_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string n_value
    {
      get { return _n_value; }
      set { _n_value = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _hangmog_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hangmog_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_name
    {
      get { return _hangmog_name; }
      set { _hangmog_name = value; }
    }
    private string _bulyong_yn = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bulyong_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bulyong_yn
    {
      get { return _bulyong_yn; }
      set { _bulyong_yn = value; }
    }
    private string _new_flag = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"new_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string new_flag
    {
      get { return _new_flag; }
      set { _new_flag = value; }
    }
    private string _seq = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq
    {
      get { return _seq; }
      set { _seq = value; }
    }
    private string _often_used = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"often_used", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string often_used
    {
      get { return _often_used; }
      set { _often_used = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}