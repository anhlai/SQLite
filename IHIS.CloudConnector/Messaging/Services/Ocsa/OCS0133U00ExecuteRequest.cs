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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0133U00ExecuteRequest")]
  public partial class OCS0133U00ExecuteRequest : global::ProtoBuf.IExtensible
  {
    public OCS0133U00ExecuteRequest() {}
    
    private readonly global::System.Collections.Generic.List<OCS0133U00ExecuteItemInfo> _item_info = new global::System.Collections.Generic.List<OCS0133U00ExecuteItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0133U00ExecuteItemInfo> item_info
    {
      get { return _item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
