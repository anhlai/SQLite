using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00GetSigeyulDataSelect2Args : IContractArgs
	{
		private String _bunho;
		private String _hangmogCode;
		private String _jubsuDate;
		private String _jubsuTime;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String JubsuTime
		{
			get { return this._jubsuTime; }
			set { this._jubsuTime = value; }
		}

		public CPL0000Q00GetSigeyulDataSelect2Args() { }

		public CPL0000Q00GetSigeyulDataSelect2Args(String bunho, String hangmogCode, String jubsuDate, String jubsuTime)
		{
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
			this._jubsuDate = jubsuDate;
			this._jubsuTime = jubsuTime;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00GetSigeyulDataSelect2Request();
		}
	}
}