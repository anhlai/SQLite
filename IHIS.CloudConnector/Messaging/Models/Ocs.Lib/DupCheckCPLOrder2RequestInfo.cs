//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DupCheckCPLOrder2RequestInfo")]
  public partial class DupCheckCPLOrder2RequestInfo : global::ProtoBuf.IExtensible
  {
    public DupCheckCPLOrder2RequestInfo() {}
    
    private string _io_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"io_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_gubun
    {
      get { return _io_gubun; }
      set { _io_gubun = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _specimen_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"specimen_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_code
    {
      get { return _specimen_code; }
      set { _specimen_code = value; }
    }
    private string _check_date = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"check_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string check_date
    {
      get { return _check_date; }
      set { _check_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}