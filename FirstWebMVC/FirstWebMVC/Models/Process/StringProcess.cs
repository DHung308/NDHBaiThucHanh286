using System.Text.RegularExpressions;

namespace FirstWebMVC.Models.Process
{
    public class StringProcess
    {
        public String AutoGenerateCode(string strInput, List<string> list)
        {
            string strResult = "", numPart = "", strPart = "";
            //tach phan so tu strInput
            numPart = Regex.Match(strInput, @"\d+").Value;
            //tach phan tu chu
            strPart = Regex.Match(strInput, @"\D+").Value;
            //tang phan so len 1 don vi
            int intPart = (Convert.ToInt32(strPart) + 1);
            //bo sung cac ky tu 0 con thieu
            for (int i = 0; i < numPart.Length - intPart.ToString().Length; i++)
            {
                strPart += "0";
            }
            strResult = strPart + intPart;
            return strResult;
        }
    }
}