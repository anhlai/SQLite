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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroRES1001U00DoctorReservationDateListItemInfo")]
  public partial class NuroRES1001U00DoctorReservationDateListItemInfo : global::ProtoBuf.IExtensible
  {
    public NuroRES1001U00DoctorReservationDateListItemInfo() {}
    
    private string _doctor_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"doctor_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor_code
    {
      get { return _doctor_code; }
      set { _doctor_code = value; }
    }
    private string _date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string date
    {
      get { return _date; }
      set { _date = value; }
    }
    private string _res_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"res_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string res_date
    {
      get { return _res_date; }
      set { _res_date = value; }
    }
    private string _res_flag = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"res_flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string res_flag
    {
      get { return _res_flag; }
      set { _res_flag = value; }
    }
    private string _res_inwon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"res_inwon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string res_inwon
    {
      get { return _res_inwon; }
      set { _res_inwon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}