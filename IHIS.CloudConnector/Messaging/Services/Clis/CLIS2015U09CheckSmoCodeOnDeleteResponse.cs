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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLIS2015U09CheckSmoCodeOnDeleteResponse")]
  public partial class CLIS2015U09CheckSmoCodeOnDeleteResponse : global::ProtoBuf.IExtensible
  {
    public CLIS2015U09CheckSmoCodeOnDeleteResponse() {}
    
    private string _cnt = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cnt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cnt
    {
      get { return _cnt; }
      set { _cnt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
