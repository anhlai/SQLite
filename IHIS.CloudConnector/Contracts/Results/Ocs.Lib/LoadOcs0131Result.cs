using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadOcs0131Result : AbstractContractResult
	{
		private List<LoadOcs0131Info> _ocs0131Info = new List<LoadOcs0131Info>();

		public List<LoadOcs0131Info> Ocs0131Info
		{
			get { return this._ocs0131Info; }
			set { this._ocs0131Info = value; }
		}

		public LoadOcs0131Result() { }

	}
}