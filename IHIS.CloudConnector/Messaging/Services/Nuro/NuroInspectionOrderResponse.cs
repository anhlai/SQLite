//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_service.proto
// Note: requires additional types generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroInspectionOrderResponse")]
  public partial class NuroInspectionOrderResponse : global::ProtoBuf.IExtensible
  {
    public NuroInspectionOrderResponse() {}
    
    private readonly global::System.Collections.Generic.List<NuroInspectionOrderInfo> _inspection_order_info = new global::System.Collections.Generic.List<NuroInspectionOrderInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"inspection_order_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroInspectionOrderInfo> inspection_order_info
    {
      get { return _inspection_order_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
