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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01CheckIsSameNameYnResponse")]
  public partial class OcsoOCS1003P01CheckIsSameNameYnResponse : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01CheckIsSameNameYnResponse() {}
    
    private string _value_check = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value_check", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value_check
    {
      get { return _value_check; }
      set { _value_check = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
