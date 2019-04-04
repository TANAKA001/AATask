
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ElevatorControllerCore.Model
{
    public class Floor
    {
        [DisplayName("Floor")]
        public int Id { get; set; }
        
        //Status of the floor, maybe can be interditated...
        public bool Status { get; set; }

    }
}
