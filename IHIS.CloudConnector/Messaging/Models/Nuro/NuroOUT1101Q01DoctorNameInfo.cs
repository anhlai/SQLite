//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT1101Q01DoctorNameInfo")]
  public partial class NuroOUT1101Q01DoctorNameInfo : global::ProtoBuf.IExtensible
  {
    public NuroOUT1101Q01DoctorNameInfo() {}
    
    private string _doctor_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_name
    {
      get { return _doctor_name; }
      set { _doctor_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
