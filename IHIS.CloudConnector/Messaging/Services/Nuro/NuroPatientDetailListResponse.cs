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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroPatientDetailListResponse")]
  public partial class NuroPatientDetailListResponse : global::ProtoBuf.IExtensible
  {
    public NuroPatientDetailListResponse() {}
    
    private readonly global::System.Collections.Generic.List<NuroPatientDetailListItemInfo> _patient_detail_list_item = new global::System.Collections.Generic.List<NuroPatientDetailListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"patient_detail_list_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroPatientDetailListItemInfo> patient_detail_list_item
    {
      get { return _patient_detail_list_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}