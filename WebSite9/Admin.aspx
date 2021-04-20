<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:CheckBoxField DataField="localposter" HeaderText="localposter" SortExpression="localposter" />
                <asp:BoundField DataField="imageName" HeaderText="imageName" SortExpression="imageName" ShowHeader="False" Visible="False" />
                <asp:BoundField DataField="movieTitle" HeaderText="movieTitle" SortExpression="movieTitle" />
              
                
               <asp:TemplateField HeaderText="img">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Width="100" Height="100" ImageUrl='<%#"image/"+Eval("imageName") %>' />
                </ItemTemplate>
                </asp:TemplateField >
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [idTbl] WHERE [ID] = ?" InsertCommand="INSERT INTO [idTbl] ([ID], [localposter], [imageName], [movieTitle]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [idTbl]" UpdateCommand="UPDATE [idTbl] SET [localposter] = ?, [imageName] = ?, [movieTitle] = ? WHERE [ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="String" />
                <asp:Parameter Name="localposter" Type="Boolean" />
                <asp:Parameter Name="imageName" Type="String" />
                <asp:Parameter Name="movieTitle" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="localposter" Type="Boolean" />
                <asp:Parameter Name="imageName" Type="String" />
                <asp:Parameter Name="movieTitle" Type="String" />
                <asp:Parameter Name="ID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
