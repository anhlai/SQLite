//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0310P01GrdJinryoMasterResponse")]
  public partial class BAS0310P01GrdJinryoMasterResponse : global::ProtoBuf.IExtensible
  {
    public BAS0310P01GrdJinryoMasterResponse() {}
    
    private readonly global::System.Collections.Generic.List<BAS0310P01GrdJinryoMasterInfo> _dt = new global::System.Collections.Generic.List<BAS0310P01GrdJinryoMasterInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0310P01GrdJinryoMasterInfo> dt
    {
      get { return _dt; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
