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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U16GrdSlipHangmogResponse")]
  public partial class OCS0103U16GrdSlipHangmogResponse : global::ProtoBuf.IExtensible
  {
    public OCS0103U16GrdSlipHangmogResponse() {}
    
    private readonly global::System.Collections.Generic.List<OCS0103U16GrdSlipHangmogInfo> _slip_hangmog_item = new global::System.Collections.Generic.List<OCS0103U16GrdSlipHangmogInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"slip_hangmog_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U16GrdSlipHangmogInfo> slip_hangmog_item
    {
      get { return _slip_hangmog_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
