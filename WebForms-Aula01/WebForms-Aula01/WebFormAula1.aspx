﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAula1.aspx.cs" Inherits="WebForms_Aula01.WebFormAula1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A layout example with a side menu that hides on mobile, just like the Pure website.">
    <title>Responsive Side Menu &ndash; Layout Examples &ndash; Pure</title>
    <link rel="stylesheet" href="https://unpkg.com/purecss@1.0.1/build/pure-min.css" integrity="sha384-" crossorigin="anonymous">
    <!--[if lte IE 8]>
            <link rel="stylesheet" href="css/layouts/side-menu-old-ie.css">
        <![endif]-->
    <!--[if gt IE 8]><!-->
    <link rel="stylesheet" href="css/layouts/side-menu.css">
    <!--<![endif]-->
</head>
<body>
    <div id="layout">
        <!-- Menu toggle -->
        <a href="#menu" id="menuLink" class="menu-link">
            <!-- Hamburger icon -->
            <span></span>
        </a>

        <div id="menu">
            <div class="pure-menu">
                <a class="pure-menu-heading" href="#">Company</a>

                <ul class="pure-menu-list">
                    <li class="pure-menu-item"><a href="#" class="pure-menu-link">Home</a></li>
                    <li class="pure-menu-item"><a href="#" class="pure-menu-link">About</a></li>

                    <li class="pure-menu-item menu-item-divided pure-menu-selected">
                        <a href="#" class="pure-menu-link">Services</a>
                    </li>

                    <li class="pure-menu-item"><a href="#" class="pure-menu-link">Contact</a></li>
                </ul>
            </div>
        </div>

        <div id="main">
            <div class="header">
                <h1>Esse cara aqui</h1>
                <h2>A subtitle for your page goes here</h2>
            </div>

            <div class="content">
                <form id="form1" runat="server">
                    <h2 class="content-subhead">How to use this layout</h2>
                    <p>
                        To use this layout, you can just copy paste the HTML, along with the CSS in <a href="/css/layouts/side-menu.css" alt="Side Menu CSS">side-menu.css</a>, and the JavaScript in <a href="/js/ui.js">ui.js</a>. The JS file uses vanilla JavaScript to simply toggle an <code>active</code> class that makes the menu responsive.
                    </p>

                    <h2 class="content-subhead">Now Let's Speak Some Latin</h2>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                    </p>

                    

                    <h2 class="content-subhead">Try Resizing your Browser</h2>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                    </p>
                </form>
            </div>
        </div>
    </div>

    <script src="js/ui.js"></script>
</body>
</html>
