using System;
using static Lab2.Func;
namespace Lab2
{
    [Serializable]
    public struct OfficeAppliances
    {
        public OfficeAppliances(string name, string dateOfPurchase, double warrantyTerm) //конструктор
        {
            Name = name;
            DateOfPurchase = dateOfPurchase;
            WarrantyTerm = warrantyTerm;
        }
        
        private string Name {get; set;}
        private string DateOfPurchase {get; set;}
        private double WarrantyTerm {get; set;}
        
        //перевірка на дійсність гарантії
        public bool IsWarrantyExpired()
        {
            bool isExpired = false;
            DateTime date1 = DateTime.Parse(DateOfPurchase);
            DateTime date2 = date1.AddDays(WarrantyTerm);
            if (date2 < DateTime.Now) isExpired = true;
            return isExpired;
        }
        
        //конвертування інформації про техніку в рядок
        public string String() => $"{Name}{Tab(Name.Length)}purchased: {DateOfPurchase}\twarranty: {WarrantyTerm} days";
    }
}