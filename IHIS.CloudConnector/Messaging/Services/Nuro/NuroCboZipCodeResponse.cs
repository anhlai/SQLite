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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroCboZipCodeResponse")]
  public partial class NuroCboZipCodeResponse : global::ProtoBuf.IExtensible
  {
    public NuroCboZipCodeResponse() {}
    
    private readonly global::System.Collections.Generic.List<NuroCboZipCodeInfo> _zip_code_info = new global::System.Collections.Generic.List<NuroCboZipCodeInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"zip_code_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroCboZipCodeInfo> zip_code_info
    {
      get { return _zip_code_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
