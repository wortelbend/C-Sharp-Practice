using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9
{
    internal class ch9_4
    {
        public class PhoneList
        {
            public string HomePhone { get; set; }
            public string BusinessPhone { get; set; }
            public string CellPhone { get; set; }
        }

        public class Cards
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public int Age { get; set; }
            public PhoneList Phone { get; set; }
            public string Email { get; set; }

            public string GetCard()
            {
                return $"姓名: {Name}\n職業: {Occupation}\n年齡: {Age}\n" +
                       $"住家電話: {Phone.HomePhone}\n公司電話: {Phone.BusinessPhone}\n手機: {Phone.CellPhone}\n" +
                       $"Email: {Email}";
            }
        }

    }
}
