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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3020U02ResultMapGrdRsltInfo")]
  public partial class CPL3020U02ResultMapGrdRsltInfo : global::ProtoBuf.IExtensible
  {
    public CPL3020U02ResultMapGrdRsltInfo() {}
    
    private string _result_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string result_code
    {
      get { return _result_code; }
      set { _result_code = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _gumsa_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gumsa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gumsa_name
    {
      get { return _gumsa_name; }
      set { _gumsa_name = value; }
    }
    private string _result_val = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"result_val", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string result_val
    {
      get { return _result_val; }
      set { _result_val = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
