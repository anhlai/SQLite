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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01CheckXRequest")]
  public partial class OcsoOCS1003P01CheckXRequest : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01CheckXRequest() {}
    
    private string _action_doctor;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"action_doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string action_doctor
    {
      get { return _action_doctor; }
      set { _action_doctor = value; }
    }
    private string _bunho;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _naewon_key;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"naewon_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string naewon_key
    {
      get { return _naewon_key; }
      set { _naewon_key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
