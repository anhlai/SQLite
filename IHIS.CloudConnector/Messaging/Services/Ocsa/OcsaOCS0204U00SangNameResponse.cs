//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ocsa_service.proto
// Note: requires additional types generated from: ocsa_model.proto
// Note: requires additional types generated from: ocs.lib_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsaOCS0204U00SangNameResponse")]
  public partial class OcsaOCS0204U00SangNameResponse : global::ProtoBuf.IExtensible
  {
    public OcsaOCS0204U00SangNameResponse() {}
    
    private string _sang_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sang_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sang_name
    {
      get { return _sang_name; }
      set { _sang_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}