<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KonverteraTemperaturer.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Basic.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <div>
            <asp:Label ID="StartTempLabel" runat="server" Text="Starttemperatur" AssociatedControlID="StartTempTextBox"></asp:Label>
        </div>

        <div>
            <asp:TextBox ID="StartTempTextBox" runat="server" type="text"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fyll i Starttemperatur." Display="Dynamic" ControlToValidate="StartTempTextBox" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Värdet måste vara ett heltal" Type="Integer" ControlToValidate="StartTempTextBox" Operator="DataTypeCheck" Display="Dynamic"></asp:CompareValidator>
        </div>

        <div>
            <asp:Label ID="SlutTempLabel" runat="server" Text="Sluttemperatur" AssociatedControlID="SlutTempTextBox"></asp:Label>
        </div>

        <div>
            <asp:TextBox ID="SlutTempTextBox" runat="server" type="text"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fyll i sluttemperatur" ControlToValidate="SlutTempTextBox" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Fyll i en sluttemperatur som är större än starttemperaturen" Type="Integer" ControlToValidate="SlutTempTextBox" Operator="GreaterThan" Display="Dynamic" ControlToCompare="StartTempTextBox"></asp:CompareValidator>
        </div>

        <div>
            <asp:Label ID="TempStegLabel" runat="server" Text="Temperatursteg" AssociatedControlID="TempStegTextBox"></asp:Label>
        </div>

        <div>
            <asp:TextBox ID="TempStegTextBox" runat="server" type="text"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Fyll i ett temperatursteg" ControlToValidate="TempStegTextBox" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Värdet måste vara mellan 1 och 100." MaximumValue="100" MinimumValue="1" Type="Integer" ControlToValidate="TempStegTextBox"></asp:RangeValidator>
        </div>

        <asp:Label ID="ValLabel" runat="server" Text="Välj typ av konvertering"></asp:Label>
        <div>
            <asp:RadioButton ID="CelsiusRadioButton" runat="server" GroupName="KonverteringsVal" Text="Celsius till Fahrenheit." />
        </div>
        <div>
            <asp:RadioButton ID="FahrenheitRadioButton" runat="server" GroupName="KonverteringsVal" Text="Fahrenheit till Celsius."/>
        </div>

        <div>
            <asp:Button ID="SubmitButton" runat="server" Text="Konvertera" OnClick="SubmitButton_Click" />
        </div>

        <asp:ValidationSummary ID="Errors" runat="server" DisplayMode="BulletList" EnableClientScript="true" HeaderText="Fel har inträffat, åtgärda dessa och försök igen." />

        <div class="down">
            <asp:Table ID="TempTable" runat="server" Visible="false" BorderWidth="1px" BorderStyle="Solid"></asp:Table>
        </div>
    </div>
    </form>
</body>
</html>
