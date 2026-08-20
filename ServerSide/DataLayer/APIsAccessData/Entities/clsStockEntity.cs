
namespace APIsAccessData.Entities
{
    public class clsStockEntity
    {
        public short ID { get;private set; }

        public string Name { get;private set; }

        public int Amount { get; private set; }

        public double Price { get; private set; }

        public double Cost { get; private set; }

        public short AddedBy { get; private set; }

        internal clsEntityCall.enCallingFor CallFor { get; private set; }

       private clsStockEntity(short iD, string name, int amount, double price, double cost, short addedBy, clsEntityCall.enCallingFor callFor)
       {
            ID = iD;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
            CallFor = callFor;
       }


        internal void FoundStockEntityByID(string name,int amount, double price, double cost, short addedBy)
        {
            this.Name = name;
            this.Amount = amount;
            this .Price = price;
            this .Cost = cost;
            this .AddedBy = addedBy;
            this.CallFor = clsEntityCall.enCallingFor.Update;
        }

        internal void FoundStockEntityByName(short id, int amount, double price, double cost, short addedBy)
        {
            this.ID = id;
            this.Amount = amount;
            this.Price = price;
            this.Cost = cost;
            this.AddedBy = addedBy;
            this.CallFor = clsEntityCall.enCallingFor.Update;
        }

        internal void SetID(short id)
        {
            if (CallFor != clsEntityCall.enCallingFor.Add)
                return;

            this.ID = id;
        }

        public static clsStockEntity GetStockEntity(short ID)
        {
            return new clsStockEntity(ID, string.Empty, 0, 0d, 0d, -1, clsEntityCall.enCallingFor.Search);
        }

        public static clsStockEntity GetStockEntity(string Name)
        {
            return new clsStockEntity(-1, Name, 0, 0d, 0d, -1, clsEntityCall.enCallingFor.Search);
        }

        public static clsStockEntity UpdateStockEntityInstance(short id, string name,int amount, double price,double cost)
        {
            return new clsStockEntity(id,name,amount,price,cost,-1,clsEntityCall.enCallingFor.Update);
        }

        public static clsStockEntity AddStockEntityInstance(string name, int amount, double price, double cost,short addedBy)
        {
            return new clsStockEntity(-1, name, amount, price, cost, addedBy, clsEntityCall.enCallingFor.Add);
        }

        internal static clsStockEntity FoundStockEntityInstanceImmutable(short id, string name, int amount, double price, double cost, short addedBy)
        {
            return new clsStockEntity(id,name,amount,price,cost,addedBy, clsEntityCall.enCallingFor.Update);
        }

      
        internal static clsStockEntity InvalidStockEntityInstance()
        {
            return new clsStockEntity(-1,string.Empty,0,0d,0d,-1, clsEntityCall.enCallingFor.Invalid);
        }

       
    }

}
