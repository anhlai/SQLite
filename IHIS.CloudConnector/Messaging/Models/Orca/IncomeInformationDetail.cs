//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: shunou_model.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IncomeInformationDetail")]
  public partial class IncomeInformationDetail : global::ProtoBuf.IExtensible
  {
    public IncomeInformationDetail() {}
    
    private string _requested_amount;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"requested_amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string requested_amount
    {
      get { return _requested_amount; }
      set { _requested_amount = value; }
    }
    private string _paid_amount;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"paid_amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string paid_amount
    {
      get { return _paid_amount; }
      set { _paid_amount = value; }
    }
    private string _response_date;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"response_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string response_date
    {
      get { return _response_date; }
      set { _response_date = value; }
    }
    private string _status;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string status
    {
      get { return _status; }
      set { _status = value; }
    }
    private string _payment_method;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"payment_method", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string payment_method
    {
      get { return _payment_method; }
      set { _payment_method = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
 
}