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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReservedCommentGrdOCS0222Request")]
  public partial class ReservedCommentGrdOCS0222Request : global::ProtoBuf.IExtensible
  {
    public ReservedCommentGrdOCS0222Request() {}
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
