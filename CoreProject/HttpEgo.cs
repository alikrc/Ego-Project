using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace CoreProject
{
    public class HttpEgo
    {
        //http://www.ego.gov.tr/mobil/otobusnerede.asp

        public EgoApiModelSingleItem Post(int hatNo, int durakNo)
        {
            var ajaxCID = "176.42.255.19";
            var ajaxAPP = "OtobusNerede";

            Random rnd = new Random();

            string url = "http://www.ego.gov.tr/mobil/mapToDo.asp" + "?AjaxSid=" + rnd.Next() + "&AjaxCid=" + ajaxCID + "&AjaxApp=" + ajaxAPP + "&AjaxLog=True";

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();

                data["fnc"] = "DuraktanGeçecekOtobüsler";
                data["prm"] = "";
                data["hat"] = hatNo.ToString();
                data["durak"] = durakNo.ToString();

                var response = wb.UploadValues(url, "POST", data);

                var responseString = Encoding.Default.GetString(response);

                var allResult = JsonConvert.DeserializeObject<EgoApiModel>(responseString);

                var result = allResult.Tbl.Where(w => w.kodu==hatNo.ToString()).FirstOrDefault();

                return result;
            }
        }
    }
}