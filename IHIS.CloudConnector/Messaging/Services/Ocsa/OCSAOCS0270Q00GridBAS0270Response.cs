//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OCS0270Q00.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCSAOCS0270Q00GridBAS0270Response")]
  public partial class OCSAOCS0270Q00GridBAS0270Response : global::ProtoBuf.IExtensible
  {
    public OCSAOCS0270Q00GridBAS0270Response() {}
    
    private readonly global::System.Collections.Generic.List<OCSAOCS0270Q00GridBAS0270RowInfo> _Rows = new global::System.Collections.Generic.List<OCSAOCS0270Q00GridBAS0270RowInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCSAOCS0270Q00GridBAS0270RowInfo> Rows
    {
      get { return _Rows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
