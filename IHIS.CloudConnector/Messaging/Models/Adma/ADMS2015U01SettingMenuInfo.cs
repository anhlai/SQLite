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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADMS2015U01SettingMenuInfo")]
  public partial class ADMS2015U01SettingMenuInfo : global::ProtoBuf.IExtensible
  {
    public ADMS2015U01SettingMenuInfo() {}
    
    private string _tr_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tr_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tr_id
    {
      get { return _tr_id; }
      set { _tr_id = value; }
    }
    private string _select_flg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"select_flg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string select_flg
    {
      get { return _select_flg; }
      set { _select_flg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
