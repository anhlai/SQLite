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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRGOCSCHKSmallCodeDataValidatingRequest")]
  public partial class DRGOCSCHKSmallCodeDataValidatingRequest : global::ProtoBuf.IExtensible
  {
    public DRGOCSCHKSmallCodeDataValidatingRequest() {}
    
    private string _code_1 = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_1
    {
      get { return _code_1; }
      set { _code_1 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
