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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS2015U40EmrHistoryMedicalRecordResponse")]
  public partial class OCS2015U40EmrHistoryMedicalRecordResponse : global::ProtoBuf.IExtensible
  {
    public OCS2015U40EmrHistoryMedicalRecordResponse() {}
    
    private readonly global::System.Collections.Generic.List<OCS2015U40EmrHistoryMedicalRecordInfo> _emr_history_medical_record_item = new global::System.Collections.Generic.List<OCS2015U40EmrHistoryMedicalRecordInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"emr_history_medical_record_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS2015U40EmrHistoryMedicalRecordInfo> emr_history_medical_record_item
    {
      get { return _emr_history_medical_record_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
