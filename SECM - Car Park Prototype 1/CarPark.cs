using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    public class CarPark
    {
        private int maxCapacity, levels, floorSpaces, spacesOccupied;
        private int noOfCustomers = 0;
        private int noOfVisitors = 0;
        private int unlockedLVs = 1;
        private List<Customer> activeCustomers = new List<Customer>();
        private HashPair[] parkinglot;

        public CarPark(int levels, int floorSize)
        {
            maxCapacity = levels * floorSize;
            this.levels = levels;
            floorSpaces = maxCapacity;
            spacesOccupied = 0;
            parkinglot = new HashPair[floorSize];
        }

        public void addActiveCustomer(Customer newCust)
        {
            activeCustomers.Add(newCust);
            noOfCustomers++;
        }

        public int getMaxCap()
        {
            return maxCapacity;
        }

        public int getLVCap()
        {
            return maxCapacity / levels;
        }

        public int getCPCap()
        {
            return ((maxCapacity / levels) * unlockedLVs);
        }

        public int getNoOfVisitors()
        {
           return noOfVisitors;
        }

        public int getUnlockedLevels()
        {
            return unlockedLVs;
        }

        public void setNoOfCustomers(int updCust)
        {
            noOfCustomers += updCust;
        }

        public void setOccupiedSpaces(int updSpaces)
        {
            spacesOccupied += updSpaces;
        }

        public void setActCustList(List<Customer> newList)
        {
            activeCustomers = newList;
        }

        public void setParkingLot()
        {
            HashPair[] tempData = parkinglot;
            parkinglot = new HashPair[tempData.Length + getLVCap()];
            for (int i = 0; i < tempData.Length; i++)
            {
                parkinglot[i] = tempData[i];
            }
        }

        public void setNoOfVisitors(int addedCustomer)
        {
            noOfVisitors += addedCustomer;
        }

        public void setCPCap(int unlockLV)
        {
            unlockedLVs += unlockLV;
        }

        public int getAvailableSpaces()
        {
            return (floorSpaces - spacesOccupied);
        }
        public int getLevels()
        {
            return levels;
        }

        public int getNoOfActCusts()
        {
            return noOfCustomers;
        }

        public List<Customer> getActiveCustList()
        {
            return activeCustomers;
        }
    }
}
