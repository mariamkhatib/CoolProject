<%@ Page Title="" Language="C#" MasterPageFile="~/Guest_Page.master" AutoEventWireup="true" CodeFile="Guest_Alert.aspx.cs" Inherits="Guest_Alert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 200px;
            height: 50px;
            font-size: xx-large;
            color:#e4032f;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
              <strong>
                    <asp:Label ID="Label1" runat="server" Text="you must be a user in order to see the movie`s review " CssClass="auto-style11"></asp:Label>
              </strong>               
</asp:Content>

