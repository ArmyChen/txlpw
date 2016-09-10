<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kdq.aspx.cs" Inherits="kdq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding:10px; clear: both; font-size:12px;">
        以下为快到期的信息，请联系开通
    </div>
        <div>
            <asp:GridView ID="GridView1" CssClass="gridview" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="mname" HeaderText="商品名称" />
                    <asp:BoundField DataField="mdiqu" HeaderText="地区" />
                    <asp:BoundField DataField="mlxr" HeaderText="联系人" />
                    <asp:BoundField DataField="mlxdh" HeaderText="联系电话" />
                    <asp:BoundField DataField="myxq" HeaderText="到期时间" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
