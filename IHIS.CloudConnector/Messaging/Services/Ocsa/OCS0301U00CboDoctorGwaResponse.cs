//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ocsa_service.proto
// Note: requires additional types generated from: ocsa_model.proto
// Note: requires additional types generated from: ocs.lib_model.proto
// Note: requires additional types generated from: system_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0301U00CboDoctorGwaResponse")]
  public partial class OCS0301U00CboDoctorGwaResponse : global::ProtoBuf.IExtensible
  {
    public OCS0301U00CboDoctorGwaResponse() {}
    
    private string _gwa_info = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gwa_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa_info
    {
      get { return _gwa_info; }
      set { _gwa_info = value; }
    }
    private string _user_info = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_info
    {
      get { return _user_info; }
      set { _user_info = value; }
    }
    private string _user_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"user_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_gubun
    {
      get { return _user_gubun; }
      set { _user_gubun = value; }
    }
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _doctor_gwa_cb = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"doctor_gwa_cb", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> doctor_gwa_cb
    {
      get { return _doctor_gwa_cb; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}