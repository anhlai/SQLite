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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0503U00GetFindWorkerResponse")]
  public partial class OCS0503U00GetFindWorkerResponse : global::ProtoBuf.IExtensible
  {
    public OCS0503U00GetFindWorkerResponse() {}
    
    private readonly global::System.Collections.Generic.List<OCS0503U00GetFindWorkerConsultGwaInfo> _find_worker = new global::System.Collections.Generic.List<OCS0503U00GetFindWorkerConsultGwaInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"find_worker", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0503U00GetFindWorkerConsultGwaInfo> find_worker
    {
      get { return _find_worker; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
