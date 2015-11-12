using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using IHIS.CloudConnector.Contracts.Results.Nuro;
using IHIS.CloudConnector.Messaging;

namespace IHIS.CloudConnector.Converters
{
    public class OtisConverter
    {
        public static void ConvertList<TResult, TResponse>(ref TResult result, ref TResponse response)
        {
            PropertyInfo[] resultPropertyInfos = result.GetType().GetProperties();
            PropertyInfo[] responsePropertyInfos = response.GetType().GetProperties();
            // The properties order of Result and Response should be similar
            if (resultPropertyInfos.Length != 0 && resultPropertyInfos.Length == responsePropertyInfos.Length)
            {
                for (int i = 0; i < resultPropertyInfos.Length; i ++)
                {
                    resultPropertyInfos[i].SetValue(result, responsePropertyInfos[i].GetValue(response, null), null);    
                } 
            }
        }
    }
}
