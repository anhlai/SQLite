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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3010U00GrdGumListItemInfo")]
  public partial class CPL3010U00GrdGumListItemInfo : global::ProtoBuf.IExtensible
  {
    public CPL3010U00GrdGumListItemInfo() {}
    
    private string _specimen_ser = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"specimen_ser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_ser
    {
      get { return _specimen_ser; }
      set { _specimen_ser = value; }
    }
    private string _fkcpl2010 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fkcpl2010", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkcpl2010
    {
      get { return _fkcpl2010; }
      set { _fkcpl2010 = value; }
    }
    private string _gumsa_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gumsa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gumsa_name
    {
      get { return _gumsa_name; }
      set { _gumsa_name = value; }
    }
    private string _jangbi_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"jangbi_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jangbi_name
    {
      get { return _jangbi_name; }
      set { _jangbi_name = value; }
    }
    private string _cpl_result = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"cpl_result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cpl_result
    {
      get { return _cpl_result; }
      set { _cpl_result = value; }
    }
    private string _specimen_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"specimen_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_name
    {
      get { return _specimen_name; }
      set { _specimen_name = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _part_jubsuja = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"part_jubsuja", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string part_jubsuja
    {
      get { return _part_jubsuja; }
      set { _part_jubsuja = value; }
    }
    private string _sub_jubsu_yn = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"sub_jubsu_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sub_jubsu_yn
    {
      get { return _sub_jubsu_yn; }
      set { _sub_jubsu_yn = value; }
    }
    private string _spcial_name = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"spcial_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string spcial_name
    {
      get { return _spcial_name; }
      set { _spcial_name = value; }
    }
    private string _fkocs = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"fkocs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkocs
    {
      get { return _fkocs; }
      set { _fkocs = value; }
    }
    private string _confirm_yn = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"confirm_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string confirm_yn
    {
      get { return _confirm_yn; }
      set { _confirm_yn = value; }
    }
    private string _data_row_state = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"data_row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data_row_state
    {
      get { return _data_row_state; }
      set { _data_row_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
