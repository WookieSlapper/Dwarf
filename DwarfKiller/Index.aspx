<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DwarfKiller.Index" %>
<script runat=server>
protected void DoStuff()
{
    var rnd = new Random();

    Cage1.Attributes["src"] = "http://placecage.com/c/" +
    (rnd.Next(1, 10) * 100).ToString() +
    "/" +
    (rnd.Next(1, 10) * 100).ToString();
}
</script>
<script src="Scripts/CageChange.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dwarf Killer</title>
</head>
<body>
    <form id="form1" runat="server">

    <asp:Button ID="btnCageChange" runat="server" Text="MORPH" OnClick="OnCageChangeClick"/>

    <br />

    <asp:Image ID="Cage1" runat="server" src="http://placecage.com/c/600/300" onclick="fixCage()"/>

    </form>

    
    <% DoStuff(); %>
</body>
</html>
