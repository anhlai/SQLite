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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS1003Q09GridOCS1003Request")]
  public partial class OCS1003Q09GridOCS1003Request : global::ProtoBuf.IExtensible
  {
    public OCS1003Q09GridOCS1003Request() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _naewon_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _naewon_type = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"naewon_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_type
    {
      get { return _naewon_type; }
      set { _naewon_type = value; }
    }
    private string _input_gubun = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"input_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gubun
    {
      get { return _input_gubun; }
      set { _input_gubun = value; }
    }
    private string _tel_yn = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"tel_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tel_yn
    {
      get { return _tel_yn; }
      set { _tel_yn = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private string _jubsu_no = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"jubsu_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_no
    {
      get { return _jubsu_no; }
      set { _jubsu_no = value; }
    }
    private string _pk_order = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"pk_order", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_order
    {
      get { return _pk_order; }
      set { _pk_order = value; }
    }
    private string _generic_yn = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"generic_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string generic_yn
    {
      get { return _generic_yn; }
      set { _generic_yn = value; }
    }
    private string _kijun = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"kijun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string kijun
    {
      get { return _kijun; }
      set { _kijun = value; }
    }
    private string _io_gubun = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"io_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_gubun
    {
      get { return _io_gubun; }
      set { _io_gubun = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}