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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OUT1001P03PaBeforeBoxResponse")]
  public partial class OUT1001P03PaBeforeBoxResponse : global::ProtoBuf.IExtensible
  {
    public OUT1001P03PaBeforeBoxResponse() {}
    
    private string _bunho_type = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho_type
    {
      get { return _bunho_type; }
      set { _bunho_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}