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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT1101Q01FwkDoctorRequest")]
  public partial class NuroOUT1101Q01FwkDoctorRequest : global::ProtoBuf.IExtensible
  {
    public NuroOUT1101Q01FwkDoctorRequest() {}
    
    private string _gwa;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _find1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"find1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string find1
    {
      get { return _find1; }
      set { _find1 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}