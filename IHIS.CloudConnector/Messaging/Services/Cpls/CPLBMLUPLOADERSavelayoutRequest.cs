//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPLBMLUPLOADERSavelayoutRequest")]
  public partial class CPLBMLUPLOADERSavelayoutRequest : global::ProtoBuf.IExtensible
  {
    public CPLBMLUPLOADERSavelayoutRequest() {}
    
    private readonly global::System.Collections.Generic.List<CPLBMLUPLOADERSavelayoutInfo> _uploader_savelayout_info = new global::System.Collections.Generic.List<CPLBMLUPLOADERSavelayoutInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"uploader_savelayout_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPLBMLUPLOADERSavelayoutInfo> uploader_savelayout_info
    {
      get { return _uploader_savelayout_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
