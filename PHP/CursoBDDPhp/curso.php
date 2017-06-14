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
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar"
                        aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div id="navbar" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="Cursos.php">Cursos</a></li>
                    <li><a href="Alumno.php">Alumnos</a>Alumnos</li>
                    <li><a href="nota.php">Notas</a>Notas</li>
                </ul>
            </div>
        </div>
    </nav>
</div>
<br><br><br><br><br><br>


<?php
require_once "cursos.php";
$posi = 0;
$codcur = "";
$descrip = "";
$horas = 0;
$tutor = "";
$_LOCALPOST = filter_input_array(INPUT_POST);
session_start();
$cursos = new cursos();
$consulta = $cursos->listar(0, 100);
$_SESSION['tamaño'] = $consulta->num_rows - 1;
$consulta->close();

if (!isset($_LOCALPOST)) {
    if ($cursos == null) {
        echo "<script>alert('Error en la conexión')</script>";
        return;
    }
    $_SESSION["posi"] = $posi;
    $consulta = $cursos->listar(0, 1);
    $fila = $cursos->lee($consulta);
    $codcur = $fila[0];
    $descrip = $fila[1];
    $horas = $fila[2];
    $tutor = $fila[3];
    $consulta->close();

} else {   // Segunda vez que entra
    if (isset($_LOCALPOST["siguiente"])) {
        $posi = $_SESSION['posi'];
        if ($posi >= $_SESSION['tamaño']) {
            $posi = $_SESSION['tamaño'];
        } else {
            $posi = $posi + 1;
        }
    }

    if (isset($_LOCALPOST['anterior'])) {
        $posi = $_SESSION['posi'];
        if ($posi <= 0) {
            $posi = 0;
        } else {
            $posi = $posi - 1;
        }
    }

    if (isset($_LOCALPOST["primero"])) {//
        $posi = 0;
    }

    if (isset($_LOCALPOST['ultimo'])) {
        $posi = $_SESSION['tamaño'];
    }

    if (isset($_LOCALPOST['grabar'])) {

        $codcur = $_LOCALPOST["campocursos"];
        $descrip = $_LOCALPOST["campodescripcion"];
        $horas = $_LOCALPOST["campohoras"];
        $tutor = $_LOCALPOST["campotutor"];
        $cursos->inserta($codcur, $descrip, $horas, $tutor);
    }

    if (isset($_LOCALPOST['modificar'])) {

        $codcur = $_LOCALPOST["campocursos"];
        $descrip = $_LOCALPOST["campodescripcion"];
        $horas = $_LOCALPOST["campohoras"];
        $tutor = $_LOCALPOST["campotutor"];
        $cursos->modifcar($codcur, $descrip, $horas, $tutor);
    }

    if (isset($_LOCALPOST['borrar'])) {
        $codcur = $_LOCALPOST["campocursos"];
        $cursos->borrar($codcur);
    }

    if (isset($_LOCALPOST['cancelar'])) {
        $consulta = $cursos->listar(0, 100);
    }
    if (isset($_LOCALPOST['nuevo'])) {
        $codcur = "";
        $descrip = "";
        $horas = "";
        $tutor = "";
    } else {
        $consulta = $cursos->listar($posi, 1);
        $fila = $cursos->lee($consulta);
        $codcur = $fila[0];
        $descrip = $fila[1];
        $horas = $fila[2];
        $tutor = $fila[3];
        $_SESSION["posi"] = $posi;
        $consulta->close();
    }
}
?>
<div style="width: 80%; margin: 0 auto; ">
    <form action="" method="post" class="form-horizontal">


        <div class="form-group">
            <label for="curso">Código del CURSO</label>

            <input type="text" class="form-control" id="campocursos" name="campocursos" placeholder="Cursos"
                   value="<?php echo $codcur ?>"/>

        </div>
        <div class="form-group">
            <label for="">Descripcion</label>
            <input type="text" class="form-control" id="campodescripcion" name="campodescripcion" placeholder=""
                   value="<?php echo $descrip ?>">
        </div>

        <div class="form-group">
            <label for="">Horas</label>
            <input type="text" class="form-control" id="campohoras" name="campohoras" placeholder="RLE"
                   value="<?php echo $horas ?>">
        </div>

        <div class="form-group">
            <label for="">Tutor</label>
            <input type="text" class="form-control" id="campotutor" name="campotutor" placeholder="luis"
                   value="<?php echo $tutor ?>">
        </div>


        <div CLASS="form-group row">
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="primero" id="primero" value="Primero"/>
            <INPUT class="btn btn-primary btn-lg" type="submit" name="anterior" id="anterior" VALUE="anterior"/>
            <INPUT class="btn btn-primary btn-lg" type="submit" name="siguiente" id="siguiente" VALUE="siguiente"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="ultimo" value="ultimo"/>
        </div>
        <div class="form-group row">
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="grabar" id="grabar" value="Grabar"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="borrar" id="borrar" value="Borrar"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="modificar" id="modificar" value="modificar"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="nuevo" id="nuevo" value="nuevo"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="cancelar" id="cancelar" value="cancelar"/>

        </div>


    </form>
</div>


<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>


</body>
</html>
