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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADM106UMakeQueryListItemInfo")]
  public partial class ADM106UMakeQueryListItemInfo : global::ProtoBuf.IExtensible
  {
    public ADM106UMakeQueryListItemInfo() {}
    
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_id
    {
      get { return _sys_id; }
      set { _sys_id = value; }
    }
    private string _tr_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tr_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tr_id
    {
      get { return _tr_id; }
      set { _tr_id = value; }
    }
    private string _tr_seq = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tr_seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tr_seq
    {
      get { return _tr_seq; }
      set { _tr_seq = value; }
    }
    private string _pgm_id = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pgm_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pgm_id
    {
      get { return _pgm_id; }
      set { _pgm_id = value; }
    }
    private string _uppr_menu = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"uppr_menu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string uppr_menu
    {
      get { return _uppr_menu; }
      set { _uppr_menu = value; }
    }
    private string _pgm_nm = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"pgm_nm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pgm_nm
    {
      get { return _pgm_nm; }
      set { _pgm_nm = value; }
    }
    private string _pgm_tp = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"pgm_tp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pgm_tp
    {
      get { return _pgm_tp; }
      set { _pgm_tp = value; }
    }
    private string _pgm_open_tp = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pgm_open_tp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pgm_open_tp
    {
      get { return _pgm_open_tp; }
      set { _pgm_open_tp = value; }
    }
    private string _short_cut = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"short_cut", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string short_cut
    {
      get { return _short_cut; }
      set { _short_cut = value; }
    }
    private string _menu_param = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"menu_param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string menu_param
    {
      get { return _menu_param; }
      set { _menu_param = value; }
    }
    private string _row_state = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
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