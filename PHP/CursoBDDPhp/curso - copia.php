<html>
<head>
    <title> curso.php proceso de cursos</title>
    <META http-equiv="content-type" content="text/html; charset=ISO-8859-1">
</head>
<body>

<?php
require_once "cursos.php";

$codcur = "";
$descrip = "";
$horas = "";
$tutor = "";
$_LOCALPOST = filter_input_array(INPUT_POST);
session_start();
$cursos = new cursos();
//$conexion = mysqli_connect("localhost", "root", "", "ocupacional2");
if (!isset($_LOCALPOST)){
    if ($cursos == null) {
        echo "<script>alert('Error en la conexión')</script>";
        return;
    }
    $_SESSION["posi"] = $posi;

}
else{   // Segunda vez que entra
    $query = "select * from cursos";
    $resultado = mysqli_query($conexion, $query);
    if ($resultado == FALSE) {
        echo 'Error en la consulta';
        exit();
    }
    $num = mysqli_num_rows($resultado);
    if (isset($_SESSION['valor'])) {
        if (isset($_POST['siguiente']))
            if ($_SESSION['valor'] < $num - 1)
                $_SESSION['valor']++;

        if (isset($_POST['anterior']))
            if ($_SESSION['valor'] > 0)
                $_SESSION['valor']--;
        mysqli_data_seek($resultado, $_SESSION['valor']);
    } else {
        $_SESSION['valor'] = 0;
        mysqli_data_seek($resultado, 0);
    }
    $row = mysqli_fetch_row($resultado);
    mysqli_close($conexion);
}
?>

<form ACTION="curso.php" METHOD="post">
    C&Oacute;DIGO DEL CURSO:&nbsp; <INPUT TYPE="text" name="cod_cur" value=
    "<?php echo $row[0]; ?>" readonly>
    <BR>
    DESCRIPCI&Oacute;N:&nbsp; <INPUT TYPE="text" name="descripcion" value=
    "<?php echo $row[1]; ?>" readonly>
    <BR>
    TURNO:&nbsp; <INPUT TYPE="text" name="turno" value=
    "<?php echo $row[2]; ?>" readonly>
    <BR>
    TUTOR:&nbsp; <INPUT TYPE="text" name="tutor" value=
    "<?php echo $row[3]; ?>" readonly>
    <BR>
    <BR>
    &nbsp; <INPUT TYPE="submit" name="siguiente" value="siguiente">
    &nbsp; <INPUT TYPE="submit" name="anterior" value="anterior">
    &nbsp; <INPUT TYPE="submit" name="Grabar" value="grabar">
    &nbsp; <INPUT TYPE="submit" name="Borrar" value="Borrar">
    &nbsp; <INPUT TYPE="submit" name="Cancelar" value="Cancelar">

</form>

</body>
</html>
