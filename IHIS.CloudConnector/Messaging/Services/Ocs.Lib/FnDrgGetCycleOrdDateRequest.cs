//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FnDrgGetCycleOrdDateRequest")]
  public partial class FnDrgGetCycleOrdDateRequest : global::ProtoBuf.IExtensible
  {
    public FnDrgGetCycleOrdDateRequest() {}
    
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private string _ho_dong = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ho_dong", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ho_dong
    {
      get { return _ho_dong; }
      set { _ho_dong = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
