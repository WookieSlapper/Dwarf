<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fight.aspx.cs" Inherits="DwarfKiller.Fight" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dwarf FIGHT</title>
    <link href="Styles/Combat.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div id="hero" class="combatant">
            <h2>Hero</h2>
            <div>
                <label>Name</label><label id="heroName" runat="server"></label>
            </div>
            <div>
                <label>Combat Level</label><label id="heroCombatLevel" runat="server"></label>
            </div>
            <div>
                <label>Hit Points</label><label id="heroHitPoints" runat="server"></label>
            </div>
            <div>
                <label>Attack Points</label><label id="heroAttackPoints" runat="server"></label>
            </div>
            <div>
                <label>Defense Points</label><label id="heroDefensePoints" runat="server"></label>
            </div>
            <div>
                <label>Kill Count</label><label id="heroKillCount" runat="server"></label>
            </div>
            <div>
                <label>Attack Value</label><label id="heroAttackRoll" runat="server"></label>
            </div>
        </div>

        <asp:Button ID="btnAttack" runat="server" Text="Attack" OnClick="Attack" />
        <asp:Button ID="btnNewEnemy" runat="server" Text="Find a Fight" OnClick="NewEnemy" Visible="False"/>

        <div id="enemy" class="combatant">
            <h2>Dwarf scourge</h2>
            <div>
                <label>Name</label><label id="enemyName" runat="server"></label>
            </div>
            <div>
                <label>Hit Points</label><label id="enemyHitPoints" runat="server"></label>
            </div>
            <div>
                <label>Attack Points</label><label id="enemyAttackPoints" runat="server"></label>
            </div>
            <div>
                <label>Defense Points</label><label id="enemyDefensePoints" runat="server"></label>
            </div>
            <div>
                <label>Enemy Status</label><label id="enemyStatus" runat="server"></label>
            </div>
            <div>
                <label>Defense Value</label><label id="enemyDefenseRoll" runat="server">defense</label>               
            </div>
        </div>

    </form>
</body>
</html>
