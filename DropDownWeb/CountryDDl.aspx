<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryDDl.aspx.cs" Inherits="DropDownWeb.CountryDDl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Country,States and City Dropdown list</div>
        <p>
            Select Country:<asp:DropDownList ID="ConDDl" runat="server" AppendDataBoundItems="True" AutoPostBack="True" BackColor="#FF9900" Height="20px" OnSelectedIndexChanged="ConDDl_SelectedIndexChanged" Width="150px">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Select State:<asp:DropDownList ID="StateDDl" runat="server" AppendDataBoundItems="True" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="StateDDl_SelectedIndexChanged" Width="150px">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Select City:<asp:DropDownList ID="CityDDl" runat="server" AppendDataBoundItems="True" AutoPostBack="True" BackColor="#66FF33" Height="20px" Width="150px">
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
