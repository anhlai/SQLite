using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00ResultListQuerySelect2Args : IContractArgs
	{
		private String _specimenSer;
		private String _kyunCode;
		private String _serial;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String KyunCode
		{
			get { return this._kyunCode; }
			set { this._kyunCode = value; }
		}

		public String Serial
		{
			get { return this._serial; }
			set { this._serial = value; }
		}

		public CPL0000Q00ResultListQuerySelect2Args() { }

		public CPL0000Q00ResultListQuerySelect2Args(String specimenSer, String kyunCode, String serial)
		{
			this._specimenSer = specimenSer;
			this._kyunCode = kyunCode;
			this._serial = serial;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00ResultListQuerySelect2Request();
		}
	}
}