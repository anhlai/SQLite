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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG0201U00TxtDrgBunhoDataValidatingKeyPressRequest")]
  public partial class DRG0201U00TxtDrgBunhoDataValidatingKeyPressRequest : global::ProtoBuf.IExtensible
  {
    public DRG0201U00TxtDrgBunhoDataValidatingKeyPressRequest() {}
    
    private string _jubsu_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_date
    {
      get { return _jubsu_date; }
      set { _jubsu_date = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
