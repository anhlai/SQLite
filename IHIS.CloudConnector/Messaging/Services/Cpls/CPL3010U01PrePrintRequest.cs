//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3010U01PrePrintRequest")]
  public partial class CPL3010U01PrePrintRequest : global::ProtoBuf.IExtensible
  {
    public CPL3010U01PrePrintRequest() {}
    
    private string _irai_str = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"irai_str", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string irai_str
    {
      get { return _irai_str; }
      set { _irai_str = value; }
    }
    private string _uitak_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uitak_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string uitak_code
    {
      get { return _uitak_code; }
      set { _uitak_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}