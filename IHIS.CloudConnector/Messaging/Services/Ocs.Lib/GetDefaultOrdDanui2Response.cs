//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetDefaultOrdDanui2Response")]
  public partial class GetDefaultOrdDanui2Response : global::ProtoBuf.IExtensible
  {
    public GetDefaultOrdDanui2Response() {}
    
    private readonly global::System.Collections.Generic.List<GetDefaultOrdDanuiInfo> _danui_item = new global::System.Collections.Generic.List<GetDefaultOrdDanuiInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"danui_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<GetDefaultOrdDanuiInfo> danui_item
    {
      get { return _danui_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}