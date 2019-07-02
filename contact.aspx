<%@ Page Title="" Language="C#" MasterPageFile="~/TravelMaster.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="TravelExpertsFinal.contact" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<section class="panel b-green" id="4">
  <article class="panel__wrapper">
    <div class="panel__content">
      <h1 class="panel__headline"><i class="fa fa-phone"></i>&nbsp;Contact us</h1>
      <div class="panel__block"></div>
      <%-- start contact us --%>
        <div class="contact-text">
                <p>Travel Experts are always ready for any requests and help.</p>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3"><strong>Calgary Branch:</strong></td>
                        <td class="auto-style4"><strong>Okotoks Branch:</strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><i class="fa fa-location-arrow" aria-hidden="true"></i>&nbsp&nbsp 1155 8th Ave SW</td>
                        <td><i class="fa fa-location-arrow" aria-hidden="true"></i>&nbsp&nbsp 110 Main Street</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><i class="fa fa-map-marker" aria-hidden="true"></i>&nbsp&nbsp Calgary, AB T2P 1N3</td>
                        <td><i class="fa fa-map-marker" aria-hidden="true"></i>&nbsp&nbsp Okotoks, AB T7R 3J5</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><i class="fa fa-envelope-o" aria-hidden="true"></i>&nbsp&nbsp contactca@travelexperts.com</td>
                        <td><i class="fa fa-envelope-o" aria-hidden="true"></i>&nbsp&nbsp contactok@travelexperts.com</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><i class="fa fa-phone" aria-hidden="true"></i>&nbsp&nbsp+1 403 271 9873 </td>
                        <td><i class="fa fa-phone" aria-hidden="true"></i>&nbsp&nbsp+1 403 563 2381 </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><i class="fa fa-fax" aria-hidden="true"></i>&nbsp&nbsp+1 403 271 9872 </td>
                        <td><i class="fa fa-fax" aria-hidden="true"></i>&nbsp&nbsp+1 403 563 2382 </td>
                    </tr>
                </table>
                <br>
                <div class="contact-info d-lg-flex">
                </div>
            </div>
        <%-- end contact us --%>
    </div>
  </article>
</section>

</asp:Content>
