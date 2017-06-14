
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

require_once  "classnotas.php";


$_LOCALPOST = filter_input_array(INPUT_POST);

$notas = new classnotas();
$posi=0;
$cod_cur = "";
$cod_alu = "";
$apellidos = "";
$nombre = "";
$nota1 = 0;
$nota2 = 0;
$nota3 = 0;
$media="";

$acodalu = "";
$acodalu = $_SESSION["codalu"];
$consulta = $notas->listaralumno($acodalu);
$fila = $notas->lee($consulta);
$cod_alu = $fila[0];
$cod_cur = $fila[1];
$apellidos = $fila[2];
$nombre = $fila[3];
$nota1 = $fila[4];
$nota2 = $fila[5];
$nota3 = $fila[6];
$media = $fila[7];

if (isset($_LOCALPOST['guardar'])) {

    $cod_alu = $_LOCALPOST["campocodalu"];
    $cod_cur = $_LOCALPOST["campocodcur"];
    $apellidos = $_LOCALPOST["campoapellido"];
    $nombre = $_LOCALPOST["camponombre"];
    $nota1 = $_LOCALPOST["nota1"];
    $nota2 = $_LOCALPOST["nota2"];
    $nota3 = $_LOCALPOST["nota3"];
    $media = $_LOCALPOST["media"];


    $notas->modifcar($cod_alu,$nota1,$nota2,$nota3,$media);
    header("Location:nota.php");

}

if (isset($_LOCALPOST['cancelar'])) {

    header("Location:nota.php");
}



?>

<form action='' method='post' class='form-horizontal'>


    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="well well-sm">

                    <fieldset>
                        <div class="panel-heading">
                            <div class="panel-body">
                                <div class="form-group">
                                    <label for="ca" class="control-label">codalu: </label>
                                    <input value="<?php echo $cod_alu ?>" name="campocodalu" id="campocodalu" readonly="readonly">

                                    <label for="ca" class="control-label">codcur: </label>
                                    <input value="<?php echo $cod_cur ?>" name="campocodcur" id="campocodcur" readonly="readonly">

                                    <label for="ape" class="control-label">apellidos: </label>
                                    <input value="<?php echo $apellidos ?>" name="campoapellido" id="campoapellido" readonly="readonly">

                                    <label for="nom">nombre: </label>
                                    <input value="<?php echo $nombre ?>" name="camponombre" id="camponombre" type="text" readonly="readonly">
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label for="nota1">nota1: </label>
                                    <input value="<?php echo $nota1 ?>" name="nota1" id="nota1" type="text">

                                    <label for="nota2">nota2:</label>
                                    <input value="<?php echo $nota2 ?>" name="nota2" id="nota2" type="text">

                                    <label for="nota3">nota3: </label>
                                    <input value="<?php echo $nota3 ?>" name="nota3" id="nota3" type="text">


                                    <label for="media">Media: </label>
                                    <input value="<?php echo $media ?>" name="media" id="media" type="text">
                                </div>

                                <button type="submit" name="guardar" id="guardar" class="btn btn-warning" title="Modifcar Una Nota">guardar </button>
                                <button type="submit" name="cancelar" id="cancelar" class="btn btn-info">cancelar</button>
                            </div>
                        </div>

                    </fieldset>
                </div>
            </div>
        </div>
    </div>
    </div>
<?php
//$consulta->close();
?>



</form>
</body>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>

<script src="js/bootstrap.js" type="text/javascript"></script>

</html>



