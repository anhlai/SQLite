//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OUT0101U02SaveGridRequest")]
  public partial class OUT0101U02SaveGridRequest : global::ProtoBuf.IExtensible
  {
    public OUT0101U02SaveGridRequest() {}
    
    private readonly global::System.Collections.Generic.List<NuroOUT0101U02GridPatientInfo> _patient_list = new global::System.Collections.Generic.List<NuroOUT0101U02GridPatientInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"patient_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroOUT0101U02GridPatientInfo> patient_list
    {
      get { return _patient_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NuroOUT0101U02GridBoheomInfo> _boheom_list = new global::System.Collections.Generic.List<NuroOUT0101U02GridBoheomInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"boheom_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroOUT0101U02GridBoheomInfo> boheom_list
    {
      get { return _boheom_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NuroOUT0101U02GridGongbiListInfo> _gongbi_list = new global::System.Collections.Generic.List<NuroOUT0101U02GridGongbiListInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"gongbi_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroOUT0101U02GridGongbiListInfo> gongbi_list
    {
      get { return _gongbi_list; }
    }
  
    private string _user_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _patient_code = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"patient_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string patient_code
    {
      get { return _patient_code; }
      set { _patient_code = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _auto_bunho_flg = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"auto_bunho_flg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string auto_bunho_flg
    {
      get { return _auto_bunho_flg; }
      set { _auto_bunho_flg = value; }
    }
    private string _orca_request = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"orca_request", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string orca_request
    {
      get { return _orca_request; }
      set { _orca_request = value; }
    }
    private string _orca_gigwan_code = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"orca_gigwan_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string orca_gigwan_code
    {
      get { return _orca_gigwan_code; }
      set { _orca_gigwan_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
