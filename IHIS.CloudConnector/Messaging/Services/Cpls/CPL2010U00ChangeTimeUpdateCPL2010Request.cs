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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010U00ChangeTimeUpdateCPL2010Request")]
  public partial class CPL2010U00ChangeTimeUpdateCPL2010Request : global::ProtoBuf.IExtensible
  {
    public CPL2010U00ChangeTimeUpdateCPL2010Request() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CPL2010U00ChangeTimeGrdSpecimenListItemInfo> _input_list = new global::System.Collections.Generic.List<CPL2010U00ChangeTimeGrdSpecimenListItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"input_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL2010U00ChangeTimeGrdSpecimenListItemInfo> input_list
    {
      get { return _input_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}