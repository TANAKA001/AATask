using ElevatorControllerCore.Interfaces;
using ElevatorControllerCore.Model;

namespace ElevatorControllerCore.Entityes
{
    public class Elevator_A : Elevator
    {
        public Elevator_A(IElevatorControl elevatorControl): base(elevatorControl)
        {

        }
    }
}
