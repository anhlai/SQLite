using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsoOCS1003P01GridOutSangInfo = IHIS.CloudConnector.Contracts.Models.Ocso.OcsoOCS1003P01GridOutSangInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01GrdOutSangSaveLayoutArgs : IContractArgs
	{
		private List<OcsoOCS1003P01GridOutSangInfo> _grdOutSangList = new List<OcsoOCS1003P01GridOutSangInfo>();
		private String _userId;

		public List<OcsoOCS1003P01GridOutSangInfo> GrdOutSangList
		{
			get { return this._grdOutSangList; }
			set { this._grdOutSangList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OcsoOCS1003P01GrdOutSangSaveLayoutArgs() { }

		public OcsoOCS1003P01GrdOutSangSaveLayoutArgs(List<OcsoOCS1003P01GridOutSangInfo> grdOutSangList, String userId)
		{
			this._grdOutSangList = grdOutSangList;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01GrdOutSangSaveLayoutRequest();
		}
	}
}