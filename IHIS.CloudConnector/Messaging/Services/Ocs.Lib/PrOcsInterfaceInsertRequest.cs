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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrOcsInterfaceInsertRequest")]
  public partial class PrOcsInterfaceInsertRequest : global::ProtoBuf.IExtensible
  {
    public PrOcsInterfaceInsertRequest() {}
    
    private readonly global::System.Collections.Generic.List<PrOcsInterfaceInsertInfo> _info_item = new global::System.Collections.Generic.List<PrOcsInterfaceInsertInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"info_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PrOcsInterfaceInsertInfo> info_item
    {
      get { return _info_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
