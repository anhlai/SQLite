//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT0101U02GetInsuranceCode")]
  public partial class NuroOUT0101U02GetInsuranceCode : global::ProtoBuf.IExtensible
  {
    public NuroOUT0101U02GetInsuranceCode() {}
    
    private string _insurance_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"insurance_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string insurance_code
    {
      get { return _insurance_code; }
      set { _insurance_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}