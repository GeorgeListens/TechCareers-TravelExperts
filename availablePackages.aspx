<%@ Page Title="" Language="C#" MasterPageFile="~/TravelMaster.Master" AutoEventWireup="true" CodeBehind="availablePackages.aspx.cs" Inherits="TravelExpertsFinal.availablePackages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<link href="css/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            margin-right: 222px;
            margin-left: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <section class="panel b-green" id="2">
  <article class="panel__wrapper">
        <div class="panel__content" style="position: relative;left: 70px;">
      <h1 class="panel__headline">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="fa fa-paper-plane"></i> Available Packages</h1>
      <div class="panel__block"></div>
          &nbsp
    <form id="form1" runat="server" class="auto-style3">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="PkgDataSource" CellPadding="4" CssClass="auto-style2" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ForeColor="#333333" Width="1001px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" SelectText="Add" />
                <asp:BoundField DataField="PackageId" HeaderText="Package Id" SortExpression="PackageId" />
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="Package Start Date" SortExpression="PkgStartDate" DataFormatString="{0:D}" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="Package End Date" SortExpression="PkgEndDate" DataFormatString="{0:D}" />
                <asp:BoundField DataField="PkgDesc" HeaderText="Package Description" SortExpression="PkgDesc" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="Package Base Price" SortExpression="PkgBasePrice" DataFormatString="{0:C}" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:ObjectDataSource ID="PkgDataSource" runat="server" SelectMethod="GetAll" TypeName="mySQL.Packages.PackagesDB"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

        <br />
        <a href="Cart.aspx"><i class="fa fa-shopping-cart cartIcon" style="width: 78px; left: 250px;position: absolute;" ></i></a>

</form>
      </div>
  </article>
</section>

</asp:Content>

