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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHT0117grdCHT0117CheckResponse")]
  public partial class CHT0117grdCHT0117CheckResponse : global::ProtoBuf.IExtensible
  {
    public CHT0117grdCHT0117CheckResponse() {}
    
    private string _chk_result = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"chk_result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chk_result
    {
      get { return _chk_result; }
      set { _chk_result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
