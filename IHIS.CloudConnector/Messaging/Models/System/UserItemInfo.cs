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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserItemInfo")]
  public partial class UserItemInfo : global::ProtoBuf.IExtensible
  {
    public UserItemInfo() {}
    
    private string _user_nm = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_nm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_nm
    {
      get { return _user_nm; }
      set { _user_nm = value; }
    }
    private string _user_dept = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_dept", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_dept
    {
      get { return _user_dept; }
      set { _user_dept = value; }
    }
    private string _dept_nm = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"dept_nm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dept_nm
    {
      get { return _dept_nm; }
      set { _dept_nm = value; }
    }
    private string _gwa_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gwa_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_code
    {
      get { return _gwa_code; }
      set { _gwa_code = value; }
    }
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private string _user_level = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"user_level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_level
    {
      get { return _user_level; }
      set { _user_level = value; }
    }
    private string _user_group = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"user_group", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_group
    {
      get { return _user_group; }
      set { _user_group = value; }
    }
    private string _user_gubun = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"user_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_gubun
    {
      get { return _user_gubun; }
      set { _user_gubun = value; }
    }
    private string _buseo_gubun = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"buseo_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_gubun
    {
      get { return _buseo_gubun; }
      set { _buseo_gubun = value; }
    }
    private string _yaksok_com_id = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"yaksok_com_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yaksok_com_id
    {
      get { return _yaksok_com_id; }
      set { _yaksok_com_id = value; }
    }
    private string _yaksok_open_id = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"yaksok_open_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yaksok_open_id
    {
      get { return _yaksok_open_id; }
      set { _yaksok_open_id = value; }
    }
    private string _slip_com_id = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"slip_com_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_com_id
    {
      get { return _slip_com_id; }
      set { _slip_com_id = value; }
    }
    private string _slip_open_id = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"slip_open_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slip_open_id
    {
      get { return _slip_open_id; }
      set { _slip_open_id = value; }
    }
    private string _sang_com_id = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"sang_com_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sang_com_id
    {
      get { return _sang_com_id; }
      set { _sang_com_id = value; }
    }
    private string _sang_open_id = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"sang_open_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sang_open_id
    {
      get { return _sang_open_id; }
      set { _sang_open_id = value; }
    }
    private string _jindan_com_id = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"jindan_com_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jindan_com_id
    {
      get { return _jindan_com_id; }
      set { _jindan_com_id = value; }
    }
    private string _jindan_open_id = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"jindan_open_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jindan_open_id
    {
      get { return _jindan_open_id; }
      set { _jindan_open_id = value; }
    }
    private string _nurse_team = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"nurse_team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nurse_team
    {
      get { return _nurse_team; }
      set { _nurse_team = value; }
    }
    private string _cp_com_id = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"cp_com_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cp_com_id
    {
      get { return _cp_com_id; }
      set { _cp_com_id = value; }
    }
    private string _cp_open_id = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"cp_open_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cp_open_id
    {
      get { return _cp_open_id; }
      set { _cp_open_id = value; }
    }
    private string _input_gubun = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"input_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gubun
    {
      get { return _input_gubun; }
      set { _input_gubun = value; }
    }
    private string _doctor_id = "";
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"doctor_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_id
    {
      get { return _doctor_id; }
      set { _doctor_id = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _hosp_name = "";
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"hosp_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_name
    {
      get { return _hosp_name; }
      set { _hosp_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}