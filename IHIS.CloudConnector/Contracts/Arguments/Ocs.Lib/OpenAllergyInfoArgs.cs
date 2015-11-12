using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OpenAllergyInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.OpenAllergyInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OpenAllergyInfoArgs : IContractArgs
	{
		private OpenAllergyInfo _info1;

		public OpenAllergyInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public OpenAllergyInfoArgs() { }

		public OpenAllergyInfoArgs(OpenAllergyInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new OpenAllergyInfoRequest();
		}
	}
}