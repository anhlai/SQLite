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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY2001U04RefreshCounterResponse")]
  public partial class PHY2001U04RefreshCounterResponse : global::ProtoBuf.IExtensible
  {
    public PHY2001U04RefreshCounterResponse() {}
    
    private readonly global::System.Collections.Generic.List<PHY2001U04RefreshCounterInfo> _ref_counter_item = new global::System.Collections.Generic.List<PHY2001U04RefreshCounterInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"ref_counter_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PHY2001U04RefreshCounterInfo> ref_counter_item
    {
      get { return _ref_counter_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
