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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS2015U30EmrTagGetTagInfo")]
  public partial class OCS2015U30EmrTagGetTagInfo : global::ProtoBuf.IExtensible
  {
    public OCS2015U30EmrTagGetTagInfo() {}
    
    private string _tag_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tag_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag_id
    {
      get { return _tag_id; }
      set { _tag_id = value; }
    }
    private string _tag_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tag_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag_code
    {
      get { return _tag_code; }
      set { _tag_code = value; }
    }
    private string _tag_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tag_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag_name
    {
      get { return _tag_name; }
      set { _tag_name = value; }
    }
    private string _tag_display_text = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"tag_display_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag_display_text
    {
      get { return _tag_display_text; }
      set { _tag_display_text = value; }
    }
    private string _description = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string description
    {
      get { return _description; }
      set { _description = value; }
    }
    private string _filter_flg = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"filter_flg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filter_flg
    {
      get { return _filter_flg; }
      set { _filter_flg = value; }
    }
    private string _tag_parent = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"tag_parent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag_parent
    {
      get { return _tag_parent; }
      set { _tag_parent = value; }
    }
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
