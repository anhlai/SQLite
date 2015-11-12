using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NuroManagePatientInfo = IHIS.CloudConnector.Contracts.Models.Nuro.NuroManagePatientInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT0101U04SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<NuroManagePatientInfo> _listInfo = new List<NuroManagePatientInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<NuroManagePatientInfo> ListInfo
		{
			get { return this._listInfo; }
			set { this._listInfo = value; }
		}

		public OUT0101U04SaveLayoutArgs() { }

		public OUT0101U04SaveLayoutArgs(String userId, List<NuroManagePatientInfo> listInfo)
		{
			this._userId = userId;
			this._listInfo = listInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0101U04SaveLayoutRequest();
		}
	}
}