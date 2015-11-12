using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsaOCS0503U01GrdOCS0503ListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OcsaOCS0503U01GrdOCS0503ListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U01SaveLayoutArgs : IContractArgs
	{
		private List<OcsaOCS0503U01GrdOCS0503ListInfo> _saveList = new List<OcsaOCS0503U01GrdOCS0503ListInfo>();
		private String _userId;

		public List<OcsaOCS0503U01GrdOCS0503ListInfo> SaveList
		{
			get { return this._saveList; }
			set { this._saveList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0503U01SaveLayoutArgs() { }

		public OCS0503U01SaveLayoutArgs(List<OcsaOCS0503U01GrdOCS0503ListInfo> saveList, String userId)
		{
			this._saveList = saveList;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U01SaveLayoutRequest();
		}
	}
}