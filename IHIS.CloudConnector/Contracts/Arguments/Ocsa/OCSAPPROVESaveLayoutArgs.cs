using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCSAPPROVEGrdOrderInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCSAPPROVEGrdOrderInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCSAPPROVESaveLayoutArgs : IContractArgs
	{
		private List<OCSAPPROVEGrdOrderInfo> _grdList = new List<OCSAPPROVEGrdOrderInfo>();
		private String _userId;
		private String _selectedIogubun;

		public List<OCSAPPROVEGrdOrderInfo> GrdList
		{
			get { return this._grdList; }
			set { this._grdList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String SelectedIogubun
		{
			get { return this._selectedIogubun; }
			set { this._selectedIogubun = value; }
		}

		public OCSAPPROVESaveLayoutArgs() { }

		public OCSAPPROVESaveLayoutArgs(List<OCSAPPROVEGrdOrderInfo> grdList, String userId, String selectedIogubun)
		{
			this._grdList = grdList;
			this._userId = userId;
			this._selectedIogubun = selectedIogubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCSAPPROVESaveLayoutRequest();
		}
	}
}