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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoConfirmConsultRequest")]
  public partial class NoConfirmConsultRequest : global::ProtoBuf.IExtensible
  {
    public NoConfirmConsultRequest() {}
    
    private NoConfirmConsultInfo _consult_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"consult_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public NoConfirmConsultInfo consult_info
    {
      get { return _consult_info; }
      set { _consult_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
