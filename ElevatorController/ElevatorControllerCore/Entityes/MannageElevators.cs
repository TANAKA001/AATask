using ElevatorControllerCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Entityes
{
    public class MannageElevators
    {
        Dictionary<int, string> OrderUp = new Dictionary<int, string>();
        Dictionary<int, string> OrderDown = new Dictionary<int, string>();

        public String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMdd$HHmmssffff");
        }

        //the idea is receive the floor and the type of btn throught maybe a web service.... 
        //I was creating a way when the aplication start to emulate the callings from the floors.. but I thought was too much for the task
        
        public void FakeFloorCall() {
            Random rndm = new Random();
            
            Floor floor = new Floor()
            {
                Id = rndm.Next(1,10), // ten floors
            };
            int btn = rndm.Next(0, 1);

            FloorCall(btn, floor);

            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                FakeFloorCall();
                //FakeElevatorCommand();
                timer.Dispose();
            },
                        null, 10000, System.Threading.Timeout.Infinite);
        }

        public void FakeElevatorCommand(int? id = null)
        {
            Random rndm = new Random();

            Floor floor = new Floor()
            {
                Id = rndm.Next(1, 10), // ten floors
            };

            int btn = rndm.Next(0, 1);

            Elevator elevator = new Elevator()
            {
                Id = (id == null) ? 1 : rndm.Next(1, 3),
                Floors = new List<Floor> { floor },
                Status = 1
            };

            ElevatorPanelCall(elevator, floor);
        }
        
        public void FloorCall(int buton, Floor floor)
        {
            Dictionary<int, string> order = new Dictionary<int, string>();
            // No more than 1 call for each floor for each direction
            if (buton == 0)
            {
                if (!OrderUp.ContainsKey(floor.Id))
                {
                    OrderUp.Add(floor.Id, GetTimestamp(DateTime.Now).ToString());
                }
            }
            else
            {
                if (!OrderDown.ContainsKey(floor.Id))
                {
                    OrderDown.Add(floor.Id, GetTimestamp(DateTime.Now).ToString());
                }
            }
        }

        public void ElevatorPanelCall(Elevator elevator, Floor floor)
        {
            // I started the same for the Elevator but not Finished.
            for (int i = 1; i <= 3; i++)
            {

            }
        }

        public void ArriveElevator()
        {
            /*once the elevator arrive the floor the idea is get the dictionary OrderUp or OrderDown 
             *depending the direction the elevator is going and remove the pair <floor, timestamp> to liberate the floor to
             *do another call
             */
        }
      
    }
}
