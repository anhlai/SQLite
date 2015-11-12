using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using XRT0201U00GrdJaeryoItemInfo = IHIS.CloudConnector.Contracts.Models.Xrts.XRT0201U00GrdJaeryoItemInfo;
using XRT0201U00GrdOrderItemInfo = IHIS.CloudConnector.Contracts.Models.Xrts.XRT0201U00GrdOrderItemInfo;
using XRT0201U00GrdPaListItemInfo = IHIS.CloudConnector.Contracts.Models.Xrts.XRT0201U00GrdPaListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00SaveLayoutArgs : IContractArgs
	{
		private List<XRT0201U00GrdOrderItemInfo> _grdOrderItemInfo = new List<XRT0201U00GrdOrderItemInfo>();
		private List<XRT0201U00GrdJaeryoItemInfo> _grdJaeryoItemInfo = new List<XRT0201U00GrdJaeryoItemInfo>();
		private XRT0201U00GrdPaListItemInfo _grdPaListCurrentRow;
		private XRT0201U00GrdOrderItemInfo _grdOrderCurrentRow;
		private String _useRadioYn;
		private Boolean _rbxJubsu;
		private Boolean _rbxAct;
		private Boolean _rbxActEnd;
		private Boolean _rbxActUpdJaeryoYn;
		private Boolean _rbxActEndUpdJaeryoYn;
		private String _userId;

		public List<XRT0201U00GrdOrderItemInfo> GrdOrderItemInfo
		{
			get { return this._grdOrderItemInfo; }
			set { this._grdOrderItemInfo = value; }
		}

		public List<XRT0201U00GrdJaeryoItemInfo> GrdJaeryoItemInfo
		{
			get { return this._grdJaeryoItemInfo; }
			set { this._grdJaeryoItemInfo = value; }
		}

		public XRT0201U00GrdPaListItemInfo GrdPaListCurrentRow
		{
			get { return this._grdPaListCurrentRow; }
			set { this._grdPaListCurrentRow = value; }
		}

		public XRT0201U00GrdOrderItemInfo GrdOrderCurrentRow
		{
			get { return this._grdOrderCurrentRow; }
			set { this._grdOrderCurrentRow = value; }
		}

		public String UseRadioYn
		{
			get { return this._useRadioYn; }
			set { this._useRadioYn = value; }
		}

		public Boolean RbxJubsu
		{
			get { return this._rbxJubsu; }
			set { this._rbxJubsu = value; }
		}

		public Boolean RbxAct
		{
			get { return this._rbxAct; }
			set { this._rbxAct = value; }
		}

		public Boolean RbxActEnd
		{
			get { return this._rbxActEnd; }
			set { this._rbxActEnd = value; }
		}

		public Boolean RbxActUpdJaeryoYn
		{
			get { return this._rbxActUpdJaeryoYn; }
			set { this._rbxActUpdJaeryoYn = value; }
		}

		public Boolean RbxActEndUpdJaeryoYn
		{
			get { return this._rbxActEndUpdJaeryoYn; }
			set { this._rbxActEndUpdJaeryoYn = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public XRT0201U00SaveLayoutArgs() { }

		public XRT0201U00SaveLayoutArgs(List<XRT0201U00GrdOrderItemInfo> grdOrderItemInfo, List<XRT0201U00GrdJaeryoItemInfo> grdJaeryoItemInfo, XRT0201U00GrdPaListItemInfo grdPaListCurrentRow, XRT0201U00GrdOrderItemInfo grdOrderCurrentRow, String useRadioYn, Boolean rbxJubsu, Boolean rbxAct, Boolean rbxActEnd, Boolean rbxActUpdJaeryoYn, Boolean rbxActEndUpdJaeryoYn, String userId)
		{
			this._grdOrderItemInfo = grdOrderItemInfo;
			this._grdJaeryoItemInfo = grdJaeryoItemInfo;
			this._grdPaListCurrentRow = grdPaListCurrentRow;
			this._grdOrderCurrentRow = grdOrderCurrentRow;
			this._useRadioYn = useRadioYn;
			this._rbxJubsu = rbxJubsu;
			this._rbxAct = rbxAct;
			this._rbxActEnd = rbxActEnd;
			this._rbxActUpdJaeryoYn = rbxActUpdJaeryoYn;
			this._rbxActEndUpdJaeryoYn = rbxActEndUpdJaeryoYn;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00SaveLayoutRequest();
		}
	}
}