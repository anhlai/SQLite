//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U12ScreenOpenRequest")]
  public partial class OCS0103U12ScreenOpenRequest : global::ProtoBuf.IExtensible
  {
    public OCS0103U12ScreenOpenRequest() {}
    
    private OcsOrderBizGetUserOptionInfo _get_user_option = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"get_user_option", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public OcsOrderBizGetUserOptionInfo get_user_option
    {
      get { return _get_user_option; }
      set { _get_user_option = value; }
    }
    private readonly global::System.Collections.Generic.List<ComboDataSourceInfo> _combo_info = new global::System.Collections.Generic.List<ComboDataSourceInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"combo_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboDataSourceInfo> combo_info
    {
      get { return _combo_info; }
    }
  
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _pkinp1001 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pkinp1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkinp1001
    {
      get { return _pkinp1001; }
      set { _pkinp1001 = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
