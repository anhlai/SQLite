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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010U00PaqryGrdPaListItemInfo")]
  public partial class CPL2010U00PaqryGrdPaListItemInfo : global::ProtoBuf.IExtensible
  {
    public CPL2010U00PaqryGrdPaListItemInfo() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _suname = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"suname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suname
    {
      get { return _suname; }
      set { _suname = value; }
    }
    private string _in_out_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"in_out_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string in_out_gubun
    {
      get { return _in_out_gubun; }
      set { _in_out_gubun = value; }
    }
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private string _order_time = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"order_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_time
    {
      get { return _order_time; }
      set { _order_time = value; }
    }
    private string _today_yn = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"today_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string today_yn
    {
      get { return _today_yn; }
      set { _today_yn = value; }
    }
    private string _reser_yn = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"reser_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_yn
    {
      get { return _reser_yn; }
      set { _reser_yn = value; }
    }
    private string _doctor_name = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_name
    {
      get { return _doctor_name; }
      set { _doctor_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
