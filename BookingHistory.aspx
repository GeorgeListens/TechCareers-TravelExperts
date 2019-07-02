<%@ Page Title="" Language="C#" MasterPageFile="~/TravelMaster.Master" AutoEventWireup="true" CodeBehind="BookingHistory.aspx.cs" Inherits="TravelExpertsFinal.BookingHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            margin-top: 22px;
            margin-right: 222px;
        }
         .auto-style3 {
             margin-right: 0px;
         }
         .auto-style5 {
             
             margin-left: 125px;
         }
         .auto-style6 {
             margin-right: 33px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content  ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <section class="panel b-blue" id="2">
    <article class="auto-style5" >
        <div class="panel__content">
            <h1 class="panel__headline"><i class="fa fa-calendar"></i>&nbsp;Booking History</h1>
           <%-- <div class="panel__block">--%>
          
            <form id="form2" runat="server" class="auto-style3">
                <br />
                <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" CssClass="auto-style6">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="BookingId" HeaderText="ID" SortExpression="BookingId" />
                        <asp:BoundField DataField="BookingDate" HeaderText="Date" SortExpression="BookingDate" />
                        <asp:BoundField DataField="BookingNo" HeaderText="Number" SortExpression="BookingNo" />
                        <asp:BoundField DataField="TravelerCount" HeaderText="Count" SortExpression="TravelerCount" />
                        <asp:BoundField DataField="CustomerId" HeaderText="Cust Id" SortExpression="CustomerId" />
                        <asp:BoundField DataField="PkgName" HeaderText="Name" SortExpression="PkgName" />
                        <asp:BoundField DataField="PkgStartDate" HeaderText="Start Date" SortExpression="PkgStartDate" />
                        <asp:BoundField DataField="PkgEndDate" HeaderText="End Date" SortExpression="PkgEndDate" />
                        <asp:BoundField DataField="PkgDesc" HeaderText="Description" SortExpression="PkgDesc" />
                        <asp:BoundField DataField="PkgBasePrice" HeaderText="Base Price" SortExpression="PkgBasePrice" DataFormatString="{0:c}" />
                        <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl='<%# Eval("PkgImg") %>' Width="150px" />
                </ItemTemplate>
            </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllByCustomer" TypeName="TravelExpertsFinal.DB.Bookings.BookingHistoryDB">
        <SelectParameters>
            <asp:SessionParameter  Name="custid" SessionField="CustomerId" Type="Int32" />
           <%-- DefaultValue="143"--%>
        </SelectParameters>
    </asp:ObjectDataSource>
            </form>
           <%-- </div>--%>
        </div>
    </article>
    </section>
  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>


         