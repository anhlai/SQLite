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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG0201U00GrdOrderInfo")]
  public partial class DRG0201U00GrdOrderInfo : global::ProtoBuf.IExtensible
  {
    public DRG0201U00GrdOrderInfo() {}
    
    private string _drg_bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"drg_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_bunho
    {
      get { return _drg_bunho; }
      set { _drg_bunho = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private string _jubsu_date = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_date
    {
      get { return _jubsu_date; }
      set { _jubsu_date = value; }
    }
    private string _drg_jubsu_date = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"drg_jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_jubsu_date
    {
      get { return _drg_jubsu_date; }
      set { _drg_jubsu_date = value; }
    }
    private string _jubsu_time = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"jubsu_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_time
    {
      get { return _jubsu_time; }
      set { _jubsu_time = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _doctor_name = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_name
    {
      get { return _doctor_name; }
      set { _doctor_name = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _buseo_name = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"buseo_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_name
    {
      get { return _buseo_name; }
      set { _buseo_name = value; }
    }
    private string _act_date = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"act_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string act_date
    {
      get { return _act_date; }
      set { _act_date = value; }
    }
    private string _act_time = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"act_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string act_time
    {
      get { return _act_time; }
      set { _act_time = value; }
    }
    private string _act_yn = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"act_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string act_yn
    {
      get { return _act_yn; }
      set { _act_yn = value; }
    }
    private string _sunab_date = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"sunab_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sunab_date
    {
      get { return _sunab_date; }
      set { _sunab_date = value; }
    }
    private string _chulgo_date = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"chulgo_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chulgo_date
    {
      get { return _chulgo_date; }
      set { _chulgo_date = value; }
    }
    private string _act_user_name = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"act_user_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string act_user_name
    {
      get { return _act_user_name; }
      set { _act_user_name = value; }
    }
    private string _wonyoi_order_yn = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"wonyoi_order_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string wonyoi_order_yn
    {
      get { return _wonyoi_order_yn; }
      set { _wonyoi_order_yn = value; }
    }
    private string _dis_gubun = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"dis_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dis_gubun
    {
      get { return _dis_gubun; }
      set { _dis_gubun = value; }
    }
    private string _order_remark = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"order_remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_remark
    {
      get { return _order_remark; }
      set { _order_remark = value; }
    }
    private string _drg_remark = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"drg_remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_remark
    {
      get { return _drg_remark; }
      set { _drg_remark = value; }
    }
    private string _fkout1001 = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"fkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkout1001
    {
      get { return _fkout1001; }
      set { _fkout1001 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}