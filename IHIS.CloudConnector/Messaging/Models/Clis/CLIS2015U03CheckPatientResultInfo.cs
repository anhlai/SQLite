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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLIS2015U03CheckPatientResultInfo")]
  public partial class CLIS2015U03CheckPatientResultInfo : global::ProtoBuf.IExtensible
  {
    public CLIS2015U03CheckPatientResultInfo() {}
    
    private string _chk_result = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"chk_result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chk_result
    {
      get { return _chk_result; }
      set { _chk_result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
