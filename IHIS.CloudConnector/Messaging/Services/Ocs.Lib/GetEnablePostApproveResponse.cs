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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetEnablePostApproveResponse")]
  public partial class GetEnablePostApproveResponse : global::ProtoBuf.IExtensible
  {
    public GetEnablePostApproveResponse() {}
    
    private string _pos_tapprove_yn = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pos_tapprove_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pos_tapprove_yn
    {
      get { return _pos_tapprove_yn; }
      set { _pos_tapprove_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
