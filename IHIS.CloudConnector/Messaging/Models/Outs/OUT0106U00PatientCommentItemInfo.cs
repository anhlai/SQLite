//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: outs_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OUT0106U00PatientCommentItemInfo")]
  public partial class OUT0106U00PatientCommentItemInfo : global::ProtoBuf.IExtensible
  {
    public OUT0106U00PatientCommentItemInfo() {}
    
    private string _patient_info = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"patient_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string patient_info
    {
      get { return _patient_info; }
      set { _patient_info = value; }
    }
    private string _patient_info_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"patient_info_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string patient_info_name
    {
      get { return _patient_info_name; }
      set { _patient_info_name = value; }
    }
    private string _start_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string start_date
    {
      get { return _start_date; }
      set { _start_date = value; }
    }
    private string _end_date = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"end_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string end_date
    {
      get { return _end_date; }
      set { _end_date = value; }
    }
    private string _comments = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string comments
    {
      get { return _comments; }
      set { _comments = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _cont_key = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"cont_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cont_key
    {
      get { return _cont_key; }
      set { _cont_key = value; }
    }
    private string _data_row_state = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"data_row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data_row_state
    {
      get { return _data_row_state; }
      set { _data_row_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
