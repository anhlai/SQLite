//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_service.proto
// Note: requires additional types generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT0101U02GridCommentRequest")]
  public partial class NuroOUT0101U02GridCommentRequest : global::ProtoBuf.IExtensible
  {
    public NuroOUT0101U02GridCommentRequest() {}
    
    private string _patient_code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"patient_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string patient_code
    {
      get { return _patient_code; }
      set { _patient_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
