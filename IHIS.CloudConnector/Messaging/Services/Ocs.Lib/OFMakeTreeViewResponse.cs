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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OFMakeTreeViewResponse")]
  public partial class OFMakeTreeViewResponse : global::ProtoBuf.IExtensible
  {
    public OFMakeTreeViewResponse() {}
    
    private readonly global::System.Collections.Generic.List<OFMakeTreeViewInfo> _tree_view_item = new global::System.Collections.Generic.List<OFMakeTreeViewInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"tree_view_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OFMakeTreeViewInfo> tree_view_item
    {
      get { return _tree_view_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
