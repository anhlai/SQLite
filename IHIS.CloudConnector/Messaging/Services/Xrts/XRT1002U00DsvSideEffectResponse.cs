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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"XRT1002U00DsvSideEffectResponse")]
  public partial class XRT1002U00DsvSideEffectResponse : global::ProtoBuf.IExtensible
  {
    public XRT1002U00DsvSideEffectResponse() {}
    
    private readonly global::System.Collections.Generic.List<XRT1002U00DsvSideEffectInfo> _dsv_side_effect_item = new global::System.Collections.Generic.List<XRT1002U00DsvSideEffectInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dsv_side_effect_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<XRT1002U00DsvSideEffectInfo> dsv_side_effect_item
    {
      get { return _dsv_side_effect_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
