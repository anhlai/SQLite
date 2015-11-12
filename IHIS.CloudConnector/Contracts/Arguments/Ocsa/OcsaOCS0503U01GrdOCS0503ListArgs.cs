using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0503U01GrdOCS0503ListArgs : IContractArgs
	{
		private String _reqDate;
		private String _fBunho;
		private String _consultDoctor;

		public String ReqDate
		{
			get { return this._reqDate; }
			set { this._reqDate = value; }
		}

		public String FBunho
		{
			get { return this._fBunho; }
			set { this._fBunho = value; }
		}

		public String ConsultDoctor
		{
			get { return this._consultDoctor; }
			set { this._consultDoctor = value; }
		}

		public OcsaOCS0503U01GrdOCS0503ListArgs() { }

		public OcsaOCS0503U01GrdOCS0503ListArgs(String reqDate, String fBunho, String consultDoctor)
		{
			this._reqDate = reqDate;
			this._fBunho = fBunho;
			this._consultDoctor = consultDoctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0503U01GrdOCS0503ListRequest();
		}
	}
}