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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS2015U31EmrTagGetTemplateTagsRequest")]
  public partial class OCS2015U31EmrTagGetTemplateTagsRequest : global::ProtoBuf.IExtensible
  {
    public OCS2015U31EmrTagGetTemplateTagsRequest() {}
    
    private string _str_tag_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"str_tag_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string str_tag_code
    {
      get { return _str_tag_code; }
      set { _str_tag_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}