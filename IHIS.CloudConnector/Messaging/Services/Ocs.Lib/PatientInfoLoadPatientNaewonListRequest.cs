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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatientInfoLoadPatientNaewonListRequest")]
  public partial class PatientInfoLoadPatientNaewonListRequest : global::ProtoBuf.IExtensible
  {
    public PatientInfoLoadPatientNaewonListRequest() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _naewon_date_base = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"naewon_date_base", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date_base
    {
      get { return _naewon_date_base; }
      set { _naewon_date_base = value; }
    }
    private string _approve_doctor = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"approve_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string approve_doctor
    {
      get { return _approve_doctor; }
      set { _approve_doctor = value; }
    }
    private string _doctor_mode_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"doctor_mode_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_mode_yn
    {
      get { return _doctor_mode_yn; }
      set { _doctor_mode_yn = value; }
    }
    private string _io_gubun = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"io_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_gubun
    {
      get { return _io_gubun; }
      set { _io_gubun = value; }
    }
    private string _pk_key_out = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"pk_key_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_key_out
    {
      get { return _pk_key_out; }
      set { _pk_key_out = value; }
    }
    private string _naewon_date = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _jaewon_flag = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"jaewon_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jaewon_flag
    {
      get { return _jaewon_flag; }
      set { _jaewon_flag = value; }
    }
    private string _pk_key_inp = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"pk_key_inp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_key_inp
    {
      get { return _pk_key_inp; }
      set { _pk_key_inp = value; }
    }
    private string _is_enable_ipwon_reser = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"is_enable_ipwon_reser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string is_enable_ipwon_reser
    {
      get { return _is_enable_ipwon_reser; }
      set { _is_enable_ipwon_reser = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
