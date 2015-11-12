using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBGetBogyongResult : AbstractContractResult
	{
		private List<OBGetBogyongInfo> _bogyongInfoItem = new List<OBGetBogyongInfo>();

		public List<OBGetBogyongInfo> BogyongInfoItem
		{
			get { return this._bogyongInfoItem; }
			set { this._bogyongInfoItem = value; }
		}

		public OBGetBogyongResult() { }

	}
}