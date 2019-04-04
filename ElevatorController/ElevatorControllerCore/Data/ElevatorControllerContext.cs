using ElevatorControllerCore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ElevatorControllerCore.Data
{
    public class ElevatorControllerContext : DbContext
    {
        public DbSet<Elevator> Elevators { get; set; }

    }
}
