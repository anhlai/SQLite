//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuri_service.proto
// Note: requires additional types generated from: nuri_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuriNUR7001U00GetMaxSeqInNUR7001Response")]
  public partial class NuriNUR7001U00GetMaxSeqInNUR7001Response : global::ProtoBuf.IExtensible
  {
    public NuriNUR7001U00GetMaxSeqInNUR7001Response() {}
    
    private string _result = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
