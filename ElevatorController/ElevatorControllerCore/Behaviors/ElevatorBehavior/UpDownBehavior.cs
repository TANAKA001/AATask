
using ElevatorControllerCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Behaviors.ElevatorBehavior
{
    class UpDownBehavior : IElevatorControl
    {
        public string ElevatorControl()
        {
            return "The elevator is working in the normal behavior (up and down)";
            
        }
    }
}