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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ORDERTRANOcs1003UpdateRequest")]
  public partial class ORDERTRANOcs1003UpdateRequest : global::ProtoBuf.IExtensible
  {
    public ORDERTRANOcs1003UpdateRequest() {}
    
    private readonly global::System.Collections.Generic.List<ORDERTRANOcs1003UpdateInfo> _save_layout_item = new global::System.Collections.Generic.List<ORDERTRANOcs1003UpdateInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"save_layout_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ORDERTRANOcs1003UpdateInfo> save_layout_item
    {
      get { return _save_layout_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}