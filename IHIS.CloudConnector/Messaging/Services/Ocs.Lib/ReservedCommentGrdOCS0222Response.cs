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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReservedCommentGrdOCS0222Response")]
  public partial class ReservedCommentGrdOCS0222Response : global::ProtoBuf.IExtensible
  {
    public ReservedCommentGrdOCS0222Response() {}
    
    private readonly global::System.Collections.Generic.List<ReservedCommentGrdOCS0222Info> _grd_ocs0222_item = new global::System.Collections.Generic.List<ReservedCommentGrdOCS0222Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_ocs0222_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ReservedCommentGrdOCS0222Info> grd_ocs0222_item
    {
      get { return _grd_ocs0222_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
