using ElevatorControllerCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Data
{
    public class MockElevator
    {
        enum en_elevators {Elevator_A = 1,Elevator_B = 2, Elevator_C = 3 }
        public void CreateElevators() {
            
            using (var db = new ElevatorControllerContext())
            {
                //3 elevators...
                for (int i = 1; i <= 3; i++)
                {
                    Elevator elevator = new Elevator();

                    elevator.Behavior = i;
                    elevator.AvgDistance = 0;
                    elevator.AvgAwaitTime = 0;
                    elevator.Status = 1;

                    db.Elevators.Add(elevator);
                    db.SaveChanges();
                }
            }
        }
    }
}
