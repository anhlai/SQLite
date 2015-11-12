using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using IHIS.CloudConnector.Contracts.Arguments.Clis;
using IHIS.CloudConnector.Contracts.Arguments.Nuro;
using IHIS.CloudConnector.Contracts.Arguments.Outs;
using IHIS.CloudConnector.Contracts.Arguments.System;
using IHIS.CloudConnector.Contracts.Models.System;
using IHIS.CloudConnector.Contracts.Results.Clis;
using IHIS.CloudConnector.Contracts.Results.Nuro;
using IHIS.CloudConnector.Contracts.Results.Outs;
using IHIS.CloudConnector.Contracts.Results.System;
using IHIS.CloudConnector.Converters;
using IHIS.CloudConnector.Messaging;
using Otis;
using ProtoBuf;
using ComboListItemInfo = IHIS.CloudConnector.Contracts.Models.System.ComboListItemInfo;
using FormGwaItemInfo = IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo;
using MdiFormMenuItemInfo = IHIS.CloudConnector.Contracts.Models.System.MdiFormMenuItemInfo;
using MenuItemInfo = IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo;
using MenuViewFormItemInfo = IHIS.CloudConnector.Contracts.Models.System.MenuViewFormItemInfo;
using NuroPatientInfo = IHIS.CloudConnector.Contracts.Models.Nuro.NuroSearchPatientInfo;
using NuroPatientListItemInfo = IHIS.CloudConnector.Contracts.Models.Nuro.NuroPatientListItemInfo;
using UserRequestInfo = IHIS.CloudConnector.Contracts.Models.System.UserRequestInfo;
using IHIS.CloudConnector.Contracts.Arguments.OcsEmr;
using IHIS.CloudConnector.Contracts.Results.OcsEmr;
using IHIS.CloudConnector.Contracts.Results;

namespace IHIS.CloudConnector
{
    using System.Windows.Forms;
    using IHIS.CloudConnector.Contracts.Arguments.Bass;
    using IHIS.CloudConnector.Contracts.Results.Bass;
    using IHIS.CloudConnector.DataAccess;
    using IHIS.CloudConnector.DataAccess.Entities;

    public class Program
    {
        private static readonly Configuration m_cfg = new Configuration();

        public static void Main(string[] args)
        {
//            MappingTest();
//            ConnectionTest();
//            MainMenuConnectionTest();
//            PatientListTest();
//            ReceptionTypeListTest();
//            NuroComboTimeTest();
//            ComingStatusTest();
//            DepartmentListTest();
//            InfoTextListTest();
//            DoctorNameTest();
//            ExistingKeyStatusTest();

//            ForeignKeyTest();
//            ComingStatusUpdateTest("Y", "329352");
//            PatientInfoUpdateTest("updID", "comingStatus", "arrivveTime", "recpType", "pkout1001");
//            OUT0101U02ComboListTest();

//            TestCloud();

            /*GenerateOtisMapping();*/
            //Console.ReadKey();

            //if (CloudService.Instance.Connect())
            //{
            //    Test001();
            //    //Test002();
            //}
            ICustomerDao customerDao = DataAccess.DataAccess.CustomerDao;
            Console.WriteLine(customerDao.TableExists("Customer"));
            Customer customer = customerDao.FindById(1);
            Console.WriteLine(customer.Name);
            Console.ReadKey();
        }




        //private static void Test001()
        //{
        //    CLIS2015U04GetProtocolItemArgs args = new CLIS2015U04GetProtocolItemArgs();
        //    CLIS2015U04GetProtocolItemResult result = CloudService.Instance.Submit<CLIS2015U04GetProtocolItemResult, CLIS2015U04GetProtocolItemArgs>(args);
        //}

        //private static void Test002()
        //{
        //    List<CloudConnector.Contracts.Models.Bass.BAS0212U00GrdItemInfo> inputList = new List<CloudConnector.Contracts.Models.Bass.BAS0212U00GrdItemInfo>();
        //    BAS0212U00TransactionalArgs args = new BAS0212U00TransactionalArgs(inputList, "1");
        //    UpdateResult result = CloudService.Instance.Submit<UpdateResult, BAS0212U00TransactionalArgs>(args);
        //}

        private static void GenerateOtisMapping()
        {
            Configuration _cfg = new Configuration();

            _cfg.GenerationOptions.Namespace = "IHIS.CloudConnector";
            _cfg.GenerationOptions.OutputFile = Application.StartupPath + "..\\..\\..\\Mappings\\Assembler.cs";
            _cfg.GenerationOptions.OutputType = OutputType.SourceCode;
            _cfg.GenerationOptions.MOneFilePerClass = true;
            _cfg.AddAssemblyResources(Assembly.GetExecutingAssembly(), "otis.xml");

            _cfg.BuildAssemblers();
        }
    }
}