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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0301U00FwkUserRequest")]
  public partial class OCS0301U00FwkUserRequest : global::ProtoBuf.IExtensible
  {
    public OCS0301U00FwkUserRequest() {}
    
    private string _query_mode = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"query_mode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string query_mode
    {
      get { return _query_mode; }
      set { _query_mode = value; }
    }
    private string _find1 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"find1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string find1
    {
      get { return _find1; }
      set { _find1 = value; }
    }
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
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