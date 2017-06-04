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
$horas = "";
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
        //if ($_SESSION['posi'] < $num - 1)
          $posi = $_SESSION['posi'] + 1;

        $consulta = $cursos->listar($posi, 1);
        $fila = $cursos->lee($consulta);
        $codcur = $fila[0];
        $descrip = $fila[1];
        $horas = $fila[2];
        $tutor = $fila[3];
    }


    if (isset($_LOCALPOST["anterior"]))
    {
        //if ($_SESSION['posi'] > 0)
        //$_SESSION['posi']--;
        @$posi = $_SESSION['posi'] --;

        $consulta = $cursos->listar($posi, 1);
        $fila = $cursos->lee($consulta);
        $codcur = $fila[0];
        $descrip = $fila[1];
        $horas = $fila[2];
        $tutor = $fila[3];
    }
    $_SESSION["posi"] = $posi;
    $consulta->close();


    if (isset($_LOCALPOST["primero"]))
    {
        $posi = $_SESSION['tamaño'];
        //if ($_SESSION['posi'] > 0)
        //$_SESSION['posi']--;
        @$posi = $_SESSION['posi'] --;

        $consulta = $cursos->listar($posi, 1);
        $fila = $cursos->lee($consulta);
        $codcur = $fila[0];
        $descrip = $fila[1];
        $horas = $fila[2];
        $tutor = $fila[3];
    }
    $_SESSION["posi"] = $posi;
    $consulta->close();

}
?>
<div style="width: 80%; margin: 0 auto; ">
    <form action="" method="post" class="form-horizontal">

<!--            <label for="cod_cur" class="col-sm-2 control-label" >C&Oacute;DIGO DEL CURSO:</label>-->
<!---->
<!--            <INPUT TYPE="text" name="cod_cur" class="form-control value="" readonly/>-->
<!---->
<!--            <BR>-->
<!--            <label for="descripcion" class="col-sm-2 control-label" >Descripcion:</label>-->
<!--            <INPUT TYPE="text" name="descripcion" value="" readonly/>-->
<!--            <BR>-->
<!--            <label for="horas" class="col-sm-2 control-label">Horas:</label>-->
<!--            <INPUT TYPE="text" name="horas" value="" readonly/>-->
<!--            <BR>-->
<!--            <label for="Tutor" class="col-sm-2 control-label" >Tutor:</label>-->
<!--            <INPUT TYPE="text" name="tutor" value="" readonly/>-->
<!--            <BR>-->
<!--            <BR>-->

        <div class="form-group">
            <label for="curso">Código del CURSO</label>

            <input type="text" class="form-control" id="campocursos" name="campocursos" placeholder="Cursos" value="<?php echo $codcur ?>" readonly />

        </div>
        <div class="form-group">
            <label for="">Descripcion</label>
            <input type="text" class="form-control" id="campodescripcion" name="campodescripcion" placeholder="RLE" value="<?php echo $descrip ?>" >
        </div>

        <div class="form-group">
            <label for="">Horas</label>
            <input type="text" class="form-control" id="campohoras" name="campohoras" placeholder="RLE" value="<?php echo $horas ?>">
        </div>

        <div class="form-group">
            <label for="">Tutor</label>
            <input type="text" class="form-control" id="campotutor" name="campotutor" placeholder="luis" value="<?php echo $tutor ?>">
        </div>


        <div CLASS="form-group" style="display: inline-flex" >
            <INPUT  class="btn btn-primary btn-lg" TYPE="submit" name="primero" id="primero" value="Primero"/>
            <INPUT class="btn btn-primary btn-lg" type="submit" name="anterior"  id="anterior" VALUE="anterior" />
            <INPUT class="btn btn-primary btn-lg" type="submit" name="siguiente" id="siguiente" VALUE="siguiente"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="Ultimo" value="Ultimo"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="Grabar" value="grabar"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="Borrar" value="Borrar"/>
            <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="Cancelar" value="Cancelar"/>
            <button class="btn btn-primary btn-lg" role="button" type="submit" name="siguiente" id="siguiente" >siguiente</button>
        </div>


    </form>
</div>



<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>



</body>
</html>
