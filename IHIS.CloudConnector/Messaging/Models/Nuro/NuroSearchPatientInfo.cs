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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroSearchPatientInfo")]
  public partial class NuroSearchPatientInfo : global::ProtoBuf.IExtensible
  {
    public NuroSearchPatientInfo() {}
    
    private string _patient_name1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"patient_name1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string patient_name1
    {
      get { return _patient_name1; }
      set { _patient_name1 = value; }
    }
    private string _patient_name2;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"patient_name2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string patient_name2
    {
      get { return _patient_name2; }
      set { _patient_name2 = value; }
    }
    private string _birth;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"birth", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string birth
    {
      get { return _birth; }
      set { _birth = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}