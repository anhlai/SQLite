using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL3020U00GrdNoteUpdateInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3020U00GrdNoteUpdateInfo;
using CPL3020U00GrdPaListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3020U00GrdPaListItemInfo;
using CPL3020U00GrdResultListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3020U00GrdResultListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U02SaveArgs : IContractArgs
	{
		private List<CPL3020U00GrdResultListItemInfo> _grdResultItemInfo = new List<CPL3020U00GrdResultListItemInfo>();
		private List<CPL3020U00GrdNoteUpdateInfo> _grdNoteUpdateItemInfo = new List<CPL3020U00GrdNoteUpdateInfo>();
		private List<CPL3020U00GrdPaListItemInfo> _grdPaItemInfo = new List<CPL3020U00GrdPaListItemInfo>();
		private String _userId;
		private String _gumsaja;

		public List<CPL3020U00GrdResultListItemInfo> GrdResultItemInfo
		{
			get { return this._grdResultItemInfo; }
			set { this._grdResultItemInfo = value; }
		}

		public List<CPL3020U00GrdNoteUpdateInfo> GrdNoteUpdateItemInfo
		{
			get { return this._grdNoteUpdateItemInfo; }
			set { this._grdNoteUpdateItemInfo = value; }
		}

		public List<CPL3020U00GrdPaListItemInfo> GrdPaItemInfo
		{
			get { return this._grdPaItemInfo; }
			set { this._grdPaItemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String Gumsaja
		{
			get { return this._gumsaja; }
			set { this._gumsaja = value; }
		}

		public CPL3020U02SaveArgs() { }

		public CPL3020U02SaveArgs(List<CPL3020U00GrdResultListItemInfo> grdResultItemInfo, List<CPL3020U00GrdNoteUpdateInfo> grdNoteUpdateItemInfo, List<CPL3020U00GrdPaListItemInfo> grdPaItemInfo, String userId, String gumsaja)
		{
			this._grdResultItemInfo = grdResultItemInfo;
			this._grdNoteUpdateItemInfo = grdNoteUpdateItemInfo;
			this._grdPaItemInfo = grdPaItemInfo;
			this._userId = userId;
			this._gumsaja = gumsaja;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U02SaveRequest();
		}
	}
}