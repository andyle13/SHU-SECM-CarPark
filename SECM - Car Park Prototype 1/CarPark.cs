using System.Collections.Generic;

namespace SECM___Car_Park_Prototype_1
{
    public class CarPark
    {
        private int maxCapacity, levels, floorSpaces, spacesOccupied, exitBarriers;
        private int noOfCustomers = 0;
        private int noOfVisitors = 0;
        private int noOfParkCust = 0;
        private int noOfExitCust = 0;
        private int unlockedLVs = 1;
        private bool isEmergencyAlert = false;
        private List<Customer> activeCustomers = new List<Customer>();
        private List<Customer> cpVisitors = new List<Customer>();
        private HashPair[] parkinglot;

        public CarPark(int levels, int floorSize, int exitBarriers)
        {
            maxCapacity = levels * floorSize;
            this.levels = levels;
            this.exitBarriers = exitBarriers;
            floorSpaces = maxCapacity;
            spacesOccupied = 0;
            parkinglot = new HashPair[floorSize];
        }

        public void AddActiveCustomer(Customer newCust)
        {
            activeCustomers.Add(newCust);
            noOfCustomers++;
        }

        public int GetMaxCap()
        {
            return maxCapacity;
        }

        public int GetLVCap()
        {
            return maxCapacity / levels;
        }

        public int GetCPCap()
        {
            return ((maxCapacity / levels) * unlockedLVs);
        }

        public int GetNoOfVisitors()
        {
           return noOfVisitors;
        }

        public int GetNoOfParkCust()
        {
            return noOfParkCust;
        }

        public int GetUnlockedLevels()
        {
            return unlockedLVs;
        }
        public List<Customer> GetCPVisitor()
        {
            return cpVisitors;
        }
        public int GetExitBarriers()
        {
            return exitBarriers;
        }
        public bool GetEmergency()
        {
            return isEmergencyAlert;
        }
        public void AddCPVisitors(Customer cpCust)
        {
            cpVisitors.Add(cpCust);
        }

        public void RemoveCPVisitor(Customer cpCust)
        {
            cpVisitors.Remove(cpCust);
        }

        public void RemoveActCustVisitor(Customer cpCust)
        {
            activeCustomers.Remove(cpCust);
        }

        public void SetNoOfCustomers(int updCust)
        {
            noOfCustomers += updCust;
        }

        public void SetNoOfParkCust(int updPkCus)
        {
            noOfParkCust += updPkCus;
        }

        public void SetOccupiedSpaces(int updSpaces)
        {
            spacesOccupied += updSpaces;
        }

        public void SetParkingLot()
        {
            HashPair[] tempData = parkinglot;
            parkinglot = new HashPair[tempData.Length + GetLVCap()];
            for (int i = 0; i < tempData.Length; i++)
            {
                parkinglot[i] = tempData[i];
            }
        }
        public void SetEmergency(bool isEmergencyAlert)
        {
            this.isEmergencyAlert = isEmergencyAlert;
        }
        public void SetNoOfVisitors(int updVis)
        {
            noOfVisitors += updVis;
        }

        public int GetNoOfExitCust()
        {
            return noOfExitCust;
        }

        public void SetNoOfExitCust(int updExt)
        {
            noOfExitCust += updExt;
        }

        public void SetCPCap(int unlockLV)
        {
            unlockedLVs += unlockLV;
        }

        public int GetAvailableSpaces()
        {
            return (floorSpaces - spacesOccupied);
        }
        public int GetLevels()
        {
            return levels;
        }

        public int GetNoOfActCusts()
        {
            return noOfCustomers;
        }

        public List<Customer> GetActiveCustList()
        {
            return activeCustomers;
        }

        public void SetActCustList(List<Customer> newList)
        {
            activeCustomers = newList;
        }

        public void SetCPVisitorList(List<Customer> newList)
        {
            cpVisitors = newList;
        }
    }
}
