//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PFE0101U01GrdMCodeResponse")]
  public partial class PFE0101U01GrdMCodeResponse : global::ProtoBuf.IExtensible
  {
    public PFE0101U01GrdMCodeResponse() {}
    
    private readonly global::System.Collections.Generic.List<PFE0101U01GrdMCodeInfo> _grd_mcode_item = new global::System.Collections.Generic.List<PFE0101U01GrdMCodeInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_mcode_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PFE0101U01GrdMCodeInfo> grd_mcode_item
    {
      get { return _grd_mcode_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}