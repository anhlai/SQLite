//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrOcsConvertHangmogCodeResponse")]
  public partial class PrOcsConvertHangmogCodeResponse : global::ProtoBuf.IExtensible
  {
    public PrOcsConvertHangmogCodeResponse() {}
    
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _remark = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string remark
    {
      get { return _remark; }
      set { _remark = value; }
    }
    private string _msg_yn = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"msg_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg_yn
    {
      get { return _msg_yn; }
      set { _msg_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}