<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ElevatorController.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <title>Elevator Controll</title>
</head>
<body>

    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="pb-2 mt-4 mb-2 border-bottom">
                <h3>Control Panel for the elevators</h3>
            </div>
            <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel OnLoad="UpdatePanel1_Load" runat="server" ID="UpdatePanel1" UpdateMode="Conditional" ClientIDMode="Static">
                <ContentTemplate>
                    <div class="col-md-12">
                        <label><b>Status of each elevator</b></label>
                        <asp:Table ID="tElevators" runat="server" CssClass=" table table-bordered">
                            <asp:TableHeaderRow ID="Table1HeaderRow" runat="server" CssClass="thead-dark">
                                <asp:TableHeaderCell
                                    Scope="Column"
                                    Text="Status" />
                                <asp:TableHeaderCell
                                    Scope="Column"
                                    Text="Floors solicited" />
                                <asp:TableHeaderCell
                                    Scope="Column"
                                    Text="Operational Behavior" />
                                <asp:TableHeaderCell
                                    Scope="Column"
                                    Text="Avarege daily wait-time" />
                                <asp:TableHeaderCell
                                    Scope="Column"
                                    Text="Avarege daily distance" />
                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <div class="row">
                <div class="col-md-2">
                    <div>
                        <label><b>Control of the elevator A</b></label>
                    </div>
                    <div>
                        <asp:Table runat="server" ID="elevatorABehaviorControl" CssClass="Col-md-8"
                            HorizontalAlign="Left">
                        </asp:Table>
                    </div>
                </div>
                <div class="col-md-2">
                    <div>
                        <label><b>Control of the elevator B</b></label>
                    </div>
                    <div>
                        <asp:Table runat="server" ID="elevatorBBehaviorControl" CssClass="Col-md-8"
                            HorizontalAlign="Left">
                        </asp:Table>
                    </div>
                </div>
                <div class="col-md-2">
                    <div>
                        <label><b>Control of the elevator C</b></label>
                    </div>
                    <div>
                        <asp:Table runat="server" ID="elevatorCBehaviorControl" CssClass="Col-md-8"
                            HorizontalAlign="Left">
                        </asp:Table>
                    </div>
                </div>
                <div class="col-md-6">
                </div>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">

    $(document).ready(function () {
        $('input[type=radio][name=elevatorA],input[type=radio][name=elevatorB],input[type=radio][name=elevatorC]').change(function (e) {
            $.ajax({
                type: "POST",
                url: "Home.aspx/UpDateSummary",
                contentType: "application/json; charset=utf-8",
                data: '{"ElevatorA":"' + $("input[name=elevatorA]:checked").val() + '","ElevatorB":"' + $("input[name=elevatorB]:checked").val() + '","ElevatorC":"' + $("input[name=elevatorC]:checked").val() + '"}',
                dataType: "json",
                success: function (msg) {

                    var UpdatePanel1 = '<%=UpdatePanel1.ClientID%>';
                    if (UpdatePanel1 != null) {
                        __doPostBack(UpdatePanel1, '');
                    }
                },
                error: function (req, status, error) {
                    alert("Error try again");
                }
            });
            return false;
        });
    });
</script>
</html>
