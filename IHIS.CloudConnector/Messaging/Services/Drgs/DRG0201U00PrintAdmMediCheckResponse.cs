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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG0201U00PrintAdmMediCheckResponse")]
  public partial class DRG0201U00PrintAdmMediCheckResponse : global::ProtoBuf.IExtensible
  {
    public DRG0201U00PrintAdmMediCheckResponse() {}
    
    private string _msg_result = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg_result
    {
      get { return _msg_result; }
      set { _msg_result = value; }
    }
    private string _ret_val = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ret_val", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ret_val
    {
      get { return _ret_val; }
      set { _ret_val = value; }
    }
    private string _pkdrg = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pkdrg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkdrg
    {
      get { return _pkdrg; }
      set { _pkdrg = value; }
    }
    private string _err_msg = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"err_msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string err_msg
    {
      get { return _err_msg; }
      set { _err_msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}