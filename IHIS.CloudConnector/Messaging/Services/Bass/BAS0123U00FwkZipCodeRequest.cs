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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0123U00FwkZipCodeRequest")]
  public partial class BAS0123U00FwkZipCodeRequest : global::ProtoBuf.IExtensible
  {
    public BAS0123U00FwkZipCodeRequest() {}
    
    private string _code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _find_1 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"find_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string find_1
    {
      get { return _find_1; }
      set { _find_1 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
