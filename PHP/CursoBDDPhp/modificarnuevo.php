<!DOCTYPE html>
<html>
<head>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">


</head>
<body>

<?php
session_start();


require_once "cursos.php";
require_once  "classalumnos.php";

$codcur = "";
$codalu = "";
$dni = "";
$nombre = "";
$apellidos = "";

$_LOCALPOST = filter_input_array(INPUT_POST);

$obj_alu = new classalumnos();

$cod_cur = $_LOCALPOST["codcur"];
$cod_alu = $_LOCALPOST["campocodalu"];
$dni = $_LOCALPOST["campodni"];
$apellidos = $_LOCALPOST["campoapellidos"];
$nombre = $_LOCALPOST["camponombre"];

if (isset($_LOCALPOST["nuevo"])) {


    $obj_alu->nuevo($cod_cur,$cod_alu,$dni,$apellidos,$nombre);
    header("Location:Alumno.php");

}

if (isset($_LOCALPOST["modificar"])) {

    $obj_alu->modificalumno($cod_cur,$cod_alu,$dni,$apellidos,$nombre);
    header("Location:Alumno.php");

}

if (isset($_LOCALPOST["cancelar"])) {


    header("Location:Alumno.php");

}


?>

<form action='' method='post' class='form-horizontal'>
    <?php
    if ($_SESSION["opcion"]== 'N') {
        ?>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="well well-sm">

                        <fieldset>
                            <legend class="text-center header">Nuevo Alumno</legend>
                            <br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-user bigicon"></i></span>
                                <div class="col-md-8">


                                    <!--Combobox-->
                                    <div class='form-group-sm'>
                                        <label for='codcur'>Elegir Curso</label>
                                        <select class='combobox' name='codcur' id='codcur'>

                                            <option value=''>Seleccione Curso</option>
                                            <?php
                                            $cursos = new cursos();
                                            $consulta = $cursos->listar(0, PHP_INT_MAX);

                                            while ($value = $consulta->fetch_array(MYSQL_ASSOC)) {
                                                $cod_cur = $value["cod_cur"];
                                                $desc = $value["descripcion"];
                                                echo "<option value='$cod_cur'> $desc</option>";

                                            }

                                            ?>
                                            <!--                <script type="text/javascript">-->
                                            <!--                    $(document).ready(function () {-->
                                            <!--                        $('.combobox').combobox()-->
                                            <!--                    })-->
                                            <!--                </script>-->
                                        </select>
                                    </div>

                                </div>

                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-user bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campocodalu" name="campocodalu" type="text" placeholder="Código Alumno"
                                           class="form-control">
                                </div>
                            </div>

                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-envelope-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campodni" name="campodni" type="text" placeholder="DNI"
                                           class="form-control">
                                </div>
                            </div>
                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-phone-square bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campoapellidos" name="campoapellidos" type="text" placeholder="Apellidos"
                                           class="form-control">
                                </div>
                            </div>
                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-pencil-square-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="camponombre" name="camponombre" type="text" placeholder="Nombre"
                                           class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-pencil-square-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="cancelar" id="cancelar"
                                           value="cancelar"/>
                                    <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="nuevo" id="nuevo"
                                           value="nuevo"/>
                                </div>

                            </div>
                            <br/><br/>


                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
        <?php
    }
    if ($_SESSION["opcion"] == 'M') {
        $fcod_alu = "";
        $fcod_alu = $_SESSION["codalu"];
        $result = $obj_alu->listarUno($fcod_alu);
        $fila = $obj_alu->lee($result);

        $cod_alu = $fila[0];
        $cod_cur = $fila[1];
        $dni = $fila[2];
        $apellidos = $fila[3];
        $nombre = $fila[4];
        ?>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="well well-sm">

                        <fieldset>
                            <legend class="text-center header">Modificar Alumno</legend>
                            <br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-user bigicon"></i></span>
                                <div class="col-md-8">

                                    <input id="codcur" name="codcur" type="text" placeholder="Código Alumno"
                                           class="form-control" readonly="readonly" value="<?php echo $cod_cur ?>">

                                </div>

                            </div>



                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-user bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campocodalu" name="campocodalu" type="text" placeholder="Código Alumno"
                                           class="form-control" readonly="readonly" value="<?php echo $cod_alu ?>" >
                                </div>
                            </div>

                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-envelope-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campodni" name="campodni" type="text" placeholder="DNI"
                                           class="form-control" value="<?php echo $dni ?>">
                                </div>
                            </div>
                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-phone-square bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="campoapellidos" name="campoapellidos" type="text" placeholder="Apellidos"
                                           class="form-control" value="<?php echo $apellidos ?>">
                                </div>
                            </div>
                            <br/><br/>
                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-pencil-square-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <input id="camponombre" name="camponombre" type="text" placeholder="Nombre"
                                           class="form-control" value="<?php echo $nombre ?>">
                                </div>
                            </div>

                            <div class="form-group">
                                <span class="col-md-1 col-md-offset-2 text-center"><i
                                        class="fa fa-pencil-square-o bigicon"></i></span>
                                <div class="col-md-8">
                                    <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="modificar" id="modificar"
                                           value="modificar"/>
                                    <INPUT class="btn btn-primary btn-lg" TYPE="submit" name="cancelar" id="cancelar"
                                           value="cancelar"/>
                                </div>

                            </div>
                            <br/><br/>


                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
        </div>
        <?php
    }
    ?>



</form>
</body>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>

<script src="js/bootstrap.js" type="text/javascript"></script>

</html>