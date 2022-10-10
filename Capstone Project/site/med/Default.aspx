<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>Laptop Khareedo</title>
        <script src="http://code.jquery.com/jquery-3.5.1.js" integrity="sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc=" crossorigin="anonymous">
        </script>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta http-equiv="X-UA-Compatible" content="IE-edge">
        <link href="css/Custome.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
        <script type="text/javascript">
            $(document).ready(function myfunction() {
                $("#btnCart").click(function myfunction() {
                    window.location.href = "Cart.aspx";
                });
            });
        </script>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <div class="navbar navbar-default navbar-fixed-top" role="navigation">
                    <div class="container ">
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle " data-toggle="collapse" data-target=".navbar-collapse">
                                <span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span><span
                                    class="icon-bar"></span><span class="icon-bar"></span>
                            </button>
                            <a class="navbar-brand" href="Default.aspx"><span>
                                    <img src="icons/med_icon.png" alt="ABC Healthcare" height="30" /></span> ABC Healthcare
                            </a>
                        </div>
                        <div class="navbar-collapse collapse">
                            <ul class="nav navbar-nav navbar-right">
                                <li class="active"><a href="Default.aspx">Home</a> </li>
                                <li><a href="About.aspx">About</a> </li>
                                <!-- <li><a href="Products.aspx">Order</a> </li> -->
                                <li id="btnSignUP" runat="server"><a href="SignUp.aspx">Sign Up</a> </li>
                                <li id="btnSignIN" runat="server"><a href="SignIn.aspx">Sign In</a> </li>
                                <li>
                                    <asp:Button ID="btnlogout" CssClass="btn btn-default navbar-btn " runat="server" Text="Sign Out" OnClick="btnlogout_Click" />
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!---image slider---->
                <div class="container">
                    <h2>
                        Carousel Example</h2>
                    <div id="myCarousel" class="carousel slide" data-ride="carousel">
                        <!-- Indicators -->
                        <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1"></li>
                            <li data-target="#myCarousel" data-slide-to="2"></li>
                            <li data-target="#myCarousel" data-slide-to="3"></li>
                            <li data-target="#myCarousel" data-slide-to="4"></li>
                        </ol>
                        <!-- Wrapper for slides -->
                        <div class="carousel-inner">
                            <div class="item active">
                                <img src="ImgSlider/1.png" alt="Ad1" style="width: 100%;">

                            </div>
                            <div class="item">
                                <img src="ImgSlider/2.png" alt="Ad2" style="width: 100%;">

                            </div>
                            <div class="item">
                                <img src="ImgSlider/3.png" alt="Ad3" style="width: 100%;">

                            </div>
                            <div class="item">
                                <img src="ImgSlider/4.png" alt="Ad4" style="width: 100%;">
                            </div>

                            <div class="item">
                                <img src="ImgSlider/5.png" alt="Ad5" style="width: 100%;">

                            </div>
                        </div>
                        <!-- Left and right controls -->
                        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span
                                class="glyphicon glyphicon-chevron-left">
                            </span><span class="sr-only">Previous</span> </a><a class="right carousel-control" href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right">
                            </span><span class="sr-only">Next</span> </a>
                    </div>
                </div>
                <!---image slider End---->
            </div>
            <!-- -Middle COntents start---->
            <!-- <hr />
            <div class="container center ">
                <div class="row ">
                    <div class="col-lg-4">
                        <img class="img-circle " src="Images/lap_2.jpg" alt="thumb" width="140" height="140" />
                        <h2>
                            Microsoft Surface Laptop Studio</h2>
                        <p>
                            The most powerful Surface Laptop. Quad-core powered 11th Gen Intel Core H Series processors handle your most complex workloads</p>
                        <p>
                            <a class="btn btn-default " href="#" role="button">View More &raquo;</a>
                        </p>
                    </div>
                    <div class="col-lg-4">
                        <img class="img-circle " src="Images/lap_1.jpg" alt="thumb" width="140" height="140" />
                        <h2>
                            ASUS VivoBook Pro 14 OLED (2021)</h2>
                        <p>
                            It’s vivid. It’s vibrant. It’s Vivobook Pro 14 OLED, and it shows the true colours of your world. With its stunning 14-inch NanoEdge 2.8K OLED display and awe-inspiring Harman Kardon-certified audio, Vivobook Pro 14 OLED immerses you in whatever you’re
                            .........
                            <p>
                                <a class="btn btn-default " href="#" role="button">View More &raquo;</a>
                            </p>
                    </div>
                    <div class="col-lg-4">
                        <img class="img-circle " src="Images/lap_3.jpg" alt="thumb" width="140" height="140" />
                        <h2>
                            ASUS VivoBook Flip 14 (2021)</h2>
                        <p>
                            To ensure ultimate durability, the precision-engineered stepless 360° metal hinge of VivoBook Flip 14 passed a 20,000-cycle open-and-close test. You can rest assured that your VivoBook Flip 14 will be ready for any mode, anytime — for years to come!</p>
                        <p>
                            <a class="btn btn-default " href="#" role="button">View More &raquo;</a>
                        </p>
                    </div>
                </div>
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        DIWALI MEGA SALE</div>
                    <div class="panel-body">
                        <div class="row" style="padding-top: 50px">
                            <asp:Repeater ID="rptrProducts" runat="server">
                                <ItemTemplate>
                                    <div class="col-sm-3 col-md-3">
                                        <a href="ProductView.aspx?PID=<%# Eval(" PID ") %>" style="text-decoration:
                                            none;">
                                            <div class="thumbnail">
                                                <img src="Images/ProductImages/<%# Eval(" PID ")%>/<%# Eval("ImageName ")%><%# Eval(" Extention ") %>" alt="<%# Eval(" ImageName ") %>" />
                                                <div class="caption">
                                                    <div class="probrand">
                                                        <%# Eval ("BrandName") %>
                                                    </div>
                                                    <div class="proName">
                                                        <%# Eval ("PName") %>
                                                    </div>
                                                    <div class="proPrice">
                                                        <span class="proOgPrice">
                                                            <%# Eval ("PPrice","{0:0,00}") %>
                                                        </span>
                                                        <%# Eval ("PSelPrice","{0:c}") %>
                                                            <span class="proPriceDiscount">(<%#
                                                                    Eval("DiscAmount","{0:0,00}") %>
                                                                    off) </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div> -->
            <!---Middle COntents End-- -->
            <!---Footer COntents Start here---->
            <hr />
            <footer>
                <div class="container ">

                    <p class="pull-right "><a href="#">&nbsp; &nbsp; Back to top &nbsp; &nbsp;</a></p>
                    <p class="pull-right "><a href="AdminHome.aspx"> Admin Login </a></p>
                    <p>&copy;2022 AcnoAamir &middot; <a href="Default.aspx">Home</a>&middot;<a href="#">About</a>&middot;<a href="#">Contact</a>&middot;<a href="#">Products</a> </p>
                </div>

            </footer>
            <!---Footer COntents End---->
        </form>
    </body>

    </html>