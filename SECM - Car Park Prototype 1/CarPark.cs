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
        private Customer[] activeCustomers;
        private HashPair[] parkinglot;

        public CarPark(int levels, int floorSize)
        {
            maxCapacity = levels * floorSize;
            this.levels = levels;
            floorSpaces = floorSize;
            spacesOccupied = 0;
            parkinglot = new HashPair[floorSize];
            activeCustomers = new Customer[maxCapacity];
        }

        public void addActiveCustomer(Customer newCust)
        {
            activeCustomers[noOfCustomers] = newCust;
            noOfCustomers++;
        }

        public int getMaxCap()
        {
            return maxCapacity;
        }
        public int getLVCap()
        {
            return (maxCapacity / levels);
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

        public Customer getNewlyAddedCust()
        {
            return activeCustomers[noOfCustomers-1];
        }
    }
}
