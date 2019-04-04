using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElevatorControllerCore.Interfaces;

namespace ElevatorControllerCore.Model
{
    public class Elevator
    {
        IElevatorControl ElevatorControl;

        public Elevator(IElevatorControl ielevatorControl)
        {
            this.ElevatorControl = ielevatorControl;
        }
        public Elevator(){}

        public int Id { get; set; }
        public List<Floor> Floors { get; set; }
        public byte Status { get; set; }
        public int Behavior { get; set; }
        public float AvgDistance { get; set; }
        public double AvgAwaitTime { get; set; }
        public string Control()
        {
            return this.ElevatorControl.ElevatorControl();
        }

        public void RemoveFloor() {

        }
    }
}
