//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0212U00CListItemResponse")]
  public partial class BAS0212U00CListItemResponse : global::ProtoBuf.IExtensible
  {
    public BAS0212U00CListItemResponse() {}
    
    private readonly global::System.Collections.Generic.List<BAS0212U00ListItemRequestInfo> _combo_name = new global::System.Collections.Generic.List<BAS0212U00ListItemRequestInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"combo_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0212U00ListItemRequestInfo> combo_name
    {
      get { return _combo_name; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}