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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgsDRG5100P01ConstantInfoRequest")]
  public partial class DrgsDRG5100P01ConstantInfoRequest : global::ProtoBuf.IExtensible
  {
    public DrgsDRG5100P01ConstantInfoRequest() {}
    
    private string _code_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code_type
    {
      get { return _code_type; }
      set { _code_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
