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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0203U00GrdBAS0203Response")]
  public partial class BAS0203U00GrdBAS0203Response : global::ProtoBuf.IExtensible
  {
    public BAS0203U00GrdBAS0203Response() {}
    
    private readonly global::System.Collections.Generic.List<BAS0203U00GrdBAS0203Info> _grd_bas0203_item = new global::System.Collections.Generic.List<BAS0203U00GrdBAS0203Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_bas0203_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BAS0203U00GrdBAS0203Info> grd_bas0203_item
    {
      get { return _grd_bas0203_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}