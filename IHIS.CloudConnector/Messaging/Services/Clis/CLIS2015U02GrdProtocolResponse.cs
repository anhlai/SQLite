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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLIS2015U02GrdProtocolResponse")]
  public partial class CLIS2015U02GrdProtocolResponse : global::ProtoBuf.IExtensible
  {
    public CLIS2015U02GrdProtocolResponse() {}
    
    private readonly global::System.Collections.Generic.List<CLIS2015U02GrdProtocolInfo> _grdProtocol_list = new global::System.Collections.Generic.List<CLIS2015U02GrdProtocolInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grdProtocol_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CLIS2015U02GrdProtocolInfo> grdProtocol_list
    {
      get { return _grdProtocol_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
