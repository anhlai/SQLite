//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuts_service.proto
// Note: requires additional types generated from: nuts_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NUT0001U00SaveLayoutRequest")]
  public partial class NUT0001U00SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public NUT0001U00SaveLayoutRequest() {}
    
    private readonly global::System.Collections.Generic.List<NUT0001U00GrdNUT0001ItemInfo> _grd001_item_info = new global::System.Collections.Generic.List<NUT0001U00GrdNUT0001ItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd001_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NUT0001U00GrdNUT0001ItemInfo> grd001_item_info
    {
      get { return _grd001_item_info; }
    }
  
    private readonly global::System.Collections.Generic.List<NUT0001U00GrdNUT0002ItemInfo> _grd002_item_info = new global::System.Collections.Generic.List<NUT0001U00GrdNUT0002ItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"grd002_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NUT0001U00GrdNUT0002ItemInfo> grd002_item_info
    {
      get { return _grd002_item_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
