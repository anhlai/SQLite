//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"INJ1002U01GrdOrderResponse")]
  public partial class INJ1002U01GrdOrderResponse : global::ProtoBuf.IExtensible
  {
    public INJ1002U01GrdOrderResponse() {}
    
    private readonly global::System.Collections.Generic.List<INJ1002U01GrdOrderListItemInfo> _grdOrder_list = new global::System.Collections.Generic.List<INJ1002U01GrdOrderListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grdOrder_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<INJ1002U01GrdOrderListItemInfo> grdOrder_list
    {
      get { return _grdOrder_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}