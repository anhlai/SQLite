//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReservedCommentDloOCS0221Info")]
  public partial class ReservedCommentDloOCS0221Info : global::ProtoBuf.IExtensible
  {
    public ReservedCommentDloOCS0221Info() {}
    
    private string _memb = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"memb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb
    {
      get { return _memb; }
      set { _memb = value; }
    }
    private string _seq = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq
    {
      get { return _seq; }
      set { _seq = value; }
    }
    private string _category_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"category_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string category_gubun
    {
      get { return _category_gubun; }
      set { _category_gubun = value; }
    }
    private string _category_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"category_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string category_name
    {
      get { return _category_name; }
      set { _category_name = value; }
    }
    private string _comment_limit = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"comment_limit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string comment_limit
    {
      get { return _comment_limit; }
      set { _comment_limit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}