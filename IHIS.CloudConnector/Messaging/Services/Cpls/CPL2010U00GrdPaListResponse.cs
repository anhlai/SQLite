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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010U00GrdPaListResponse")]
  public partial class CPL2010U00GrdPaListResponse : global::ProtoBuf.IExtensible
  {
    public CPL2010U00GrdPaListResponse() {}
    
    private readonly global::System.Collections.Generic.List<CPL2010U00GrdPaListItemInfo> _grdPalist_list = new global::System.Collections.Generic.List<CPL2010U00GrdPaListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grdPalist_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL2010U00GrdPaListItemInfo> grdPalist_list
    {
      get { return _grdPalist_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
