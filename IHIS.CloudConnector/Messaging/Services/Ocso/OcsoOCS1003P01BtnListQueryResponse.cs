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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01BtnListQueryResponse")]
  public partial class OcsoOCS1003P01BtnListQueryResponse : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01BtnListQueryResponse() {}
    
    private readonly global::System.Collections.Generic.List<OcsoOCS1003P01GridOutSangInfo> _grid_out_sang_item = new global::System.Collections.Generic.List<OcsoOCS1003P01GridOutSangInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grid_out_sang_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsoOCS1003P01GridOutSangInfo> grid_out_sang_item
    {
      get { return _grid_out_sang_item; }
    }
  
    private readonly global::System.Collections.Generic.List<ComboListItemInfo> _cbo_item = new global::System.Collections.Generic.List<ComboListItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"cbo_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ComboListItemInfo> cbo_item
    {
      get { return _cbo_item; }
    }
  
    private readonly global::System.Collections.Generic.List<OcsoOCS1003P01LayoutQueryInfo> _out_order = new global::System.Collections.Generic.List<OcsoOCS1003P01LayoutQueryInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"out_order", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsoOCS1003P01LayoutQueryInfo> out_order
    {
      get { return _out_order; }
    }
  
    private readonly global::System.Collections.Generic.List<OcsoOCS1003P01GridReserOrderListInfo> _reser_order = new global::System.Collections.Generic.List<OcsoOCS1003P01GridReserOrderListInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"reser_order", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OcsoOCS1003P01GridReserOrderListInfo> reser_order
    {
      get { return _reser_order; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}