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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0118U00GrdOCS0118Response")]
  public partial class OCS0118U00GrdOCS0118Response : global::ProtoBuf.IExtensible
  {
    public OCS0118U00GrdOCS0118Response() {}
    
    private readonly global::System.Collections.Generic.List<OCS0118U00GrdOCS0118Info> _grd_o_c_s0118_info = new global::System.Collections.Generic.List<OCS0118U00GrdOCS0118Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_o_c_s0118_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0118U00GrdOCS0118Info> grd_o_c_s0118_info
    {
      get { return _grd_o_c_s0118_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}