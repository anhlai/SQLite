//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS1003Q02GridOUT1001Info")]
  public partial class OCS1003Q02GridOUT1001Info : global::ProtoBuf.IExtensible
  {
    public OCS1003Q02GridOUT1001Info() {}
    
    private string _jubsu = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"jubsu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu
    {
      get { return _jubsu; }
      set { _jubsu = value; }
    }
    private string _reser_yn = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reser_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_yn
    {
      get { return _reser_yn; }
      set { _reser_yn = value; }
    }
    private string _jinryo_time = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"jinryo_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jinryo_time
    {
      get { return _jinryo_time; }
      set { _jinryo_time = value; }
    }
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private string _doctor_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_name
    {
      get { return _doctor_name; }
      set { _doctor_name = value; }
    }
    private string _naewon_yn_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"naewon_yn_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_yn_name
    {
      get { return _naewon_yn_name; }
      set { _naewon_yn_name = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _naewon_date = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _naewon_type = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"naewon_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_type
    {
      get { return _naewon_type; }
      set { _naewon_type = value; }
    }
    private string _jubsu_no = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"jubsu_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_no
    {
      get { return _jubsu_no; }
      set { _jubsu_no = value; }
    }
    private string _pk_naewon = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"pk_naewon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_naewon
    {
      get { return _pk_naewon; }
      set { _pk_naewon = value; }
    }
    private string _order_end_yn = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"order_end_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_end_yn
    {
      get { return _order_end_yn; }
      set { _order_end_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}