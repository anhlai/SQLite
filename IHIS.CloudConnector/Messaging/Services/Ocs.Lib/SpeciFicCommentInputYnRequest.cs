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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SpeciFicCommentInputYnRequest")]
  public partial class SpeciFicCommentInputYnRequest : global::ProtoBuf.IExtensible
  {
    public SpeciFicCommentInputYnRequest() {}
    
    private string _hanmog_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hanmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hanmog_code
    {
      get { return _hanmog_code; }
      set { _hanmog_code = value; }
    }
    private string _pkocskey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pkocskey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkocskey
    {
      get { return _pkocskey; }
      set { _pkocskey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}