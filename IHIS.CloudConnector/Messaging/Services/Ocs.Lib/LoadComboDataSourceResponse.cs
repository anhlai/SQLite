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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadComboDataSourceResponse")]
  public partial class LoadComboDataSourceResponse : global::ProtoBuf.IExtensible
  {
    public LoadComboDataSourceResponse() {}
    
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _data_info = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> data_info
    {
      get { return _data_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
