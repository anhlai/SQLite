//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0311U00GridListResponse")]
  public partial class BAS0311U00GridListResponse : global::ProtoBuf.IExtensible
  {
    public BAS0311U00GridListResponse() {}
    
    private readonly global::System.Collections.Generic.List<BAS0311U00GridListItemInfo> _dt = new global::System.Collections.Generic.List<BAS0311U00GridListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0311U00GridListItemInfo> dt
    {
      get { return _dt; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}