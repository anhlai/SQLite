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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCSACTUpdateGrdOrderInfo")]
  public partial class OCSACTUpdateGrdOrderInfo : global::ProtoBuf.IExtensible
  {
    public OCSACTUpdateGrdOrderInfo() {}
    
    private string _remark = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string remark
    {
      get { return _remark; }
      set { _remark = value; }
    }
    private string _pkocs = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pkocs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkocs
    {
      get { return _pkocs; }
      set { _pkocs = value; }
    }
    private string _jubsu_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_date
    {
      get { return _jubsu_date; }
      set { _jubsu_date = value; }
    }
    private string _jubsu_time = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"jubsu_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_time
    {
      get { return _jubsu_time; }
      set { _jubsu_time = value; }
    }
    private string _act_doctor = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"act_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string act_doctor
    {
      get { return _act_doctor; }
      set { _act_doctor = value; }
    }
    private string _input_control = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"input_control", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_control
    {
      get { return _input_control; }
      set { _input_control = value; }
    }
    private string _suryang = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"suryang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suryang
    {
      get { return _suryang; }
      set { _suryang = value; }
    }
    private string _nalsu = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"nalsu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nalsu
    {
      get { return _nalsu; }
      set { _nalsu = value; }
    }
    private string _fkout1001 = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"fkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkout1001
    {
      get { return _fkout1001; }
      set { _fkout1001 = value; }
    }
    private string _input_gubun = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"input_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gubun
    {
      get { return _input_gubun; }
      set { _input_gubun = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _jundal_part = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"jundal_part", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_part
    {
      get { return _jundal_part; }
      set { _jundal_part = value; }
    }
    private string _grd_order_in_out_gubun = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"grd_order_in_out_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_order_in_out_gubun
    {
      get { return _grd_order_in_out_gubun; }
      set { _grd_order_in_out_gubun = value; }
    }
    private string _grd_order_acting_date = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"grd_order_acting_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_order_acting_date
    {
      get { return _grd_order_acting_date; }
      set { _grd_order_acting_date = value; }
    }
    private string _grd_order_acting_time = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"grd_order_acting_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_order_acting_time
    {
      get { return _grd_order_acting_time; }
      set { _grd_order_acting_time = value; }
    }
    private string _grd_order_sort_fkocskey = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"grd_order_sort_fkocskey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_order_sort_fkocskey
    {
      get { return _grd_order_sort_fkocskey; }
      set { _grd_order_sort_fkocskey = value; }
    }
    private string _grd_order_act_yn = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"grd_order_act_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_order_act_yn
    {
      get { return _grd_order_act_yn; }
      set { _grd_order_act_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
