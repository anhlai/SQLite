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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IFS0003U01GrdIFS0003Response")]
  public partial class IFS0003U01GrdIFS0003Response : global::ProtoBuf.IExtensible
  {
    public IFS0003U01GrdIFS0003Response() {}
    
    private readonly global::System.Collections.Generic.List<IFS0003U01GrdIFS0003Info> _grd_ifs_item = new global::System.Collections.Generic.List<IFS0003U01GrdIFS0003Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_ifs_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<IFS0003U01GrdIFS0003Info> grd_ifs_item
    {
      get { return _grd_ifs_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
