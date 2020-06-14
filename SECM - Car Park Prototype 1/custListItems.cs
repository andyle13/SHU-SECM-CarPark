namespace SECM___Car_Park_Prototype_1
{
    class CustListItems
    {
        public int Level { get; set; }
        public int BayIndex { get; set; }
        public string Name { get; set; }
        public int BayNo { get; set; }
        public Customer custObj { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
