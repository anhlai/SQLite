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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetBogyongInfo3Request")]
  public partial class GetBogyongInfo3Request : global::ProtoBuf.IExtensible
  {
    public GetBogyongInfo3Request() {}
    
    private string _bogyong_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bogyong_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bogyong_code
    {
      get { return _bogyong_code; }
      set { _bogyong_code = value; }
    }
    private string _bogyong_gubun = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bogyong_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bogyong_gubun
    {
      get { return _bogyong_gubun; }
      set { _bogyong_gubun = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}