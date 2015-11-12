using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00GrdSCH0002ValidateGridColumnChangedArgs : IContractArgs
	{
		private String _hangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public SCH3001U00GrdSCH0002ValidateGridColumnChangedArgs() { }

		public SCH3001U00GrdSCH0002ValidateGridColumnChangedArgs(String hangmogCode)
		{
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00GrdSCH0002ValidateGridColumnChangedRequest();
		}
	}
}