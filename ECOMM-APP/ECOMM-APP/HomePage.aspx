<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ECOMM_APP.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        
        .auto-style2 {
            font-size: x-large;
            border-radius : 10px;
            border : none;
            cursor : pointer;
        }
        .auto-style3 {
            text-align: left;
            font-size: large;
        }
        .auto-style4 {
            width: 1167px;
            margin-left: 106px;
        }
        .auto-style5 {
            font-size: large;
            border-radius : 8px;
            border : none;
            cursor : pointer;
        }
        .auto-style6 {
            font-size: large;
            color: #3366FF;
        }
        .auto-style7 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            font-size: x-large;
            border-radius : 8px;
            cursor : pointer;
        }
    </style>
</head>
<body style="background-color : aliceblue">
    <form id="form1" runat="server">
        <div>
            <!--Header-->
            <div class="auto-style1">
                <asp:Image ID="Image1" runat="server" ImageUrl="https://static-assets-web.flixcart.com/batman-returns/batman-returns/p/images/fkheaderlogo_exploreplus-44005d.svg" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSearch" runat="server" PlaceHolder="Search for products,Brands and more" BackColor="Transparent" Height="31px" OnTextChanged="txtSearch_TextChanged" Width="489px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <strong>
                <asp:Label ID="lblUserName" runat="server" CssClass="auto-style5"></asp:Label>
                </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLogOut" runat="server" CssClass="auto-style7" OnClick="btnLogOut_Click" Text="Logout" BackColor="#3366FF" ForeColor="White" Height="58px" Width="112px" />
                <br />
                <br />
                <br />
                <br />
            </div>
            
            
            <!--IPhone 15-->
            <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                <div>
                    <asp:Image ID="iphone15" runat="server" ImageUrl="https://rukminim2.flixcart.com/image/312/312/xif0q/mobile/k/l/l/-original-imagtc5fz9spysyk.jpeg?q=70" />
                </div>
                <div>
                    <strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="Apple iPhone 15 (Black, 128 GB)" CssClass="auto-style2" />
  
                     </strong>
  
                     <ul>
                         <li class="auto-style3">128 GB ROM</li>
                         <li class="auto-style3">15.49 cm (6.1 inch) Super Retina XDR Display</li>
                         <li class="auto-style3">48MP + 12MP | 12MP Front Camera</li>
                         <li class="auto-style3">A16 Bionic Chip, 6 Core Processor Processor</li>
                         <li class="auto-style3">1 Year Warranty for Phone
                             and 6 Months Warranty for In-Box Accessories</li>
                     </ul>
                </div>
                <div>
                    <strong><span class="auto-style2">&#8377;65499</span></strong> <br />
                    <asp:Button ID="btnAdd1" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnAdd1_Click" />
                </div>
            </div>

            <br />

            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblIphone15" runat="server" CssClass="auto-style6" />
            </div>

            <br />

            <!--Samsung S24 Ultra -->
             <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                 <div>
                     <asp:Image ID="SamsungS24" runat="server" ImageUrl="https://rukminim2.flixcart.com/image/312/312/xif0q/mobile/5/i/7/-original-imahfu766ybd5h4z.jpeg?q=70" />
                 </div>
                 <div>
                     <strong>
                     <asp:HyperLink ID="HyperLink2" runat="server" Text="SAMSUNG Galaxy S24 Ultra 5G (Titanium Gray, 256 GB)" CssClass="auto-style2" />
  
                      </strong>
  
                      <ul>
                          <li class="auto-style3">12 GB RAM | 256 GB ROM</li>
                          <li class="auto-style3">17.27 cm (6.8 inch) Quad HD+ Display</li>
                          <li class="auto-style3">200MP + 50MP + 12MP + 10MP | 12MP Front Camera</li>
                          <li class="auto-style3">5000 mAh Battery</li>
                          <li class="auto-style3">Snapdragon 8 Gen 3 Processor</li>
                          <li class="auto-style3">1 Year Warranty for Phone
                              and 6 Months Warranty for In-Box Accessories</li>
                      </ul>
                 </div>
                 <div>
                     <strong><span class="auto-style2">&#8377;129999</span></strong> <br />
                     <asp:Button ID="btnSamsung" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnSamsung_Click" />
                 </div>
            </div>
            <br />
            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblSamsungS24" runat="server" CssClass="auto-style6" />
            </div>

            <br />

            <!--One Plus 12-->
             <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                 <div>
                     <asp:Image ID="OnePlus12" runat="server" ImageUrl="https://rukminim2.flixcart.com/image/312/312/xif0q/mobile/z/f/n/12-5g-op12-5g-oneplus-original-imagxgt7hfg9cq9u.jpeg?q=70" />
                 </div>
                 <div>
                     <strong>
                     <asp:HyperLink ID="HyperLink3" runat="server" Text="OnePlus 12 (Silky Black, 512 GB)" CssClass="auto-style2" />
  
                      </strong>
  
                      <ul>
                          <li class="auto-style3">16 GB RAM | 512 GB ROM</li>
                          <li class="auto-style3">17.32 cm (6.82 inch) Display</li>
                          <li class="auto-style3">64MP Rear Camera</li>
                          <li class="auto-style3">5400 mAh Battery</li>
                          <li class="auto-style3">Snapdragon 8 Gen 3 Processor</li>
                          <li class="auto-style3">1 Year Brand Warranty</li>
                      </ul>
                 </div>
                 <div>
                     <strong><span class="auto-style2">&#8377;60881</span></strong> <br />
                     <asp:Button ID="btnOnePlus12" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnOnePlus12_Click" />
                 </div>
            </div>
            <br />
            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblOnePlus12" runat="server" CssClass="auto-style6" />
            </div>

            <br />

            <!--IQOO Neo 9 Pro-->
             <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                 <div>
                     <asp:Image ID="IqooNeo9Pro" runat="server" ImageUrl="https://m.media-amazon.com/images/I/718jcIFYaAL._AC_UY327_FMwebp_QL65_.jpg" />
                 </div>
                 <div>
                     <strong>
                     <asp:HyperLink ID="HyperLink4" runat="server" Text="iQOO Neo9 Pro 5G (Fiery Red, 12GB RAM, 256GB Storage)" CssClass="auto-style2" />
  
                      </strong>
  
                      <ul>
                          <li class="auto-style3">8 GB RAM | 256 GB ROM</li>
                          <li class="auto-style3">17.22 cm (6.78 inch) Display</li>
                          <li class="auto-style3">50MP Rear Camera</li>
                          <li class="auto-style3">5160 mAh Battery</li>
                          <li class="auto-style3">Snapdragon 8 Gen 2 Processor</li>
                          <li class="auto-style3">1 Year Warranty for Phone</li>
                      </ul>
                 </div>
                 <div>
                     <strong><span class="auto-style2">&#8377;38999</span></strong> <br />
                     <asp:Button ID="btnIqooNeo9Pro" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnIqooNeo9Pro_Click" />
                 </div>
            </div>
            <br />
            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblIqoo" runat="server" CssClass="auto-style6" />
            </div>

            <br />

            <!--Google Pixel 9-->
             <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                 <div>
                     <asp:Image ID="GooglePixel9" runat="server" ImageUrl="https://rukminim2.flixcart.com/image/312/312/xif0q/mobile/d/y/m/pixel-9-ga05843-in-google-original-imah3pfgd9zadkyx.jpeg?q=70" />
                 </div>
                 <div>
                     <strong>
                     <asp:HyperLink ID="HyperLink5" runat="server" Text="Google Pixel 9 (Porcelain, 256 GB)" CssClass="auto-style2" />
  
                      </strong>
  
                      <ul>
                          <li class="auto-style3">12 GB RAM | 256 GB ROM</li>
                          <li class="auto-style3">16.0 cm (6.3 inch) Display</li>
                          <li class="auto-style3">50MP + 48MP | 10.5MP Front Camera</li>
                          <li class="auto-style3">4700 mAh Battery</li>
                          <li class="auto-style3">Google Tensor G4 Processor</li>
                          <li class="auto-style3">1 Year Domestic Warranty</li>
                      </ul>
                 </div>
                 <div>
                     <strong><span class="auto-style2">&#8377;79999</span></strong> <br />
                     <asp:Button ID="btnGooglePixel9" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnGooglePixel9_Click" />
                 </div>
            </div>
            <br />
            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblGooglePixel9" runat="server" CssClass="auto-style6" />
            </div>

            <br />
            <!--Samsung Z Fold 6-->
             <div style="display:flex;align-items: flex-start; gap:200px;" class="auto-style4">
                 <div>
                     <asp:Image ID="SamsungZFold6" runat="server" ImageUrl="https://rukminim2.flixcart.com/image/312/312/xif0q/mobile/v/b/j/-original-imah2nd53uhb7b6s.jpeg?q=70" />
                 </div>
                 <div>
                     <strong>
                     <asp:HyperLink ID="HyperLink6" runat="server" Text="SAMSUNG Galaxy Z Fold6 5G (Silver Shadow, 512 GB)" CssClass="auto-style2" />
  
                      </strong>
  
                      <ul>
                          <li class="auto-style3">12 GB RAM | 512 GB ROM</li>
                          <li class="auto-style3">19.3 cm (7.6 inch) QXGA+ Display</li>
                          <li class="auto-style3">50MP + 12MP + 10MP | 10MP Front Camera</li>
                          <li class="auto-style3">4400 mAh Lithium ion Battery</li>
                          <li class="auto-style3">Snapdragon 8 Gen 3 Processor</li>
                          <li class="auto-style3">1 Year Warranty for Phone
                              and 6 Months Warranty for In-Box Accessories</li>
                      </ul>
                 </div>
                 <div>
                     <strong><span class="auto-style2">&#8377;176999</span></strong> <br />
                     <asp:Button ID="btnSamsungZFold6" runat="server" Text="Add To Cart" CssClass="auto-style2" BackColor="Green" ForeColor="White" ToolTip="add to cart" Height="46px" Width="166px" OnClick="btnSamsungZFold6_Click" />
                 </div>
            </div>
            <br />
            <div style="background-color : white;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblSamsungZFold6" runat="server" CssClass="auto-style6" />
            </div>

        </div>
    </form>
</body>
</html>
