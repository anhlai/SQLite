//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0118U00GrdSaveLayoutInfo")]
  public partial class OCS0118U00GrdSaveLayoutInfo : global::ProtoBuf.IExtensible
  {
    public OCS0118U00GrdSaveLayoutInfo() {}
    
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_id
    {
      get { return _sys_id; }
      set { _sys_id = value; }
    }
    private string _conv_cls = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"conv_cls", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conv_cls
    {
      get { return _conv_cls; }
      set { _conv_cls = value; }
    }
    private string _conv_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"conv_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conv_gubun
    {
      get { return _conv_gubun; }
      set { _conv_gubun = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _conv_hangmog = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"conv_hangmog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conv_hangmog
    {
      get { return _conv_hangmog; }
      set { _conv_hangmog = value; }
    }
    private string _start_date = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"start_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string start_date
    {
      get { return _start_date; }
      set { _start_date = value; }
    }
    private string _remark = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string remark
    {
      get { return _remark; }
      set { _remark = value; }
    }
    private string _row_state = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
