<!DOCTYPE html>
<html>
<head>
    <title> curso.php proceso de cursos</title>
    <META http-equiv="content-type" content="text/html; charset=ISO-8859-1">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>
<body>

<div style='width: 80%; margin: 0 auto; '>
    <form action='Alumno.php' method='post' class='form-horizontal'>

        <?php
        require_once "classalumnos.php";

        $posi = 0;
        $codcur = "";
        $codalu = "";
        $dni = "";
        $nombre = "";
        $apellido = "";
        $_LOCALPOST = filter_input_array(INPUT_POST);
        session_start();
        $alumno = new classalumnos();
        $consulta = $alumno->listar(0, 100);
        $_SESSION['tamaño'] = $consulta->num_rows - 1;


        if (!isset($_LOCALPOST)) {
            if ($alumno == null) {
                echo "<script>alert('Error en la conexión')</script>";
                return;
            }
//    $_SESSION["posi"] = $posi;
//    $consulta = $alumno->listar(0, 100);
//    $fila = $alumno->lee($consulta);
//    $codcur = $fila[0];
//    $codalu = $fila[1];
//    $dni = $fila[2];
//    $apellido = $fila[3];
//    $nombre = $fila[4];
//    $consulta->close();

            $consulta = $alumno->listar(0, 100);

            echo"<br><br><br><br><br>";
            echo"<table class='table'>";
            echo "<thead class='thead-inverse'>";

            echo"<tr>";
            echo" <th>Curso</th>";
            echo"<th>Codigo Alumno</th>";
            echo"<th>DNI</th>";
            echo"<th>Apeliidos</th>";
            echo"<th>Nombre</th>";
            echo"<th></th>";
            echo"<th></th>";
            echo"</tr>";
            echo"</thead>";
            echo"<tbody>";
            while ( $fila = $alumno->lee($consulta)) {
                echo "<tr>";
                echo "<td>$fila[0]</td>";
                echo "<td>$fila[1]</td>";
                echo "<td>$fila[2]</td>";
                echo "<td>$fila[3]</td>";
                echo "<td>$fila[4]</td>";
                echo "<td><a><button type='submit' class='btn btn-warning' value='$fila[0]' name='modificar'' id='modificar'>Modificar</button></a></td>";
                echo "<td><a><button type='submit' class='btn btn-info' value='$fila[0]' name='borrar' id='borrar'>Borrar</button></a></td>";
                echo "</tr>";
            }
            echo"</tbody>";
            echo"</table>";


        }

        if (isset($_LOCALPOST['borrar'])) {
            $codalu = $_LOCALPOST["borrar"];
            $alumno->borrar($codalu);
            header("Location:Alumno.php");
        }

        if (isset($_LOCALPOST['newalu'])) {
            $_SESSION["opcion"] = 'N';

            header("Location:modificarnuevo.php");

        }

        if (isset($_LOCALPOST['modificar'])) {
            $_SESSION["opcion"] = 'M';
            $_SESSION["codalu"] = $_LOCALPOST["modificar"];
            header("Location:modificarnuevo.php");

        }


        ?>


        <br><br><br><br>

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
                            <li class="active"><a href="Alumno.php">Alumnos</a>Alumnos</li>
                            <li><a href="nota.php">Notas</a>Notas</li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>


        <button style="flex: auto" type="submit" name="newalu" id="newalu" class="btn btn-primary btn-lg" value="" >Nuevo Alumno</button>


    </form>
</div>



<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>

<script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>