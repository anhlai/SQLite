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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0101U00PrBasGridColumnChangedResponse")]
  public partial class BAS0101U00PrBasGridColumnChangedResponse : global::ProtoBuf.IExtensible
  {
    public BAS0101U00PrBasGridColumnChangedResponse() {}
    
    private BAS0101U00PrBasGridColumnChangedItemInfo _grd_master = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"grd_master", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BAS0101U00PrBasGridColumnChangedItemInfo grd_master
    {
      get { return _grd_master; }
      set { _grd_master = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}