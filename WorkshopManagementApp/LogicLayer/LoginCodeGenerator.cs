using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace LogicLayer
{
    public class LoginCodeGenerator
    {
        private List<WorkshopPerson> workshopPeople;

        public LoginCodeGenerator(List<WorkshopPerson> workshopPeople)
        {
            this.workshopPeople = workshopPeople;
        }

        private List<string> GetLoginCodeList(Workshop w)
        {
            List<string> loginCodes = new List<string>();
            foreach (WorkshopPerson wp in workshopPeople)
            {
                if (wp.Workshop.Id == w.Id)
                {
                    loginCodes.Add(((OnlineWorkshopPerson)(wp)).LoginCode);
                }
            }

            return loginCodes;
        }

        public string GenerateRandomString()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[6];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = symbols[random.Next(symbols.Length)];
            }

            return new String(stringChars);
        }

        public string GenerateCode(Workshop w)
        {
            string loginCode = GenerateRandomString();
            while (GetLoginCodeList(w).Contains(loginCode))
            {
                loginCode = GenerateRandomString();
            }

            return loginCode;
        }
    }
}
