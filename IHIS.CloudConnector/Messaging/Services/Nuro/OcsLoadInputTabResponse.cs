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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsLoadInputTabResponse")]
  public partial class OcsLoadInputTabResponse : global::ProtoBuf.IExtensible
  {
    public OcsLoadInputTabResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsLoadInputTabListItemInfo> _tab_list = new global::System.Collections.Generic.List<OcsLoadInputTabListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"tab_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsLoadInputTabListItemInfo> tab_list
    {
      get { return _tab_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
