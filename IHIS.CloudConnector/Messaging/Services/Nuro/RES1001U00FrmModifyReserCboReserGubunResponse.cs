//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_service.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RES1001U00FrmModifyReserCboReserGubunResponse")]
  public partial class RES1001U00FrmModifyReserCboReserGubunResponse : global::ProtoBuf.IExtensible
  {
    public RES1001U00FrmModifyReserCboReserGubunResponse() {}
    
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _cbo_reser_gubun_info = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"cbo_reser_gubun_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> cbo_reser_gubun_info
    {
      get { return _cbo_reser_gubun_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
