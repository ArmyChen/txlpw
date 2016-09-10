<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding:10px; clear:both;">
        <div style="padding: 5px; font-size: 12px; color: #232323; border-bottom: 2px solid #0f89a7;clear: both;">
            <font face="宋体">
                系统管理员&nbsp;>&nbsp;管理员列表</font>
        </div>
        <div style="padding-top:10px; clear:both;">
            <asp:GridView ID="GridView1" CssClass="gridview" DataKeyNames="aid" runat="server" 
                AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="序列号">
                        <ItemTemplate>
                        <font face="宋体"><%#Container.DataItemIndex+1 %></font>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="账号">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("aname") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>    
                    <asp:TemplateField HeaderText="身份">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("anc") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>   
                    <asp:TemplateField HeaderText="查看权限">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("aselect") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>   
                    <asp:TemplateField HeaderText="写入权限">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("ainsert") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>   
                    <asp:TemplateField HeaderText="修改权限">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("aupdate") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>   
                    <asp:TemplateField HeaderText="删除权限">
                        <ItemTemplate>
                        <font face="宋体"><%#Eval("adelete") %></font>
                        </ItemTemplate>
                    </asp:TemplateField>   
                </Columns>
            </asp:GridView>
        </div>
        <div style="padding-top:10px; clear:both;">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="but1" OnClick="Button1_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="删除" CssClass="but1" OnClick="Button2_Click" />
        </div>
    </div>
    </form>
</body>
</html>
