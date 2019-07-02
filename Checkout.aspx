<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Test.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="css/Checkout.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 7px;
        }
    </style>
</head>
<body style="background-color:palevioletred;">
    <div class="container containerBackground">
    <form id="form1" runat="server">
        <div>
            Order Summary
        </div>
        <div class="form-group">
            <asp:ListBox ID="lstCart" class="form-control" runat="server" Enabled="False" Height="131px" Width="392px" CssClass="form-control"></asp:ListBox>
        </div>
        <div class="form-group">
            Subtotal:
            <asp:Label ID="lblSubtotal" class="form-control" runat="server"  Enabled="False" Text="Label" Width="103px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tax:
            <asp:Label ID="lblTax" class="form-control" runat="server" CssClass="auto-style1" Text="Label" Width="102px"></asp:Label>
        </div>
        <div class="form-group">
            Grand Total:
            <asp:Label ID="lblGrandTotal" class="form-control" runat="server"  Text="Label" Width="139px"></asp:Label>
        </div>
        <div>
            &nbsp;
        </div>
        <div class="form-group">
            Please enter your credit card (Visa or Mastercard) :&nbsp;
            <asp:TextBox ID="txtCreditCard" class="form-control" runat="server" Width="241px"></asp:TextBox>
        </div>
        <div class="form-group">
            Enter the expiration date (MM/YYYY):&nbsp;
            <asp:TextBox ID="txtExpDate" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button 
                ID="btnCancel" 
                class="btn btn-danger" 
                runat="server" Text="Back to Packages" OnClick="btnCancel_Click" />
            <asp:Button 
                ID="btnPurchase" 
                class="btn btn-primary" 
                runat="server" OnClick="btnPurchase_Click" Text="Purchase" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <p></p>
            <asp:Label ID="lblMessage" class="form-control" runat="server" BorderStyle="Inset" Width="466px"></asp:Label>
        </div>
        <div>
            &nbsp;
        </div>
        <div>
            &nbsp;
        </div>
        <div>
            &nbsp;
        </div>
            <p>
                <asp:Button ID="btnBack" class="btn btn-info" runat="server"  Text="Back" Width="114px" OnClick="btnBack_Click" />
            </p>
    </form>
        </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
