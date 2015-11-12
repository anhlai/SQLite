using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00InitializeArgs : IContractArgs
	{
		private String _specimenSer;
		private String _hangmogCode;
		private String _specimenCode;
		private String _emergency;
		private String _groupHangmog;
		private String _bunho;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String Emergency
		{
			get { return this._emergency; }
			set { this._emergency = value; }
		}

		public String GroupHangmog
		{
			get { return this._groupHangmog; }
			set { this._groupHangmog = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public CPL0000Q00InitializeArgs() { }

		public CPL0000Q00InitializeArgs(String specimenSer, String hangmogCode, String specimenCode, String emergency, String groupHangmog, String bunho)
		{
			this._specimenSer = specimenSer;
			this._hangmogCode = hangmogCode;
			this._specimenCode = specimenCode;
			this._emergency = emergency;
			this._groupHangmog = groupHangmog;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00InitializeRequest();
		}
	}
}