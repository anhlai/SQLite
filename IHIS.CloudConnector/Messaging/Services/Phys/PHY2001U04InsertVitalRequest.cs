//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY2001U04InsertVitalRequest")]
  public partial class PHY2001U04InsertVitalRequest : global::ProtoBuf.IExtensible
  {
    public PHY2001U04InsertVitalRequest() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _measure_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"measure_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string measure_date
    {
      get { return _measure_date; }
      set { _measure_date = value; }
    }
    private string _measure_time = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"measure_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string measure_time
    {
      get { return _measure_time; }
      set { _measure_time = value; }
    }
    private string _bp_to = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"bp_to", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bp_to
    {
      get { return _bp_to; }
      set { _bp_to = value; }
    }
    private string _bp_from = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bp_from", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bp_from
    {
      get { return _bp_from; }
      set { _bp_from = value; }
    }
    private string _pulse = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"pulse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pulse
    {
      get { return _pulse; }
      set { _pulse = value; }
    }
    private string _bt = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"bt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bt
    {
      get { return _bt; }
      set { _bt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
