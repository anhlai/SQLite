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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0101U04GrdMasterResponse")]
  public partial class BAS0101U04GrdMasterResponse : global::ProtoBuf.IExtensible
  {
    public BAS0101U04GrdMasterResponse() {}
    
    private readonly global::System.Collections.Generic.List<BAS0101U04GrdMasterInfo> _grd_master_item = new global::System.Collections.Generic.List<BAS0101U04GrdMasterInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_master_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0101U04GrdMasterInfo> grd_master_item
    {
      get { return _grd_master_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
