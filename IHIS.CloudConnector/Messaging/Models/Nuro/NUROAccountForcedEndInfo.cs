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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NUROAccountForcedEndInfo")]
  public partial class NUROAccountForcedEndInfo : global::ProtoBuf.IExtensible
  {
    public NUROAccountForcedEndInfo() {}
    
    private string _sunab_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sunab_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sunab_date
    {
      get { return _sunab_date; }
      set { _sunab_date = value; }
    }
    private string _fkout1003 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fkout1003", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkout1003
    {
      get { return _fkout1003; }
      set { _fkout1003 = value; }
    }
    private string _pkocs1003 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pkocs1003", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkocs1003
    {
      get { return _pkocs1003; }
      set { _pkocs1003 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
