<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="JavaScript.js"></script>
    <title>Burger Roy</title>
    <style>
        body {
            background-color: #aaa9a9;
        }
        
        h1 {
            color: white;
            font-family: 'Bauhaus 93';
            width: 1072px;
        }

        p{
            text-align:center;
        }

        .auto-style1 {
            height: 100px;
            width: 100px;
        }


        * {box-sizing:border-box}

        .slideshow-container {
            max-width: 1000px;
            position: relative;
            margin: auto;
        }

        .mySlides {
            display: none;
        }

        .prev, .next {
            cursor: pointer;
            position: absolute;
            top: 50%;
            width: auto;
            margin-top: -22px;
            padding: 16px;
            color: white;
            font-weight: bold;
            font-size: 18px;
            transition: 0.6s ease;
            border-radius: 0 3px 3px 0;
        }

        .next {
            right: 0;
            border-radius: 3px 0 0 3px;
        }

        .prev:hover, .next:hover {
            background-color: rgba(0,0,0,0.8);
        }

        .text {
            color: #f2f2f2;
            font-size: 15px;
            padding: 8px 12px;
            position: absolute;
            bottom: 8px;
            width: 100%;
            text-align: center;
        }

        .numbertext {
            color: #f2f2f2;
            font-size: 12px;
            padding: 8px 12px;
            position: absolute;
            top: 0;
        }

        .dot {
            cursor:pointer;
            height: 15px;
            width: 15px;
            margin: 0 2px;
            background-color: #bbb;
            border-radius: 50%;
            display: inline-block;
            transition: background-color 0.6s ease;
        }

        .active, .dot:hover {
            background-color: #717171;
        }


        .fade {
            -webkit-animation-name: fade;
            -webkit-animation-duration: 1.5s;
            animation-name: fade;
            animation-duration: 1.5s;
        }

        @-webkit-keyframes fade {
            from {opacity: .4} 
            to {opacity: 1}
        }

        @keyframes fade {
            from {opacity: .4} 
            to {opacity: 1}
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
        <h1><img alt="La imagen no se encontró" class="auto-style1" longdesc="Logo" src="burger.jpg" />Burger Roy</h1>
    </div>

    <div>


        <div class="slideshow-container">

        <div class="mySlides fade">
        <div class="numbertext">1 / 3</div>
        <img src="1.jpg" style="width:100%">
        <div class="text">Hamburguesa 1</div>
        </div>

        <div class="mySlides fade">
        <div class="numbertext">2 / 3</div>
        <img src="2.jpg" style="width:100%">
        <div class="text">Hamburguesa 2</div>
        </div>

        <div class="mySlides fade">
        <div class="numbertext">3 / 3</div>
        <img src="roy.JPG" style="width:100%">
        <div class="text">Nuestro local</div>
        </div>

        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
        </div>
        <br/>

        <div style="text-align:center">
        <span class="dot" onclick="currentSlide(1)"></span> 
        <span class="dot" onclick="currentSlide(2)"></span> 
        <span class="dot" onclick="currentSlide(3)"></span> 
        </div>
        <br/>


        <p>¿Qué debería de llevar una hamburguesa?</p>
        <div style="text-align: center"><iframe width="560" height="315" src="https://www.youtube.com/embed/iM_KMYulI_s" frameborder="0" allowfullscreen></iframe></div>
        <br/>
    <p><a href="Contacto.aspx">Contacto</a></p>
    </div>

    </form>
</body>
</html>
