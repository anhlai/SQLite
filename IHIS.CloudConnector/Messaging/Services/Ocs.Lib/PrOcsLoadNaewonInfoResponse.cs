//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrOcsLoadNaewonInfoResponse")]
  public partial class PrOcsLoadNaewonInfoResponse : global::ProtoBuf.IExtensible
  {
    public PrOcsLoadNaewonInfoResponse() {}
    
    private readonly global::System.Collections.Generic.List<PrOcsLoadNaewonInfo> _naewon_item = new global::System.Collections.Generic.List<PrOcsLoadNaewonInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"naewon_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PrOcsLoadNaewonInfo> naewon_item
    {
      get { return _naewon_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}