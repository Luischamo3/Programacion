<html>
<head>
    <title> curso.php proceso de cursos</title>
    <META http-equiv="content-type" content="text/html; charset=ISO-8859-1">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>
<body>


<div>
    <nav class="navbar navbar-fixed-top navbar-inverse">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div id="navbar" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li ><a href="curso.php">Cursos</a></li>
                    <li><a href="Alumno.php">Alumnos</a>Alumnos</li>
                    <li class="active"><a href="nota.php">Notas</a>Notas</li>
                </ul>
            </div>
        </div>
    </nav>
</div>
<br><br><br><br><br><br>

<div style="width: 80%; margin: 0 auto; ">
    <form action="" method="post" class="form-horizontal">

                       <!--Combobox-->
<div class="form-group-sm">
        <label for="cc">Elegir Curso</label>
        <select class="combobox" onchange="this.form.submit()" name="filtro_codcur" id="cc">

            <option value="">SEleccione Curso</option>

            <option value="@VAR.COD_CUR" name="box">@VAR.DESCRIPCION</option>

            <script type="text/javascript">
                $(document).ready(function () {
                    $('.combobox').combobox();
                });
            </script>
        </select>
</div>
                <!--Tabla Alumnos y notas-->

        <table class="table">
            <thead class="thead-inverse">
            <tr>
                <th></th>
                <th>Apellidos</th>
                <th>Nombre</th>
                <th>Nota1</th>
                <th>Nota2</th>
                <th>Nota3</th>
                <th>Media</th>
                <th></th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td><a><button type="submit" class="btn btn-default" value="@n.COD_ALU" name="Modificar" id="Modificar">Modificar</button></a></td>

            </tr>
            </tbody>
        </table>



    </form>
</div>



<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>


<?php
/**
 * Created by PhpStorm.
 * User: Luis
 * Date: 02/06/2017
 * Time: 10:37
 */