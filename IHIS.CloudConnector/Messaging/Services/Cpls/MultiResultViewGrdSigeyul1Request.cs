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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MultiResultViewGrdSigeyul1Request")]
  public partial class MultiResultViewGrdSigeyul1Request : global::ProtoBuf.IExtensible
  {
    public MultiResultViewGrdSigeyul1Request() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _group_hangmog = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"group_hangmog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string group_hangmog
    {
      get { return _group_hangmog; }
      set { _group_hangmog = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
