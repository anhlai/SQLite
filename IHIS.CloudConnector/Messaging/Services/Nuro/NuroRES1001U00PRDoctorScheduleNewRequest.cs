//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_service.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroRES1001U00PRDoctorScheduleNewRequest")]
  public partial class NuroRES1001U00PRDoctorScheduleNewRequest : global::ProtoBuf.IExtensible
  {
    public NuroRES1001U00PRDoctorScheduleNewRequest() {}
    
    private string _i_doctor = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"i_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_doctor
    {
      get { return _i_doctor; }
      set { _i_doctor = value; }
    }
    private string _i_yymm = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"i_yymm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_yymm
    {
      get { return _i_yymm; }
      set { _i_yymm = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
