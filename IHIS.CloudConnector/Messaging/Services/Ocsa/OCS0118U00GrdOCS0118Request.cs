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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0118U00GrdOCS0118Request")]
  public partial class OCS0118U00GrdOCS0118Request : global::ProtoBuf.IExtensible
  {
    public OCS0118U00GrdOCS0118Request() {}
    
    private string _hangmog_name_inx = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hangmog_name_inx", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_name_inx
    {
      get { return _hangmog_name_inx; }
      set { _hangmog_name_inx = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
