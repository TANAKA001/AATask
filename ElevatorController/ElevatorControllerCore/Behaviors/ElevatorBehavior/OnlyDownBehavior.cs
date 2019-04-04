
using ElevatorControllerCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Behaviors.ElevatorBehavior
{
    class OnlyDownBehavior : IElevatorControl
    {
        public string ElevatorControl()
        {
            return "The elevator only goes down... at the first floor he goes directly to the last floor.";
        }
    }
}
