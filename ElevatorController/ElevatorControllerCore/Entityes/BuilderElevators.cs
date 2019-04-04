using ElevatorControllerCore.Behaviors.ElevatorBehavior;
using ElevatorControllerCore.Data;
using ElevatorControllerCore.Interfaces;
using ElevatorControllerCore.Model;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace ElevatorControllerCore.Entityes
{
    public class BuilderElevators
    {
        /*
            * This class is responsible to "build" the the n elevators the system could operate.
            * The classes instatiated in the method Behaviors() are the possible behaviors for each elevator.
            * In the case to add/exclude a behavior this can be done here...
            * 
           */

        public List<Elevator> ListElevators(int? behavior_el1 = 4, int? behavior_el2 = 4, int? behavior_el3 = 4)
        {
            //create the array of elevators of the building, saving each one of them in a list of elevators... case N other elevators would be created, it can be done here.
            Dictionary<int?, IElevatorControl> behaviors = Behaviors();

            List<Elevator> elevators = new List<Elevator>();

            Elevator elevator_1 = new Elevator(ielevatorControl: behaviors[behavior_el1]){ Id = 1, Status = 0, Floors = { }};
            Elevator elevator_2 = new Elevator(ielevatorControl: behaviors[behavior_el2]){ Id = 1, Status = 0, Floors = { }};
            Elevator elevator_3 = new Elevator(ielevatorControl: behaviors[behavior_el3]){ Id = 1, Status = 0, Floors = { }};

            elevators.Add(elevator_1);
            elevators.Add(elevator_2);
            elevators.Add(elevator_3);

            return elevators;
        }

        public Dictionary<int?, IElevatorControl> Behaviors()
        {
            //In case another behavior would be created for the elevators, must be added here...
            Dictionary<int?, IElevatorControl> behaviors = new Dictionary<int?, IElevatorControl>() {
                    {1, new UpDownBehavior() },
                    {2, new OnlyUpBehavior() },
                    {3, new OnlyDownBehavior() },
                    {4, new OutOfServiceBehavior() }
                };

            return behaviors;
        }
    }
}
