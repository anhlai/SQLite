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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0260GrdBuseoListItemInfo")]
  public partial class BAS0260GrdBuseoListItemInfo : global::ProtoBuf.IExtensible
  {
    public BAS0260GrdBuseoListItemInfo() {}
    
    private string _buseo_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"buseo_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_code
    {
      get { return _buseo_code; }
      set { _buseo_code = value; }
    }
    private string _buseo_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"buseo_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_name
    {
      get { return _buseo_name; }
      set { _buseo_name = value; }
    }
    private string _parent_buseo = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"parent_buseo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string parent_buseo
    {
      get { return _parent_buseo; }
      set { _parent_buseo = value; }
    }
    private string _buseo_gubun = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"buseo_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_gubun
    {
      get { return _buseo_gubun; }
      set { _buseo_gubun = value; }
    }
    private string _gwa_gubun = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"gwa_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_gubun
    {
      get { return _gwa_gubun; }
      set { _gwa_gubun = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private string _parent_gwa = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"parent_gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string parent_gwa
    {
      get { return _parent_gwa; }
      set { _parent_gwa = value; }
    }
    private string _out_jubsu_yn = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"out_jubsu_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string out_jubsu_yn
    {
      get { return _out_jubsu_yn; }
      set { _out_jubsu_yn = value; }
    }
    private string _ipwon_yn = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ipwon_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ipwon_yn
    {
      get { return _ipwon_yn; }
      set { _ipwon_yn = value; }
    }
    private string _out_slip_yn = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"out_slip_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string out_slip_yn
    {
      get { return _out_slip_yn; }
      set { _out_slip_yn = value; }
    }
    private string _inp_slip_yn = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"inp_slip_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string inp_slip_yn
    {
      get { return _inp_slip_yn; }
      set { _inp_slip_yn = value; }
    }
    private string _euryoseo_yn = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"euryoseo_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string euryoseo_yn
    {
      get { return _euryoseo_yn; }
      set { _euryoseo_yn = value; }
    }
    private string _out_move_yn = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"out_move_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string out_move_yn
    {
      get { return _out_move_yn; }
      set { _out_move_yn = value; }
    }
    private string _out_jundal_part_yn = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"out_jundal_part_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string out_jundal_part_yn
    {
      get { return _out_jundal_part_yn; }
      set { _out_jundal_part_yn = value; }
    }
    private string _inp_jundal_part_yn = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"inp_jundal_part_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string inp_jundal_part_yn
    {
      get { return _inp_jundal_part_yn; }
      set { _inp_jundal_part_yn = value; }
    }
    private string _input_gubun = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"input_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gubun
    {
      get { return _input_gubun; }
      set { _input_gubun = value; }
    }
    private string _move_comment = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"move_comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string move_comment
    {
      get { return _move_comment; }
      set { _move_comment = value; }
    }
    private string _tel = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"tel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tel
    {
      get { return _tel; }
      set { _tel = value; }
    }
    private string _gwa_ename = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"gwa_ename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_ename
    {
      get { return _gwa_ename; }
      set { _gwa_ename = value; }
    }
    private string _gwa_sname = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"gwa_sname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_sname
    {
      get { return _gwa_sname; }
      set { _gwa_sname = value; }
    }
    private string _gwa_sort1 = "";
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"gwa_sort1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_sort1
    {
      get { return _gwa_sort1; }
      set { _gwa_sort1 = value; }
    }
    private string _gwa_sort2 = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"gwa_sort2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_sort2
    {
      get { return _gwa_sort2; }
      set { _gwa_sort2 = value; }
    }
    private string _rmk = "";
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"rmk", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string rmk
    {
      get { return _rmk; }
      set { _rmk = value; }
    }
    private string _end_date = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"end_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string end_date
    {
      get { return _end_date; }
      set { _end_date = value; }
    }
    private string _start_date = "";
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"start_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string start_date
    {
      get { return _start_date; }
      set { _start_date = value; }
    }
    private string _buseo_name2 = "";
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"buseo_name2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buseo_name2
    {
      get { return _buseo_name2; }
      set { _buseo_name2 = value; }
    }
    private string _gwa_color = "";
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"gwa_color", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_color
    {
      get { return _gwa_color; }
      set { _gwa_color = value; }
    }
    private string _hpc_ho_dong_yn = "";
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"hpc_ho_dong_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hpc_ho_dong_yn
    {
      get { return _hpc_ho_dong_yn; }
      set { _hpc_ho_dong_yn = value; }
    }
    private string _add_doctor = "";
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"add_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string add_doctor
    {
      get { return _add_doctor; }
      set { _add_doctor = value; }
    }
    private string _gwa_name_kana = "";
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"gwa_name_kana", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name_kana
    {
      get { return _gwa_name_kana; }
      set { _gwa_name_kana = value; }
    }
    private string _row_sate = "";
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"row_sate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string row_sate
    {
      get { return _row_sate; }
      set { _row_sate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}