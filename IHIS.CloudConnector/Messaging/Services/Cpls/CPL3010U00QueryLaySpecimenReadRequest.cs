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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3010U00QueryLaySpecimenReadRequest")]
  public partial class CPL3010U00QueryLaySpecimenReadRequest : global::ProtoBuf.IExtensible
  {
    public CPL3010U00QueryLaySpecimenReadRequest() {}
    
    private string _specimen_read_value = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"specimen_read_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_read_value
    {
      get { return _specimen_read_value; }
      set { _specimen_read_value = value; }
    }
    private string _part_jubsuja = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"part_jubsuja", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string part_jubsuja
    {
      get { return _part_jubsuja; }
      set { _part_jubsuja = value; }
    }
    private string _gum_jubsu_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gum_jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gum_jubsu_date
    {
      get { return _gum_jubsu_date; }
      set { _gum_jubsu_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
