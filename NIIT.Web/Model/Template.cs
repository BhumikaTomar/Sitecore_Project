using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace NIIT.Web.Model
{
    public class Template
    {
        #region PageTemplates

        public struct BasePage
        {
            public static ID ID = new ID("{A3B55D29-B3B1-4291-815E-759AC7F6764B}");

            public struct Fields
            {
                public static readonly ID MainHeading = new ID("{ADA4BDCD-3411-414B-8084-8853C4BA654F}");
                public static readonly ID MainImage = new ID("{EB2A017F-F8AF-4FF0-9BC6-ED5B56BEAE36}");
                public static readonly ID MainDescription = new ID("{F23EC604-4018-49DC-BDFA-38B69612E49A}");
            }
        }

        public struct HolidayList
        {
            public static ID ID = new ID("{F748EF2B-7593-4AEE-A475-16829A7EF2CA}");
        }

        public struct Holiday
        {
            public static ID ID = new ID("{FEAC5867-259B-4A95-A910-0C5455C6F0FD}");

            public struct Fields
            {
                public static readonly ID StartDate = new ID("{9BF93B56-74C9-482E-BB37-79380F7F32F3}");
                public static readonly ID PricePerPerson = new ID("{7ADDEBDF-9DD6-4905-B008-6305FD2A4AAB}");

            }
        }
            public struct Bike
            {
                public static ID ID = new ID("{59DFF24E-686A-44BA-A311-656BF4B60B93}");

                public struct Fields
                {
                    public static readonly ID Type = new ID("{C085C404-CDD5-443D-8FAC-BD49B85A1817}");
                    public static readonly ID Suitability = new ID("{2825996F-9C82-43F8-85D9-E3255665F3C9}");

                }

            }

            public struct Comment
            {
                public static ID ID = new ID("{035A0B37-6ACE-47AF-9511-4F24C8E4FA9F}");

                public struct Fields
                {
                    public static readonly ID Author = new ID("{0EEE05E6-C25E-41CA-8882-8034103B6A5D}");
                    public static readonly ID Comment = new ID("{F5CC7536-561A-471A-A6A5-2B2131CB4D34}");

                }

            }

        }
        #endregion
    
}