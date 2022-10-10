<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

        <title>About us Page</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
        <style>
            .jumbotron {
                background-color: #3870c9;
                color: #fff;
                padding: 100px 25px;
            }
            
            .container-fluid {
                padding: 60px 50px;
            }
            
            .bg-grey {
                background-color: #f6f6f6;
            }
            
            .logo-small {
                color: #3870c9;
                font-size: 50px;
            }
            
            .logo {
                color: #3870c9;
                font-size: 200px;
            }
            
            @media screen and (max-width: 768px) {
                .col-sm-4 {
                    text-align: center;
                    margin: 25px 0;
                }
            }
        </style>

    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <br />

        <div class="jumbotron text-center">
            <h1>ABC Healthcare</h1>
            <p></p>
            <form class="form-inline">
                <div class="input-group">

                </div>
            </form>
        </div>

        <!-- Container (About Section) -->
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-8">
                    <h2>About Company Page</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                    <asp:Button class="btn btn-default btn-lg" ID="Button1" runat="server" Text="Get in Touch" onclick="Button1_Click" />

                </div>
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-signal logo"></span>
                </div>
            </div>
        </div>

        <div class="container-fluid bg-grey">
            <div class="row">
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-globe logo"></span>
                </div>
                <div class="col-sm-8">
                    <h2>Our Values</h2>
                    <h4><strong>MISSION:</strong> Our mission lorem ipsum..</h4>
                    <p><strong>VISION:</strong> Our vision Lorem ipsum..</p>
                </div>
            </div>
        </div>

        <!-- Container (Services Section) -->
        <div class="container-fluid text-center">
            <h2>SERVICES</h2>
            <h4>What we offer</h4>
            <br>
            <div class="row">
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-off logo-small"></span>
                    <h4>POWER</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-heart logo-small"></span>
                    <h4>LOVE</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-lock logo-small"></span>
                    <h4>JOB DONE</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
            </div>
            <br><br>
            <div class="row">
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-leaf logo-small"></span>
                    <h4>GREEN</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-certificate logo-small"></span>
                    <h4>CERTIFIED</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
                <div class="col-sm-4">
                    <span class="glyphicon glyphicon-wrench logo-small"></span>
                    <h4 style="color:#303030;">HARD WORK</h4>
                    <p>Lorem ipsum dolor sit amet..</p>
                </div>
            </div>
        </div>
        <footer class="container-fluid text-center">
            <a href="#myPage" title="To Top">
                <span class="glyphicon glyphicon-chevron-up"></span>
            </a>
        </footer>

    </asp:Content>