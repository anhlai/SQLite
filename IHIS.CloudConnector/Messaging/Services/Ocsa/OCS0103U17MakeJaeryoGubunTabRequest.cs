//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0103U17MakeJaeryoGubunTabRequest")]
  public partial class OCS0103U17MakeJaeryoGubunTabRequest : global::ProtoBuf.IExtensible
  {
    public OCS0103U17MakeJaeryoGubunTabRequest() {}
    
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
