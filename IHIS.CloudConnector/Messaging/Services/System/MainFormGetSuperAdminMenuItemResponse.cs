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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MainFormGetSuperAdminMenuItemResponse")]
  public partial class MainFormGetSuperAdminMenuItemResponse : global::ProtoBuf.IExtensible
  {
    public MainFormGetSuperAdminMenuItemResponse() {}
    
    private readonly global::System.Collections.Generic.List<MainFormGetMainMenuItemInfo> _menu_item = new global::System.Collections.Generic.List<MainFormGetMainMenuItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"menu_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<MainFormGetMainMenuItemInfo> menu_item
    {
      get { return _menu_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
