using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.TopluMail.Core.Helper
{
    public class GlobalIslemler
    {
        public void TryCatchKullan(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                // NLog;
                string ExStr = Newtonsoft.Json.JsonConvert.SerializeObject(ex);

                var logger = NLog.LogManager.GetCurrentClassLogger();
                logger.Log(LogLevel.Error, ExStr);
            }
        }
    }
}
