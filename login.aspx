<%@ Page Title="" Language="C#" MasterPageFile="~/TravelMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TravelExpertsFinal.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

    <link href="css/registerStyle.css" rel="stylesheet" />
<script src="js/register.js"></script>
<section class="panel b-red" id="3">
  <article class="panel__wrapper">
    <div class="panel__content">
      <h1 class="panel__headline"><i class="fa fa-pencil-square"></i>&nbsp;Login</h1>
      <div class="panel__block"></div>
     
        <%-- start register form --%>
      <div class="form">
          <div id="login">   
          <h1>Welcome !</h1>
          
          <form id="loginForm" runat="server">
          
            <div class="field-wrap">
            <label id="emaillbl">
              Email Address<span class="req">*</span>
            </label>
            <%--<input type="email" required autocomplete="off"/>--%>
            <asp:TextBox ID="emailtxt" runat="server" type="email" required="required" autocomplete="off" onfocus="document.getElementById('emaillbl').innerHTML = '';"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <label id="passlbl">
              Password<span class="req">*</span>
            </label>
            <%--<input type="password"required autocomplete="off"/>--%>
              <asp:TextBox ID="passwordtxt" runat="server" type="password" required="required" autocomplete="off" onfocus="document.getElementById('passlbl').innerHTML = '';"></asp:TextBox>
          </div>
          <asp:Label ID="errorLabel" runat="server" ForeColor="Red" ></asp:Label>
          <p></p>

          <asp:Button ID="ButtonLogin" class="button button-block" runat="server" Text="Log In" OnClick="ButtonLogin_Click" />
          
              <br />
          </form>
              
        </div>
      
</div> <!-- /form -->

      </div>
  </article>
</section>

</asp:Content>
