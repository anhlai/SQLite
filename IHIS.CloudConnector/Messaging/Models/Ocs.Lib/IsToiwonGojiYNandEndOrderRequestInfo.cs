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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IsToiwonGojiYNandEndOrderRequestInfo")]
  public partial class IsToiwonGojiYNandEndOrderRequestInfo : global::ProtoBuf.IExtensible
  {
    public IsToiwonGojiYNandEndOrderRequestInfo() {}
    
    private string _pkinp1001 = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pkinp1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkinp1001
    {
      get { return _pkinp1001; }
      set { _pkinp1001 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
