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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OFMakeGwaComboResponse")]
  public partial class OFMakeGwaComboResponse : global::ProtoBuf.IExtensible
  {
    public OFMakeGwaComboResponse() {}
    
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _gwa_combo_item = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"gwa_combo_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> gwa_combo_item
    {
      get { return _gwa_combo_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}