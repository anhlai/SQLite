//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0503U00CreateTimeComboResponse")]
  public partial class OCS0503U00CreateTimeComboResponse : global::ProtoBuf.IExtensible
  {
    public OCS0503U00CreateTimeComboResponse() {}
    
    private readonly global::System.Collections.Generic.List<OCS0503U00CreateTimeComboInfo> _createTime = new global::System.Collections.Generic.List<OCS0503U00CreateTimeComboInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"createTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0503U00CreateTimeComboInfo> createTime
    {
      get { return _createTime; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}