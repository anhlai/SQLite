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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MultiResultViewLayPaInfoResponse")]
  public partial class MultiResultViewLayPaInfoResponse : global::ProtoBuf.IExtensible
  {
    public MultiResultViewLayPaInfoResponse() {}
    
    private readonly global::System.Collections.Generic.List<MultiResultViewLayPaInfo> _lay_pa_info = new global::System.Collections.Generic.List<MultiResultViewLayPaInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"lay_pa_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<MultiResultViewLayPaInfo> lay_pa_info
    {
      get { return _lay_pa_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}