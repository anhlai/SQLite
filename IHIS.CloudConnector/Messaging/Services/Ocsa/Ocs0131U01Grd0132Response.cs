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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Ocs0131U01Grd0132Response")]
  public partial class Ocs0131U01Grd0132Response : global::ProtoBuf.IExtensible
  {
    public Ocs0131U01Grd0132Response() {}
    
    private readonly global::System.Collections.Generic.List<Ocs0131U01Grd0132ListItemInfo> _grd_0132_info = new global::System.Collections.Generic.List<Ocs0131U01Grd0132ListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_0132_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Ocs0131U01Grd0132ListItemInfo> grd_0132_info
    {
      get { return _grd_0132_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}