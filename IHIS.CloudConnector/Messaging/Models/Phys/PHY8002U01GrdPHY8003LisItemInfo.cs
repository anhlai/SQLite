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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY8002U01GrdPHY8003LisItemInfo")]
  public partial class PHY8002U01GrdPHY8003LisItemInfo : global::ProtoBuf.IExtensible
  {
    public PHY8002U01GrdPHY8003LisItemInfo() {}
    
    private string _ys_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ys_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ys_date
    {
      get { return _ys_date; }
      set { _ys_date = value; }
    }
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _upd_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"upd_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string upd_date
    {
      get { return _upd_date; }
      set { _upd_date = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _pk_phy_syoubyou = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"pk_phy_syoubyou", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_phy_syoubyou
    {
      get { return _pk_phy_syoubyou; }
      set { _pk_phy_syoubyou = value; }
    }
    private string _data_kubun = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"data_kubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data_kubun
    {
      get { return _data_kubun; }
      set { _data_kubun = value; }
    }
    private string _fk_ocs_irai = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fk_ocs_irai", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fk_ocs_irai
    {
      get { return _fk_ocs_irai; }
      set { _fk_ocs_irai = value; }
    }
    private string _io_kubun = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"io_kubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_kubun
    {
      get { return _io_kubun; }
      set { _io_kubun = value; }
    }
    private string _irai_date = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"irai_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string irai_date
    {
      get { return _irai_date; }
      set { _irai_date = value; }
    }
    private string _kanja_no = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"kanja_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string kanja_no
    {
      get { return _kanja_no; }
      set { _kanja_no = value; }
    }
    private string _sinryouka = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"sinryouka", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sinryouka
    {
      get { return _sinryouka; }
      set { _sinryouka = value; }
    }
    private string _syoubyoumei_code = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"syoubyoumei_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string syoubyoumei_code
    {
      get { return _syoubyoumei_code; }
      set { _syoubyoumei_code = value; }
    }
    private string _modifier_name = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"modifier_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string modifier_name
    {
      get { return _modifier_name; }
      set { _modifier_name = value; }
    }
    private string _pre_modifier1 = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"pre_modifier1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier1
    {
      get { return _pre_modifier1; }
      set { _pre_modifier1 = value; }
    }
    private string _pre_modifier2 = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"pre_modifier2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier2
    {
      get { return _pre_modifier2; }
      set { _pre_modifier2 = value; }
    }
    private string _pre_modifier3 = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"pre_modifier3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier3
    {
      get { return _pre_modifier3; }
      set { _pre_modifier3 = value; }
    }
    private string _pre_modifier4 = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"pre_modifier4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier4
    {
      get { return _pre_modifier4; }
      set { _pre_modifier4 = value; }
    }
    private string _pre_modifier5 = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"pre_modifier5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier5
    {
      get { return _pre_modifier5; }
      set { _pre_modifier5 = value; }
    }
    private string _pre_modifier6 = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"pre_modifier6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier6
    {
      get { return _pre_modifier6; }
      set { _pre_modifier6 = value; }
    }
    private string _pre_modifier7 = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"pre_modifier7", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier7
    {
      get { return _pre_modifier7; }
      set { _pre_modifier7 = value; }
    }
    private string _pre_modifier8 = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"pre_modifier8", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier8
    {
      get { return _pre_modifier8; }
      set { _pre_modifier8 = value; }
    }
    private string _pre_modifier9 = "";
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"pre_modifier9", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier9
    {
      get { return _pre_modifier9; }
      set { _pre_modifier9 = value; }
    }
    private string _pre_modifier10 = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"pre_modifier10", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier10
    {
      get { return _pre_modifier10; }
      set { _pre_modifier10 = value; }
    }
    private string _post_modifier1 = "";
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"post_modifier1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier1
    {
      get { return _post_modifier1; }
      set { _post_modifier1 = value; }
    }
    private string _post_modifier2 = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"post_modifier2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier2
    {
      get { return _post_modifier2; }
      set { _post_modifier2 = value; }
    }
    private string _post_modifier3 = "";
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"post_modifier3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier3
    {
      get { return _post_modifier3; }
      set { _post_modifier3 = value; }
    }
    private string _post_modifier4 = "";
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"post_modifier4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier4
    {
      get { return _post_modifier4; }
      set { _post_modifier4 = value; }
    }
    private string _post_modifier5 = "";
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"post_modifier5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier5
    {
      get { return _post_modifier5; }
      set { _post_modifier5 = value; }
    }
    private string _post_modifier6 = "";
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"post_modifier6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier6
    {
      get { return _post_modifier6; }
      set { _post_modifier6 = value; }
    }
    private string _post_modifier7 = "";
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"post_modifier7", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier7
    {
      get { return _post_modifier7; }
      set { _post_modifier7 = value; }
    }
    private string _post_modifier8 = "";
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"post_modifier8", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier8
    {
      get { return _post_modifier8; }
      set { _post_modifier8 = value; }
    }
    private string _post_modifier9 = "";
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"post_modifier9", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier9
    {
      get { return _post_modifier9; }
      set { _post_modifier9 = value; }
    }
    private string _post_modifier10 = "";
    [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"post_modifier10", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier10
    {
      get { return _post_modifier10; }
      set { _post_modifier10 = value; }
    }
    private string _hassyoubi = "";
    [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"hassyoubi", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hassyoubi
    {
      get { return _hassyoubi; }
      set { _hassyoubi = value; }
    }
    private string _sindanbi = "";
    [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"sindanbi", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sindanbi
    {
      get { return _sindanbi; }
      set { _sindanbi = value; }
    }
    private string _pre_modifier_name = "";
    [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"pre_modifier_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pre_modifier_name
    {
      get { return _pre_modifier_name; }
      set { _pre_modifier_name = value; }
    }
    private string _post_modifier_name = "";
    [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"post_modifier_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string post_modifier_name
    {
      get { return _post_modifier_name; }
      set { _post_modifier_name = value; }
    }
    private string _syoubyoumei = "";
    [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"syoubyoumei", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string syoubyoumei
    {
      get { return _syoubyoumei; }
      set { _syoubyoumei = value; }
    }
    private string _fkoutsang = "";
    [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"fkoutsang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkoutsang
    {
      get { return _fkoutsang; }
      set { _fkoutsang = value; }
    }
    private string _row_state = "";
    [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string row_state
    {
      get { return _row_state; }
      set { _row_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}