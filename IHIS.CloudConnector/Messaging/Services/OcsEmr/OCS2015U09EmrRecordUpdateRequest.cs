//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service2.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS2015U09EmrRecordUpdateRequest")]
  public partial class OCS2015U09EmrRecordUpdateRequest : global::ProtoBuf.IExtensible
  {
    public OCS2015U09EmrRecordUpdateRequest() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _content = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private string _metadata = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"metadata", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string metadata
    {
      get { return _metadata; }
      set { _metadata = value; }
    }
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_id
    {
      get { return _sys_id; }
      set { _sys_id = value; }
    }
    private string _record_log = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"record_log", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string record_log
    {
      get { return _record_log; }
      set { _record_log = value; }
    }
    private readonly global::System.Collections.Generic.List<OCS2015U09EmrBookmarkInfo> _bookmark = new global::System.Collections.Generic.List<OCS2015U09EmrBookmarkInfo>();
    [global::ProtoBuf.ProtoMember(6, Name=@"bookmark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS2015U09EmrBookmarkInfo> bookmark
    {
      get { return _bookmark; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
