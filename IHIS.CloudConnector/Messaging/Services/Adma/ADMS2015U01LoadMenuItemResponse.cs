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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADMS2015U01LoadMenuItemResponse")]
  public partial class ADMS2015U01LoadMenuItemResponse : global::ProtoBuf.IExtensible
  {
    public ADMS2015U01LoadMenuItemResponse() {}
    
    private readonly global::System.Collections.Generic.List<ADMS2015U01MenuInfo> _menu_info = new global::System.Collections.Generic.List<ADMS2015U01MenuInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"menu_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ADMS2015U01MenuInfo> menu_info
    {
      get { return _menu_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
