//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: bass_service.proto
// Note: requires additional types generated from: bass_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0110Q00GrdBAS0110Response")]
  public partial class BAS0110Q00GrdBAS0110Response : global::ProtoBuf.IExtensible
  {
    public BAS0110Q00GrdBAS0110Response() {}
    
    private readonly global::System.Collections.Generic.List<BAS0110Q00GrdBAS0110ItemInfo> _grd_bas0110_item_info = new global::System.Collections.Generic.List<BAS0110Q00GrdBAS0110ItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_bas0110_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0110Q00GrdBAS0110ItemInfo> grd_bas0110_item_info
    {
      get { return _grd_bas0110_item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}