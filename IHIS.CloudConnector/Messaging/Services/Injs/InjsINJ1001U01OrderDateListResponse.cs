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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InjsINJ1001U01OrderDateListResponse")]
  public partial class InjsINJ1001U01OrderDateListResponse : global::ProtoBuf.IExtensible
  {
    public InjsINJ1001U01OrderDateListResponse() {}
    
    private readonly global::System.Collections.Generic.List<DataStringListItemInfo> _order_date = new global::System.Collections.Generic.List<DataStringListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DataStringListItemInfo> order_date
    {
      get { return _order_date; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}