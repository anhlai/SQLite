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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010U00GrdTubeQueryStartingResponse")]
  public partial class CPL2010U00GrdTubeQueryStartingResponse : global::ProtoBuf.IExtensible
  {
    public CPL2010U00GrdTubeQueryStartingResponse() {}
    
    private readonly global::System.Collections.Generic.List<CPL2010U00GrdTubeListItemInfo> _grdTube_list = new global::System.Collections.Generic.List<CPL2010U00GrdTubeListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grdTube_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL2010U00GrdTubeListItemInfo> grdTube_list
    {
      get { return _grdTube_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
