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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsaOCS0204U00FindWorkerListResponse")]
  public partial class OcsaOCS0204U00FindWorkerListResponse : global::ProtoBuf.IExtensible
  {
    public OcsaOCS0204U00FindWorkerListResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsaOCS0204U00MembListInfo> _memb_list = new global::System.Collections.Generic.List<OcsaOCS0204U00MembListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"memb_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsaOCS0204U00MembListInfo> memb_list
    {
      get { return _memb_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}