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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DOC4003U00GrdDOC4003Response")]
  public partial class DOC4003U00GrdDOC4003Response : global::ProtoBuf.IExtensible
  {
    public DOC4003U00GrdDOC4003Response() {}
    
    private readonly global::System.Collections.Generic.List<DOC4003U00GrdDOC4003Info> _doc_4003_item = new global::System.Collections.Generic.List<DOC4003U00GrdDOC4003Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"doc_4003_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DOC4003U00GrdDOC4003Info> doc_4003_item
    {
      get { return _doc_4003_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}