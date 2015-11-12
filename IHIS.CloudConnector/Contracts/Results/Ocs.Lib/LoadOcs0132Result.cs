using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadOcs0132Result : AbstractContractResult
	{
		private List<LoadOcs0132Info> _loadOcs0132Info = new List<LoadOcs0132Info>();

		public List<LoadOcs0132Info> LoadOcs0132Info
		{
			get { return this._loadOcs0132Info; }
			set { this._loadOcs0132Info = value; }
		}

		public LoadOcs0132Result() { }

	}
}