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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG0201U00GrdOrderDetailServerCallResponse")]
  public partial class DRG0201U00GrdOrderDetailServerCallResponse : global::ProtoBuf.IExtensible
  {
    public DRG0201U00GrdOrderDetailServerCallResponse() {}
    
    private readonly global::System.Collections.Generic.List<DRG0201U00GrdOrderInfo> _grd_order_item = new global::System.Collections.Generic.List<DRG0201U00GrdOrderInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_order_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DRG0201U00GrdOrderInfo> grd_order_item
    {
      get { return _grd_order_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
