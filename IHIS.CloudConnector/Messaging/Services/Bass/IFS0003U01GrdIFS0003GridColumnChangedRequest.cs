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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IFS0003U01GrdIFS0003GridColumnChangedRequest")]
  public partial class IFS0003U01GrdIFS0003GridColumnChangedRequest : global::ProtoBuf.IExtensible
  {
    public IFS0003U01GrdIFS0003GridColumnChangedRequest() {}
    
    private string _col_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"col_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string col_name
    {
      get { return _col_name; }
      set { _col_name = value; }
    }
    private string _map_gubun = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"map_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string map_gubun
    {
      get { return _map_gubun; }
      set { _map_gubun = value; }
    }
    private string _code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}