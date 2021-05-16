using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace LogicLayer
{
    public class WorkshopIdGenerator
    {
        private List<Workshop> workshops;

        public WorkshopIdGenerator(List<Workshop> workshops)
        {
            this.workshops = workshops;
        }

        private List<string> GetIdList()
        {
            List<string> idList = new List<string>();
            foreach (Workshop w in workshops)
            {
                idList.Add(w.Id);
            }

            return idList;
        }

        private string GenerateRandomStringOfNums()
        {
            string symbols = "0123456789";
            char[] stringChars = new char[6];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = symbols[random.Next(symbols.Length)];
            }

            return new String(stringChars);
        }


        public string GenerateId()
        {
            string id = GenerateRandomStringOfNums();
            int count = id.TakeWhile(c => c == '0').Count();

            while (GetIdList().Contains(id) && count != 6)
            {
                id = GenerateRandomStringOfNums();
                count = id.TakeWhile(c => c == '0').Count();
            }

            return id;
        }
    }
}
