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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IsOrderDataChangedEnabledRequest")]
  public partial class IsOrderDataChangedEnabledRequest : global::ProtoBuf.IExtensible
  {
    public IsOrderDataChangedEnabledRequest() {}
    
    private IsOrderDataChangedEnabledRequestInfo _input_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"input_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public IsOrderDataChangedEnabledRequestInfo input_info
    {
      get { return _input_info; }
      set { _input_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
