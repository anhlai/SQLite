//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLIS2015U09CheckSmoCodeOnDeleteRequest")]
  public partial class CLIS2015U09CheckSmoCodeOnDeleteRequest : global::ProtoBuf.IExtensible
  {
    public CLIS2015U09CheckSmoCodeOnDeleteRequest() {}
    
    private string _clis_smo_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"clis_smo_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clis_smo_id
    {
      get { return _clis_smo_id; }
      set { _clis_smo_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}