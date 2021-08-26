using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface CRUD
    {
        void Create(Statue obj);
        ICollection<Statue> Read();
        void Update(decimal id, Statue statueChanged);
        void Delete(Statue obj);
        Statue FindStatue(decimal id);
        void Save();
    }
    public class StatueDepot : CRUD
    {
        StatueCollectionEntities entities;
        public StatueDepot()
        {
            entities = new StatueCollectionEntities();   //instance of database
        }
        public void Create(Statue obj)
        {
            entities.Statues.Add(obj);
            Save();
        }
        public ICollection<Statue> Read()
        {
            return entities.Statues.ToList();
        }
        public void Update(decimal id, Statue statueChanged)
        {
            var stat = entities.Statues.Find(id);
            stat.Statue_Number = statueChanged.Statue_Number;
            stat.Cape_Style = statueChanged.Cape_Style;
            stat.Character = statueChanged.Character;
            stat.Cost = statueChanged.Cost;
            stat.Depth = statueChanged.Depth;
            stat.Edition_Size = statueChanged.Edition_Size;
            stat.Exclusive = statueChanged.Exclusive;
            stat.Hair_Type = statueChanged.Hair_Type;
            stat.Height = statueChanged.Height;
            stat.Kit = statueChanged.Kit;
            stat.Manufacturer = statueChanged.Manufacturer;
            stat.Material = statueChanged.Material;
            stat.Non_Refundable_Deposit = statueChanged.Non_Refundable_Deposit;
            stat.Number_Of_Boxes = statueChanged.Number_Of_Boxes;
            stat.Order_Date = statueChanged.Order_Date;
            stat.Order_Number = statueChanged.Order_Number;
            stat.Owned = statueChanged.Owned;
            stat.Paid = statueChanged.Paid;
            stat.Payment_Cost = statueChanged.Payment_Cost;
            stat.Payment_Length = statueChanged.Payment_Length;
            stat.Quantity = statueChanged.Quantity;
            stat.Retailer = statueChanged.Retailer;
            stat.Scale = statueChanged.Scale;
            stat.Weight = statueChanged.Weight;
            stat.Width = statueChanged.Width;
            Save();
        }
        public void Delete(Statue obj)
        {
            entities.Statues.Remove(obj);
            Save();
        }
        public void Save()
        {
            entities.SaveChanges();
        }
        public Statue FindStatue(decimal id)
        {
            var statue = entities.Statues.Find(id);
            return statue;
        }
    }
}
