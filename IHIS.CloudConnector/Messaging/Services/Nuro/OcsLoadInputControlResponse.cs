//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsLoadInputControlResponse")]
  public partial class OcsLoadInputControlResponse : global::ProtoBuf.IExtensible
  {
    public OcsLoadInputControlResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsLoadInputControlListItemInfo> _control_list = new global::System.Collections.Generic.List<OcsLoadInputControlListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"control_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsLoadInputControlListItemInfo> control_list
    {
      get { return _control_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
