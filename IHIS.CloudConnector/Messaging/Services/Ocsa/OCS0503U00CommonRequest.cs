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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0503U00CommonRequest")]
  public partial class OCS0503U00CommonRequest : global::ProtoBuf.IExtensible
  {
    public OCS0503U00CommonRequest() {}
    
    private string _naewon_key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"naewon_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_key
    {
      get { return _naewon_key; }
      set { _naewon_key = value; }
    }
    private string _reser_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"reser_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_date
    {
      get { return _reser_date; }
      set { _reser_date = value; }
    }
    private string _reser_time = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reser_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_time
    {
      get { return _reser_time; }
      set { _reser_time = value; }
    }
    private string _reser_doctor = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"reser_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_doctor
    {
      get { return _reser_doctor; }
      set { _reser_doctor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
