using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DelvifyMatchPattern_Console
{
    public class UserToken
    {
        #region Helpers
        public string GetUserMatchingToken(string parseToken, string userReponse)
        {
            string returnToken = string.Empty;
            List<string> lstMyWishList = new List<string>();
            try
            {
                //Read all MyWishList from the repository..
                lstMyWishList = ReadMyWhishList();

                //loop and math each valid pattern
                foreach (string validPattern in lstMyWishList)
                {
                    string beforePattern = validPattern.Before(parseToken);
                    string afterPattern = validPattern.After(parseToken);
                    returnToken = userReponse.Between(beforePattern, afterPattern);
                    if (!string.IsNullOrEmpty(returnToken))
                        return returnToken;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            return returnToken;
        }
        public List<string> ReadMyWhishList()
        {
            List<string> lstMyWishList = new List<string>();
            string wishListPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"WishList.txt");
            lstMyWishList = File.ReadAllLines(wishListPath).ToList();
            return lstMyWishList;
        }
        #endregion
    }
}
