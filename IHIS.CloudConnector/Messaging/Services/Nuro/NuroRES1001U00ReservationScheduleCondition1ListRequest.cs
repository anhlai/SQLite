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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroRES1001U00ReservationScheduleCondition1ListRequest")]
  public partial class NuroRES1001U00ReservationScheduleCondition1ListRequest : global::ProtoBuf.IExtensible
  {
    public NuroRES1001U00ReservationScheduleCondition1ListRequest() {}
    
    private string _doctor_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"doctor_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_code
    {
      get { return _doctor_code; }
      set { _doctor_code = value; }
    }
    private string _exam_pre_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"exam_pre_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string exam_pre_date
    {
      get { return _exam_pre_date; }
      set { _exam_pre_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
