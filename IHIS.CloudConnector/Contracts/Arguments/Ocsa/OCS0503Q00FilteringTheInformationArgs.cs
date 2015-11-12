using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503Q00FilteringTheInformationArgs : IContractArgs
	{
		private String _grdConsultNaewonDate;
		private String _grdConsultBunho;
		private String _gridRequestNaewonDate;
		private String _gridRequestBunho;

		public String GrdConsultNaewonDate
		{
			get { return this._grdConsultNaewonDate; }
			set { this._grdConsultNaewonDate = value; }
		}

		public String GrdConsultBunho
		{
			get { return this._grdConsultBunho; }
			set { this._grdConsultBunho = value; }
		}

		public String GridRequestNaewonDate
		{
			get { return this._gridRequestNaewonDate; }
			set { this._gridRequestNaewonDate = value; }
		}

		public String GridRequestBunho
		{
			get { return this._gridRequestBunho; }
			set { this._gridRequestBunho = value; }
		}

		public OCS0503Q00FilteringTheInformationArgs() { }

		public OCS0503Q00FilteringTheInformationArgs(String grdConsultNaewonDate, String grdConsultBunho, String gridRequestNaewonDate, String gridRequestBunho)
		{
			this._grdConsultNaewonDate = grdConsultNaewonDate;
			this._grdConsultBunho = grdConsultBunho;
			this._gridRequestNaewonDate = gridRequestNaewonDate;
			this._gridRequestBunho = gridRequestBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503Q00FilteringTheInformationRequest();
		}
	}
}