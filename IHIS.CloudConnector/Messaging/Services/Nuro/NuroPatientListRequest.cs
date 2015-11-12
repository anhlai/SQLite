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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroPatientListRequest")]
  public partial class NuroPatientListRequest : global::ProtoBuf.IExtensible
  {
    public NuroPatientListRequest() {}
    
    private string _hospital_code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"hospital_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string hospital_code
    {
      get { return _hospital_code; }
      set { _hospital_code = value; }
    }
    private string _coming_date;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"coming_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string coming_date
    {
      get { return _coming_date; }
      set { _coming_date = value; }
    }
    private string _department_code;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"department_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string department_code
    {
      get { return _department_code; }
      set { _department_code = value; }
    }
    private string _doctor_code;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"doctor_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string doctor_code
    {
      get { return _doctor_code; }
      set { _doctor_code = value; }
    }
    private string _patient_code;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"patient_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string patient_code
    {
      get { return _patient_code; }
      set { _patient_code = value; }
    }
    private string _reception_type;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"reception_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string reception_type
    {
      get { return _reception_type; }
      set { _reception_type = value; }
    }
    private string _exam_status;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"exam_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string exam_status
    {
      get { return _exam_status; }
      set { _exam_status = value; }
    }
    private string _coming_status;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"coming_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string coming_status
    {
      get { return _coming_status; }
      set { _coming_status = value; }
    }
    private string _current_system_id;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"current_system_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string current_system_id
    {
      get { return _current_system_id; }
      set { _current_system_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
