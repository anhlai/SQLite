//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U00SaveLayoutRequest")]
  public partial class OCS0103U00SaveLayoutRequest : global::ProtoBuf.IExtensible
  {
    public OCS0103U00SaveLayoutRequest() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private readonly global::System.Collections.Generic.List<OCS0103U00GrdOCS0103Info> _grd_ocs0103_item = new global::System.Collections.Generic.List<OCS0103U00GrdOCS0103Info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"grd_ocs0103_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U00GrdOCS0103Info> grd_ocs0103_item
    {
      get { return _grd_ocs0103_item; }
    }
  
    private readonly global::System.Collections.Generic.List<OCS0103U00GrdOCS0108Info> _grd_ocs0108_item = new global::System.Collections.Generic.List<OCS0103U00GrdOCS0108Info>();
    [global::ProtoBuf.ProtoMember(3, Name=@"grd_ocs0108_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U00GrdOCS0108Info> grd_ocs0108_item
    {
      get { return _grd_ocs0108_item; }
    }
  
    private readonly global::System.Collections.Generic.List<OCS0103U00GrdOCS0115Info> _grd_ocs0115_item = new global::System.Collections.Generic.List<OCS0103U00GrdOCS0115Info>();
    [global::ProtoBuf.ProtoMember(4, Name=@"grd_ocs0115_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U00GrdOCS0115Info> grd_ocs0115_item
    {
      get { return _grd_ocs0115_item; }
    }
  
    private readonly global::System.Collections.Generic.List<OCS0103U00GrdOCS0113Info> _grd_ocs0113_item = new global::System.Collections.Generic.List<OCS0103U00GrdOCS0113Info>();
    [global::ProtoBuf.ProtoMember(5, Name=@"grd_ocs0113_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U00GrdOCS0113Info> grd_ocs0113_item
    {
      get { return _grd_ocs0113_item; }
    }
  
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
