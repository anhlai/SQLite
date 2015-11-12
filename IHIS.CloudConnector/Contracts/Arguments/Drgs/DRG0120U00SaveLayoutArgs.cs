using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DRG0120U00GrdDrg0120ItemInfo = IHIS.CloudConnector.Contracts.Models.Drgs.DRG0120U00GrdDrg0120ItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0120U00SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<DRG0120U00GrdDrg0120ItemInfo> _inputList = new List<DRG0120U00GrdDrg0120ItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<DRG0120U00GrdDrg0120ItemInfo> InputList
		{
			get { return this._inputList; }
			set { this._inputList = value; }
		}

		public DRG0120U00SaveLayoutArgs() { }

		public DRG0120U00SaveLayoutArgs(String userId, List<DRG0120U00GrdDrg0120ItemInfo> inputList)
		{
			this._userId = userId;
			this._inputList = inputList;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0120U00SaveLayoutRequest();
		}
	}
}