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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0503Q00FilteringTheInformationRequest")]
  public partial class OCS0503Q00FilteringTheInformationRequest : global::ProtoBuf.IExtensible
  {
    public OCS0503Q00FilteringTheInformationRequest() {}
    
    private string _grd_consult_naewon_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"grd_consult_naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_consult_naewon_date
    {
      get { return _grd_consult_naewon_date; }
      set { _grd_consult_naewon_date = value; }
    }
    private string _grd_consult_bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"grd_consult_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grd_consult_bunho
    {
      get { return _grd_consult_bunho; }
      set { _grd_consult_bunho = value; }
    }
    private string _grid_request_naewon_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"grid_request_naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grid_request_naewon_date
    {
      get { return _grid_request_naewon_date; }
      set { _grid_request_naewon_date = value; }
    }
    private string _grid_request_bunho = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"grid_request_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string grid_request_bunho
    {
      get { return _grid_request_bunho; }
      set { _grid_request_bunho = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
