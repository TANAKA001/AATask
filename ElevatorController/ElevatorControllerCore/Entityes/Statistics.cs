using ElevatorControllerCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControllerCore.Entityes
{
    public class Statistics
    {
        public float AvarageOfUse(Elevator elevator, int days)
        {
            //Return the avarage of usage of a specific elevator in a period of days.
            return 0;
        }
        public Dictionary<Floor,float> AvarageWaitTime(int days)
        {
            //Return the avarage of waiting time spent between the call in the floor and the arrive of the elevator
            //Each Key value would be floor.ID -> the floor and float the avarage of wating time spend on that floor in a period of days
            return null;
        }
        public string HighTrafficTime()
        {
            //Return the Time of the day of High traffic and the direction (up or down)
            return "";
        }

    }
}
