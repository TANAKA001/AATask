
using ElevatorControllerCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Behaviors.ElevatorBehavior
{
    class OnlyUpBehavior : IElevatorControl
    {
        public string ElevatorControl()
        {
            return "The elevator only goes up... at the last floor he goes directly to the loby.";
        }
    }
}