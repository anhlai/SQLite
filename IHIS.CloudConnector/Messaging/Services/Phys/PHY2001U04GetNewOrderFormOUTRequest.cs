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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY2001U04GetNewOrderFormOUTRequest")]
  public partial class PHY2001U04GetNewOrderFormOUTRequest : global::ProtoBuf.IExtensible
  {
    public PHY2001U04GetNewOrderFormOUTRequest() {}
    
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private string _time_hour = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time_hour", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string time_hour
    {
      get { return _time_hour; }
      set { _time_hour = value; }
    }
    private string _time_min = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"time_min", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string time_min
    {
      get { return _time_min; }
      set { _time_min = value; }
    }
    private string _time_sec = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"time_sec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string time_sec
    {
      get { return _time_sec; }
      set { _time_sec = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
