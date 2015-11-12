using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00grdBAS0210Args : IContractArgs
	{
		private String _gubunCode;
		private String _startDate;

		public String GubunCode
		{
			get { return this._gubunCode; }
			set { this._gubunCode = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public BAS0210U00grdBAS0210Args() { }

		public BAS0210U00grdBAS0210Args(String gubunCode, String startDate)
		{
			this._gubunCode = gubunCode;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00grdBAS0210Request();
		}
	}
}