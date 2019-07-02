<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Test.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="css/Checkout.css" rel="stylesheet" />
    <title></title>
</head>
<body style="background-color: royalblue;">
    <div class="container containerBackground">
        <form id="form1" runat="server">
            <div class="form-group">
                <asp:ListBox ID="lstCart" class="form-control" runat="server" Height="95px" Width="305px"></asp:ListBox>
                <p></p>
                <asp:Button ID="btnRemove" class="btn btn-warning" runat="server" OnClick="btnRemove_Click" Text="Remove Package" Width="160px" />
                &nbsp;
                <asp:Button ID="btnEmpty" class="btn btn-danger" runat="server" OnClick="btnEmpty_Click" Text="Empty Cart" Width="114px" />
                <br />
            </div>
            <p>
                <asp:Button ID="btnContinue" class="btn btn-success" runat="server" OnClick="btnContinue_Click" Text="Continue Shopping" Width="160px"/>
                &nbsp;
                <asp:Button ID="btnCheckout" class="btn btn-primary" runat="server" OnClick="btnCheckout_Click" Text="Checkout" Width="114px" />
            &nbsp;</p>
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </form>
    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
