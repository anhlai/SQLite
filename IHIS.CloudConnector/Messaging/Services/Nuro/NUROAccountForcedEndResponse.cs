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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NUROAccountForcedEndResponse")]
  public partial class NUROAccountForcedEndResponse : global::ProtoBuf.IExtensible
  {
    public NUROAccountForcedEndResponse() {}
    
    private bool _result = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errorCode = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"errorCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errorCode
    {
      get { return _errorCode; }
      set { _errorCode = value; }
    }
    private string _strOutput = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"strOutput", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string strOutput
    {
      get { return _strOutput; }
      set { _strOutput = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}