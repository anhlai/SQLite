//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: system_service.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckUserDoctorLoginResponse")]
  public partial class CheckUserDoctorLoginResponse : global::ProtoBuf.IExtensible
  {
    public CheckUserDoctorLoginResponse() {}
    
    private string _gwa_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_name
    {
      get { return _gwa_name; }
      set { _gwa_name = value; }
    }
    private UserItemInfo _user_item_info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_item_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public UserItemInfo user_item_info
    {
      get { return _user_item_info; }
      set { _user_item_info = value; }
    }
    private string _error_message = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"error_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error_message
    {
      get { return _error_message; }
      set { _error_message = value; }
    }
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _cbo_list = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"cbo_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> cbo_list
    {
      get { return _cbo_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
