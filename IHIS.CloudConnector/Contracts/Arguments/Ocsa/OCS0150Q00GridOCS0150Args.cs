using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0150Q00GridOCS0150Args : IContractArgs
	{
		private String _doctor;
		private String _gwa;
		private String _ioGubun;
		private String _orderDate;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public OCS0150Q00GridOCS0150Args() { }

		public OCS0150Q00GridOCS0150Args(String doctor, String gwa, String ioGubun, String orderDate)
		{
			this._doctor = doctor;
			this._gwa = gwa;
			this._ioGubun = ioGubun;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0150Q00GridOCS0150Request();
		}
	}
}