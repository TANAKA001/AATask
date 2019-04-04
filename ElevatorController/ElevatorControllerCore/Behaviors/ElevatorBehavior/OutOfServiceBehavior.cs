
using ElevatorControllerCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Behaviors.ElevatorBehavior
{
    public class OutOfServiceBehavior : IElevatorControl
    {
        public string ElevatorControl()
        {
            return "The elevator is not operational.";
        }
    }
}
