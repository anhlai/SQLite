//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: phys_service.proto
// Note: requires additional types generated from: phys_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY8002U00SaveLayoutRequest")]
  public partial class PHY8002U00SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public PHY8002U00SaveLayoutRequest() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _fk_ocs = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fk_ocs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fk_ocs
    {
      get { return _fk_ocs; }
      set { _fk_ocs = value; }
    }
    private string _io_kubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"io_kubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_kubun
    {
      get { return _io_kubun; }
      set { _io_kubun = value; }
    }
    private readonly global::System.Collections.Generic.List<PHY8002U00GrdPHY8002Info> _phy8002_info = new global::System.Collections.Generic.List<PHY8002U00GrdPHY8002Info>();
    [global::ProtoBuf.ProtoMember(4, Name=@"phy8002_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PHY8002U00GrdPHY8002Info> phy8002_info
    {
      get { return _phy8002_info; }
    }
  
    private readonly global::System.Collections.Generic.List<PHY8002U00GrdPHY8003Info> _phy8003_info = new global::System.Collections.Generic.List<PHY8002U00GrdPHY8003Info>();
    [global::ProtoBuf.ProtoMember(5, Name=@"phy8003_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PHY8002U00GrdPHY8003Info> phy8003_info
    {
      get { return _phy8003_info; }
    }
  
    private readonly global::System.Collections.Generic.List<PHY8002U00GrdPHY8004Info> _phy8004_info = new global::System.Collections.Generic.List<PHY8002U00GrdPHY8004Info>();
    [global::ProtoBuf.ProtoMember(6, Name=@"phy8004_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PHY8002U00GrdPHY8004Info> phy8004_info
    {
      get { return _phy8004_info; }
    }
  
    private string _approve_doctor_gwa = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"approve_doctor_gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string approve_doctor_gwa
    {
      get { return _approve_doctor_gwa; }
      set { _approve_doctor_gwa = value; }
    }
    private string _approve_doctor_id = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"approve_doctor_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string approve_doctor_id
    {
      get { return _approve_doctor_id; }
      set { _approve_doctor_id = value; }
    }
    private string _pk_scan001 = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"pk_scan001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_scan001
    {
      get { return _pk_scan001; }
      set { _pk_scan001 = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _copy_pkocskey = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"copy_pkocskey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string copy_pkocskey
    {
      get { return _copy_pkocskey; }
      set { _copy_pkocskey = value; }
    }
    private string _user_gubun = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"user_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_gubun
    {
      get { return _user_gubun; }
      set { _user_gubun = value; }
    }
    private string _leave_cnt = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"leave_cnt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string leave_cnt
    {
      get { return _leave_cnt; }
      set { _leave_cnt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
