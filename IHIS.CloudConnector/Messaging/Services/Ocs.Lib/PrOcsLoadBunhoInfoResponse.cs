//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrOcsLoadBunhoInfoResponse")]
  public partial class PrOcsLoadBunhoInfoResponse : global::ProtoBuf.IExtensible
  {
    public PrOcsLoadBunhoInfoResponse() {}
    
    private readonly global::System.Collections.Generic.List<LoadPatientBaseInfo> _patient_base_info = new global::System.Collections.Generic.List<LoadPatientBaseInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"patient_base_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LoadPatientBaseInfo> patient_base_info
    {
      get { return _patient_base_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}