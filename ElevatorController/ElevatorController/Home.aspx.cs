using ElevatorControllerCore.Entityes;
using ElevatorControllerCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElevatorController
{
    public partial class Home : System.Web.UI.Page
    {

        BuilderElevators BuilderElevators = new BuilderElevators();
        List<Elevator> Elevators = new List<Elevator>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MannageElevators me = new MannageElevators();
                RenderControlers();
                RenderElevatorSummary();
                me.FakeFloorCall();
            }

        }
        public void RenderElevatorSummary(int? ElevatorA = 4, int? ElevatorB = 4, int? ElevatorC = 4)
        {

            if (System.Web.HttpContext.Current.Session["newTable"] == null)
            {
                Elevators = BuilderElevators.ListElevators();
            }
            else
            {
                Elevators = System.Web.HttpContext.Current.Session["newTable"] as List<Elevator>;
            }

            MannageElevators me = new MannageElevators();

            TableRow row = null;
            TableCell cel1 = null;
            TableCell cel2 = null;
            TableCell cel3 = null;
            TableCell cel4 = null;
            TableCell cel5 = null;

            int count = 1;

            foreach (var item in Elevators)
            {
                //-------------------------
                row = new TableRow();
                cel1 = new TableCell();
                cel1.Text = "Elevetor number: " + count;
                cel1.ColumnSpan = 5;
                row.Cells.Add(cel1);
                tElevators.Rows.Add(row);
                //-------------------------
                row = new TableRow();
                cel1 = new TableCell();
                cel2 = new TableCell();
                cel3 = new TableCell();
                cel4 = new TableCell();
                cel5 = new TableCell();

                cel1.Text = (item.Status == 1 ? "Active" : "Inacative");
                cel2.Text = "FLOORS";
                cel3.Text = item.Control();

                row.Cells.Add(cel1);
                row.Cells.Add(cel2);
                row.Cells.Add(cel3);
                row.Cells.Add(cel4);
                row.Cells.Add(cel5);

                tElevators.Rows.Add(row);
                //-------------------------
                count++;
            }

        }
        public void RenderControlers()
        {
            RenderControlElevatorA();
            RenderControlElevatorB();
            RenderControlElevatorC();
        }
        public void RenderControlElevatorA()
        {
            TableRow row = null;
            TableCell cel1 = null;
            TableCell cel2 = null;
            RadioButton raid = null;

            for (int i = 0; i < BuilderElevators.Behaviors().Count(); i++)
            {
                row = new TableRow();
                cel1 = new TableCell();
                cel2 = new TableCell();
                raid = new RadioButton();

                raid.ID = (i + 1).ToString();
                raid.GroupName = "elevatorA";
                raid.AutoPostBack = false;
                //TODO: case an elevator has a behavior set on the database, load as default here if not, load behavior 1 as default;
                raid.Checked = true;

                cel1.Controls.Add(raid);
                cel2.Text = BuilderElevators.Behaviors()[i + 1].GetType().Name.Replace("Behavior", "").Trim();

                row.Controls.Add(cel1);
                row.Controls.Add(cel2);

                elevatorABehaviorControl.Controls.Add(row);
            };
        }
        public void RenderControlElevatorB()
        {
            TableRow row = null;
            TableCell cel1 = null;
            TableCell cel2 = null;
            RadioButton raid = null;

            for (int i = 0; i < BuilderElevators.Behaviors().Count(); i++)
            {
                row = new TableRow();
                cel1 = new TableCell();
                cel2 = new TableCell();
                raid = new RadioButton();

                raid.ID = (i + 1).ToString();
                raid.GroupName = "elevatorB";
                raid.AutoPostBack = false;
                //TODO: case an elevator has a behavior set on the database, load as default here if not, load behavior 1 as default;
                raid.Checked = true;

                cel1.Controls.Add(raid);
                cel2.Text = BuilderElevators.Behaviors()[i + 1].GetType().Name.Replace("Behavior", "").Trim();

                row.Controls.Add(cel1);
                row.Controls.Add(cel2);

                elevatorBBehaviorControl.Controls.Add(row);
            };
        }
        public void RenderControlElevatorC()
        {
            TableRow row = null;
            TableCell cel1 = null;
            TableCell cel2 = null;
            RadioButton raid = null;

            for (int i = 0; i < BuilderElevators.Behaviors().Count(); i++)
            {
                row = new TableRow();
                cel1 = new TableCell();
                cel2 = new TableCell();
                raid = new RadioButton();

                raid.ID = (i + 1).ToString();
                raid.GroupName = "elevatorC";
                raid.AutoPostBack = false;
                //TODO: case an elevator has a behavior set on the database, load as default here if not, load behavior 1 as default;
                raid.Checked = true;

                cel1.Controls.Add(raid);
                cel2.Text = BuilderElevators.Behaviors()[i + 1].GetType().Name.Replace("Behavior", "").Trim();

                row.Controls.Add(cel1);
                row.Controls.Add(cel2);

                elevatorCBehaviorControl.Controls.Add(row);
            };
        }

        [WebMethod]
        public static void UpDateSummary(string ElevatorA, string ElevatorB, string ElevatorC)
        {
            BuilderElevators builderElevators = new BuilderElevators();
            System.Web.HttpContext.Current.Session["newTable"] = builderElevators.ListElevators(Convert.ToInt32(ElevatorA), Convert.ToInt32(ElevatorB), Convert.ToInt32(ElevatorC));

        }

        protected void UpdatePanel1_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                RenderElevatorSummary();
            }
        }
    }
}

