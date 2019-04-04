using ElevatorControllerCore.Interfaces;
using ElevatorControllerCore.Model;

namespace ElevatorControllerCore.Entityes
{
    public class Elevator_C : Elevator
    {
        public Elevator_C(IElevatorControl elevatorControl) : base(elevatorControl)
        {

        }
    }
}
