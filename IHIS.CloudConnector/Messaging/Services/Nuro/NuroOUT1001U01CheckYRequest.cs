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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT1001U01CheckYRequest")]
  public partial class NuroOUT1001U01CheckYRequest : global::ProtoBuf.IExtensible
  {
    public NuroOUT1001U01CheckYRequest() {}
    
    private string _pkout1001;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string pkout1001
    {
      get { return _pkout1001; }
      set { _pkout1001 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
