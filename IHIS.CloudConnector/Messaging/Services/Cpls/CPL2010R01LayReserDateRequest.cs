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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010R01LayReserDateRequest")]
  public partial class CPL2010R01LayReserDateRequest : global::ProtoBuf.IExtensible
  {
    public CPL2010R01LayReserDateRequest() {}
    
    private string _ho_dong = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ho_dong", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ho_dong
    {
      get { return _ho_dong; }
      set { _ho_dong = value; }
    }
    private string _from_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"from_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string from_date
    {
      get { return _from_date; }
      set { _from_date = value; }
    }
    private string _to_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"to_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string to_date
    {
      get { return _to_date; }
      set { _to_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
