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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT1001U01CheckY2Request")]
  public partial class NuroOUT1001U01CheckY2Request : global::ProtoBuf.IExtensible
  {
    public NuroOUT1001U01CheckY2Request() {}
    
    private string _naewon_date;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _gwa;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _doctor;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _naewon_type;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"naewon_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string naewon_type
    {
      get { return _naewon_type; }
      set { _naewon_type = value; }
    }
    private string _jubsu_no;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"jubsu_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string jubsu_no
    {
      get { return _jubsu_no; }
      set { _jubsu_no = value; }
    }
    private string _bunho;
      [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string bunho
    {
        get { return _bunho; }
        set { _bunho = value; }
    }

    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
