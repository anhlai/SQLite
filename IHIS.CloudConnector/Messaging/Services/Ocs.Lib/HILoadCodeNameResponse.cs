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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HILoadCodeNameResponse")]
  public partial class HILoadCodeNameResponse : global::ProtoBuf.IExtensible
  {
    public HILoadCodeNameResponse() {}
    
    private readonly global::System.Collections.Generic.List<HILoadCodeNameInfo> _code_name_item = new global::System.Collections.Generic.List<HILoadCodeNameInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"code_name_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HILoadCodeNameInfo> code_name_item
    {
      get { return _code_name_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}