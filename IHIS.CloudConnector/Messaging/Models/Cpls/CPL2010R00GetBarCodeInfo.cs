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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010R00GetBarCodeInfo")]
  public partial class CPL2010R00GetBarCodeInfo : global::ProtoBuf.IExtensible
  {
    public CPL2010R00GetBarCodeInfo() {}
    
    private string _jundal_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"jundal_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_gubun
    {
      get { return _jundal_gubun; }
      set { _jundal_gubun = value; }
    }
    private string _jundal_gubun_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"jundal_gubun_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_gubun_name
    {
      get { return _jundal_gubun_name; }
      set { _jundal_gubun_name = value; }
    }
    private string _specimen_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"specimen_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_code
    {
      get { return _specimen_code; }
      set { _specimen_code = value; }
    }
    private string _specimen_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"specimen_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_name
    {
      get { return _specimen_name; }
      set { _specimen_name = value; }
    }
    private string _tube_code = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tube_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tube_code
    {
      get { return _tube_code; }
      set { _tube_code = value; }
    }
    private string _tube_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tube_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tube_name
    {
      get { return _tube_name; }
      set { _tube_name = value; }
    }
    private string _in_out_gubun = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"in_out_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string in_out_gubun
    {
      get { return _in_out_gubun; }
      set { _in_out_gubun = value; }
    }
    private string _specimen_ser = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"specimen_ser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_ser
    {
      get { return _specimen_ser; }
      set { _specimen_ser = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _suname = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"suname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suname
    {
      get { return _suname; }
      set { _suname = value; }
    }
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private string _danger_yn = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"danger_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string danger_yn
    {
      get { return _danger_yn; }
      set { _danger_yn = value; }
    }
    private string _specimen_ser_ba = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"specimen_ser_ba", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_ser_ba
    {
      get { return _specimen_ser_ba; }
      set { _specimen_ser_ba = value; }
    }
    private string _jangbi_code = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"jangbi_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jangbi_code
    {
      get { return _jangbi_code; }
      set { _jangbi_code = value; }
    }
    private string _jangbi_name = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"jangbi_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jangbi_name
    {
      get { return _jangbi_name; }
      set { _jangbi_name = value; }
    }
    private string _gumsa_name_re = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"gumsa_name_re", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gumsa_name_re
    {
      get { return _gumsa_name_re; }
      set { _gumsa_name_re = value; }
    }
    private string _tube_count = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"tube_count", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tube_count
    {
      get { return _tube_count; }
      set { _tube_count = value; }
    }
    private string _tube_max_amt = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"tube_max_amt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tube_max_amt
    {
      get { return _tube_max_amt; }
      set { _tube_max_amt = value; }
    }
    private string _tube_numbering = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"tube_numbering", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tube_numbering
    {
      get { return _tube_numbering; }
      set { _tube_numbering = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
