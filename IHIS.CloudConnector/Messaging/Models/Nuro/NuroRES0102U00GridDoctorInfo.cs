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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroRES0102U00GridDoctorInfo")]
  public partial class NuroRES0102U00GridDoctorInfo : global::ProtoBuf.IExtensible
  {
    public NuroRES0102U00GridDoctorInfo() {}
    
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _start_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"start_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string start_date
    {
      get { return _start_date; }
      set { _start_date = value; }
    }
    private string _end_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"end_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string end_date
    {
      get { return _end_date; }
      set { _end_date = value; }
    }
    private string _sayu = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"sayu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sayu
    {
      get { return _sayu; }
      set { _sayu = value; }
    }
    private string _data_row_state = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"data_row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
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