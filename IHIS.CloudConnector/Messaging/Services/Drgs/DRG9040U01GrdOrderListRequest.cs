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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG9040U01GrdOrderListRequest")]
  public partial class DRG9040U01GrdOrderListRequest : global::ProtoBuf.IExtensible
  {
    public DRG9040U01GrdOrderListRequest() {}
    
    private string _jubsu_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_date
    {
      get { return _jubsu_date; }
      set { _jubsu_date = value; }
    }
    private string _drg_bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"drg_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_bunho
    {
      get { return _drg_bunho; }
      set { _drg_bunho = value; }
    }
    private string _magam_bunryu = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"magam_bunryu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string magam_bunryu
    {
      get { return _magam_bunryu; }
      set { _magam_bunryu = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}