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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0204Q00GrdOCS0205Response")]
  public partial class OCS0204Q00GrdOCS0205Response : global::ProtoBuf.IExtensible
  {
    public OCS0204Q00GrdOCS0205Response() {}
    
    private readonly global::System.Collections.Generic.List<Ocs0204Q00GrdOcs0205ListItemInfo> _grdocs0205_info = new global::System.Collections.Generic.List<Ocs0204Q00GrdOcs0205ListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grdocs0205_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Ocs0204Q00GrdOcs0205ListItemInfo> grdocs0205_info
    {
      get { return _grdocs0205_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
