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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsaOCS0304U00GetYaksokDirectNameResponse")]
  public partial class OcsaOCS0304U00GetYaksokDirectNameResponse : global::ProtoBuf.IExtensible
  {
    public OcsaOCS0304U00GetYaksokDirectNameResponse() {}
    
    private string _yaksok_direct_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"yaksok_direct_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string yaksok_direct_name
    {
      get { return _yaksok_direct_name; }
      set { _yaksok_direct_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
