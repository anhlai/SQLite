//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveRegularOrderRequest")]
  public partial class SaveRegularOrderRequest : global::ProtoBuf.IExtensible
  {
    public SaveRegularOrderRequest() {}
    
    private string _work_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"work_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string work_gubun
    {
      get { return _work_gubun; }
      set { _work_gubun = value; }
    }
    private string _pkKey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pkKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkKey
    {
      get { return _pkKey; }
      set { _pkKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
