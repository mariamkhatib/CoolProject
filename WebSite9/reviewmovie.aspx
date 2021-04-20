<%@ Page Async="true" Language="C#"  MasterPageFile="~/MasterPage_Review.master" AutoEventWireup="true" CodeFile="reviewmovie.aspx.cs" Inherits="reviewmovie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="title" runat="server"></asp:Label>
    
    <br />
    <asp:Image ID="Image1" runat="server" /><br />

    <asp:Label ID="story" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click here to watch the trailer" ForeColor="#FF0066" />
    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
       <iframe runat="server" id="ytplayer" type="text/html" width="500" height="360" frameborder="0"></iframe>
    <br />

</asp:Content>

