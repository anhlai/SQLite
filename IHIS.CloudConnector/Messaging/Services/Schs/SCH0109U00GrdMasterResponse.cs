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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SCH0109U00GrdMasterResponse")]
  public partial class SCH0109U00GrdMasterResponse : global::ProtoBuf.IExtensible
  {
    public SCH0109U00GrdMasterResponse() {}
    
    private readonly global::System.Collections.Generic.List<SCH0109U00GrdMasterInfo> _grd_master_list = new global::System.Collections.Generic.List<SCH0109U00GrdMasterInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_master_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SCH0109U00GrdMasterInfo> grd_master_list
    {
      get { return _grd_master_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
