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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS2015U31EmrTemplateSaveLayoutInfo")]
  public partial class OCS2015U31EmrTemplateSaveLayoutInfo : global::ProtoBuf.IExtensible
  {
    public OCS2015U31EmrTemplateSaveLayoutInfo() {}
    
    private string _template_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"template_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string template_id
    {
      get { return _template_id; }
      set { _template_id = value; }
    }
    private string _template_type_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"template_type_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string template_type_id
    {
      get { return _template_type_id; }
      set { _template_type_id = value; }
    }
    private string _template_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"template_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string template_name
    {
      get { return _template_name; }
      set { _template_name = value; }
    }
    private string _template_content = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"template_content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string template_content
    {
      get { return _template_content; }
      set { _template_content = value; }
    }
    private string _description = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string description
    {
      get { return _description; }
      set { _description = value; }
    }
    private string _permission_type = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"permission_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string permission_type
    {
      get { return _permission_type; }
      set { _permission_type = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _row_state = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string row_state
    {
      get { return _row_state; }
      set { _row_state = value; }
    }
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_id
    {
      get { return _sys_id; }
      set { _sys_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
