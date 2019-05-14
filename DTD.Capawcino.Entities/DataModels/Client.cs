using System;
using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    public class Client
    {
        [Browsable(false)] [BsonId(IdGenerator = typeof(GuidGenerator))] public Guid ClientId { get; set; }
        public string Name { get; set; }
        [Browsable(false)]public string ImagePath { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        [DisplayName("Deposit Amount")] public float DepositAmount { get; set; }

        public float Credit { get; set; }
        [DisplayName("Flat Discount")] public bool FlatDiscount { get; set; }
        [DisplayName("Flat Amount")]public int FlatAmount { get; set; }
        [DisplayName("Percent Amount")] public int PercentAmount { get; set; }
    


        [DisplayName("Member Since")] public DateTime MemberSince { get; set; }
        [DisplayName("Last Active")] public DateTime LastActiveDate { get; set; }
 



        [DisplayName("Auto Renew Credit")] public bool AutoRenewCredit { get; set; }
        [DisplayName("Auto Renew Date")] public DateTime AutoRenewDate { get; set; }
        [DisplayName("Credit Carry Over")] public bool CreditCarryOver { get; set; }


        [DisplayName("Auto Renew Credit Amount")] public float AutoRenewCreditAmount { get; set; }

    }
}
