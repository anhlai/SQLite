//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL0108U00GrdMasterResponse")]
  public partial class CPL0108U00GrdMasterResponse : global::ProtoBuf.IExtensible
  {
    public CPL0108U00GrdMasterResponse() {}
    
    private readonly global::System.Collections.Generic.List<CPL0108U00InitGrdMasterListItemInfo> _grd_master = new global::System.Collections.Generic.List<CPL0108U00InitGrdMasterListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_master", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL0108U00InitGrdMasterListItemInfo> grd_master
    {
      get { return _grd_master; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
