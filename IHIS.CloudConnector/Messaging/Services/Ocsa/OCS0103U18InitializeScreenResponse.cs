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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U18InitializeScreenResponse")]
  public partial class OCS0103U18InitializeScreenResponse : global::ProtoBuf.IExtensible
  {
    public OCS0103U18InitializeScreenResponse() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _main_doctor_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"main_doctor_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string main_doctor_code
    {
      get { return _main_doctor_code; }
      set { _main_doctor_code = value; }
    }
    private readonly global::System.Collections.Generic.List<OCS0103U17LayHangwiGubunInfo> _lay_hangwi_gubun_info = new global::System.Collections.Generic.List<OCS0103U17LayHangwiGubunInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"lay_hangwi_gubun_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U17LayHangwiGubunInfo> lay_hangwi_gubun_info
    {
      get { return _lay_hangwi_gubun_info; }
    }
  
    private readonly global::System.Collections.Generic.List<OCS0103U18MakeJaeryoGubunTabListItemInfo> _make_jaeryo_gubun_info = new global::System.Collections.Generic.List<OCS0103U18MakeJaeryoGubunTabListItemInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"make_jaeryo_gubun_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0103U18MakeJaeryoGubunTabListItemInfo> make_jaeryo_gubun_info
    {
      get { return _make_jaeryo_gubun_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}