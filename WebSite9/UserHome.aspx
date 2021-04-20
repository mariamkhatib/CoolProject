<%@ Page Title="" Language="C#" MasterPageFile="~/User_Page.master" AutoEventWireup="true" CodeFile="UserHome.aspx.cs" Inherits="UserHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
        width: 5%;
        height: 932px;
    }
      .auto-style3 {
          width: 30%;
          height: 23px;
          text-align: center;
      }
      .auto-style4 {
          width: 30%;
          height: 23px;
          text-align: left;
      }
      .auto-style5 {
          width: 30%;
          height: 23px;
          text-align: right;
      }
     
         .cool{
             width: 25vw;
             margin:1vw;
             height:400px;
        }
        .wrapper {
     display: grid;
     grid:auto-flow dense;
  grid-template-columns: repeat(5,1fr);
  grid-gap: 1em;
  background-color: #fff;
  color: #444;
  text-align:center;
}   

  </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
		<!-- Default-JavaScript -->   <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>

		<!-- Resopnsive-Slider-JavaScript -->
			<script src="js/responsiveslides.min.js"></script>
			<script>
				$(function () {
					$("#slider").responsiveSlides({
						auto: true,
						nav: true,
						speed: 1000,
						namespace: "callbacks",
						pager: true
					});
				});
			</script>
		<!-- //Resopnsive-Slider-JavaScript -->

    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

</asp:Content>

