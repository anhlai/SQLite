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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"INJ1001U01SaveLayoutRequest")]
  public partial class INJ1001U01SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public INJ1001U01SaveLayoutRequest() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _upd_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"upd_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string upd_id
    {
      get { return _upd_id; }
      set { _upd_id = value; }
    }
    private readonly global::System.Collections.Generic.List<INJ1001U01SaveLayoutInfo> _save_layout_item = new global::System.Collections.Generic.List<INJ1001U01SaveLayoutInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"save_layout_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<INJ1001U01SaveLayoutInfo> save_layout_item
    {
      get { return _save_layout_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}