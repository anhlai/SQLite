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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01GetChuciResponse")]
  public partial class OcsoOCS1003P01GetChuciResponse : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01GetChuciResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsoOCS1003P01GetChuciInfo> _chuci_item = new global::System.Collections.Generic.List<OcsoOCS1003P01GetChuciInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"chuci_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsoOCS1003P01GetChuciInfo> chuci_item
    {
      get { return _chuci_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
