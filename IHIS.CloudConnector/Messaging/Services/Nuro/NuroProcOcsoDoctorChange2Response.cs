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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroProcOcsoDoctorChange2Response")]
  public partial class NuroProcOcsoDoctorChange2Response : global::ProtoBuf.IExtensible
  {
    public NuroProcOcsoDoctorChange2Response() {}
    
    private string _flag;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string flag
    {
      get { return _flag; }
      set { _flag = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}