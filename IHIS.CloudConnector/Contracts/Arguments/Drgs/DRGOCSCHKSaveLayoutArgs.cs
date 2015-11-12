using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DRGOCSCHKGrdOcsChkInfo = IHIS.CloudConnector.Contracts.Models.Drgs.DRGOCSCHKGrdOcsChkInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRGOCSCHKSaveLayoutArgs : IContractArgs
	{
		private List<DRGOCSCHKGrdOcsChkInfo> _inputList = new List<DRGOCSCHKGrdOcsChkInfo>();
		private String _userId;

		public List<DRGOCSCHKGrdOcsChkInfo> InputList
		{
			get { return this._inputList; }
			set { this._inputList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public DRGOCSCHKSaveLayoutArgs() { }

		public DRGOCSCHKSaveLayoutArgs(List<DRGOCSCHKGrdOcsChkInfo> inputList, String userId)
		{
			this._inputList = inputList;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRGOCSCHKSaveLayoutRequest();
		}
	}
}