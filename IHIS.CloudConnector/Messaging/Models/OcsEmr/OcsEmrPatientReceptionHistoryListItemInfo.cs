//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service2.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsEmrPatientReceptionHistoryListItemInfo")]
  public partial class OcsEmrPatientReceptionHistoryListItemInfo : global::ProtoBuf.IExtensible
  {
    public OcsEmrPatientReceptionHistoryListItemInfo() {}
    
    private string _coming_date;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"coming_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string coming_date
    {
      get { return _coming_date; }
      set { _coming_date = value; }
    }
    private string _exam_date;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"exam_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string exam_date
    {
      get { return _exam_date; }
      set { _exam_date = value; }
    }
    private string _exam_time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"exam_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string exam_time
    {
      get { return _exam_time; }
      set { _exam_time = value; }
    }
    private string _department_code;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"department_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string department_code
    {
      get { return _department_code; }
      set { _department_code = value; }
    }
    private string _doctor;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _insur_type = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"insur_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string insur_type
    {
      get { return _insur_type; }
      set { _insur_type = value; }
    }
    private string _sunnab_status = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"sunnab_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sunnab_status
    {
      get { return _sunnab_status; }
      set { _sunnab_status = value; }
    }
    private string _exam_status = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"exam_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string exam_status
    {
      get { return _exam_status; }
      set { _exam_status = value; }
    }
    private string _coming_status = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"coming_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string coming_status
    {
      get { return _coming_status; }
      set { _coming_status = value; }
    }
    private string _patient_code = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"patient_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string patient_code
    {
      get { return _patient_code; }
      set { _patient_code = value; }
    }
    private string _reception_time = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"reception_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reception_time
    {
      get { return _reception_time; }
      set { _reception_time = value; }
    }
    private string _department_name = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"department_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string department_name
    {
      get { return _department_name; }
      set { _department_name = value; }
    }
    private string _sujin_no = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"sujin_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sujin_no
    {
      get { return _sujin_no; }
      set { _sujin_no = value; }
    }
    private string _doku_status = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"doku_status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doku_status
    {
      get { return _doku_status; }
      set { _doku_status = value; }
    }
    private string _cont_key = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"cont_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cont_key
    {
      get { return _cont_key; }
      set { _cont_key = value; }
    }
    private string _pkout1001 = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"pkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkout1001
    {
      get { return _pkout1001; }
      set { _pkout1001 = value; }
    }
    private readonly global::System.Collections.Generic.List<OCS2015U03OrderGubunInfo> _order_gubun = new global::System.Collections.Generic.List<OCS2015U03OrderGubunInfo>();
    [global::ProtoBuf.ProtoMember(17, Name=@"order_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS2015U03OrderGubunInfo> order_gubun
    {
      get { return _order_gubun; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
