//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: adms_service.proto
// Note: requires additional types generated from: adms_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADMS2015U00GetSystemHospitalResponse")]
  public partial class ADMS2015U00GetSystemHospitalResponse : global::ProtoBuf.IExtensible
  {
    public ADMS2015U00GetSystemHospitalResponse() {}
    
    private readonly global::System.Collections.Generic.List<ADMS2015U00SystemHospitalInfo> _system_list_info = new global::System.Collections.Generic.List<ADMS2015U00SystemHospitalInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"system_list_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ADMS2015U00SystemHospitalInfo> system_list_info
    {
      get { return _system_list_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
