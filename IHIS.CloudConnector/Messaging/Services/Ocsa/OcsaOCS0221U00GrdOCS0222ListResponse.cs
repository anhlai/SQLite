//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ocsa_service.proto
// Note: requires additional types generated from: ocsa_model.proto
// Note: requires additional types generated from: ocs.lib_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsaOCS0221U00GrdOCS0222ListResponse")]
  public partial class OcsaOCS0221U00GrdOCS0222ListResponse : global::ProtoBuf.IExtensible
  {
    public OcsaOCS0221U00GrdOCS0222ListResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsaOCS0221U00GrdOCS0222ListInfo> _grid_item = new global::System.Collections.Generic.List<OcsaOCS0221U00GrdOCS0222ListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grid_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsaOCS0221U00GrdOCS0222ListInfo> grid_item
    {
      get { return _grid_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}