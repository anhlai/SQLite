//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OUTSANGU00findBoxToDoctorInfo")]
  public partial class OUTSANGU00findBoxToDoctorInfo : global::ProtoBuf.IExtensible
  {
    public OUTSANGU00findBoxToDoctorInfo() {}
    
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _doctor_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_name
    {
      get { return _doctor_name; }
      set { _doctor_name = value; }
    }
    private string _cont_key = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cont_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cont_key
    {
      get { return _cont_key; }
      set { _cont_key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
