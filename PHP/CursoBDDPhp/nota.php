<html>
<head>
    <title> curso.php proceso de cursos</title>
    <META http-equiv="content-type" content="text/html; charset=ISO-8859-1">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>
<body>
<div style="width: 80%; margin: 0 auto; ">
    <form action="" method="post" class="form-horizontal">

        <div>
            <nav class="navbar navbar-fixed-top navbar-inverse">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse"
                                data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>

                    </div>
                    <div id="navbar" class="collapse navbar-collapse">
                        <ul class="nav navbar-nav">
                            <li><a href="curso.php">Cursos</a></li>
                            <li><a href="Alumno.php">Alumnos</a>Alumnos</li>
                            <li class="active"><a href="nota.php">Notas</a>Notas</li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
        <br><br><br><br><br><br>


        <?php
        require_once "cursos.php";
        require_once "classnotas.php";
        $posi = 0;
        $cod_cur = "";
        $cod_alu = "";
        $apellidos = "";
        $nombre = "";
        $nota1 = 0;
        $nota2 = 0;
        $nota3 = 0;
        $media="";
        $_LOCALPOST = filter_input_array(INPUT_POST);
        session_start();
        $cursos = new cursos();
        $notas = new classnotas();
        $consulta = $cursos->listar(0, 100);
        //        $consulta2 = $notas->listar($cod_cur1);
        $_SESSION['tamaño'] = $consulta->num_rows - 1;
        // $consulta->close();

        //$_SESSION['tamaño'] = $consulta->num_rows - 1;
        $_SESSION["cursoactual"] = $_LOCALPOST["cursobox"];



        ?>

        <!--Combobox-->
        <div class='form-group-sm'>
            <label for='cc'>Elegir Curso</label>
            <select class='combobox' name='cursobox' id='cursobox' onchange="this.form.submit()">

                <option value=''>Seleccione Curso</option>
                <?php
                $cursos = new cursos();
                $consulta = $cursos->listar(0, PHP_INT_MAX);

                while ($value = $consulta->fetch_array(MYSQL_ASSOC)) {
                    $cod_cur = $value["cod_cur"];
                    $desc = $value["descripcion"];
                    if ($cod_cur == $_SESSION["cursoactual"]) {
                        echo "<option value='$cod_cur' selected='selected'> $desc</option>";
                    } else {
                        echo "<option value='$cod_cur' > $desc</option>";
                    }
                }
                ?>

                <script type="text/javascript">
                    $(document).ready(function () {
                        $('.combobox').combobox()
                    })
                </script>
                -->
            </select>
        </div>

        <!--Tabla Alumnos y notas-->


        <?php
        $cod_cur1 = "";
        $cod_cur1 = $_LOCALPOST["cursobox"];

        $consulta2 = $notas->listar($cod_cur1);
        echo "<br><br><br><br><br>";
        echo "<table class='table'>";
        echo "<thead class='thead-inverse'>";

        echo "<tr>";
        echo " <th>Codigo Alu</th>";
        echo " <th>Codigo Cur</th>";
        echo "<th>Apellidos</th>";
        echo "<th>Nombre</th>";
        echo "<th>Nota1</th>";
        echo "<th>Nota2</th>";
        echo "<th>Nota3</th>";
        echo "<th>Media</th>";
        echo "<th></th>";

        echo "</tr>";
        echo "</thead>";
        echo "<tbody>";

        while ($fila = $notas->lee($consulta2)) {
            echo "<tr>";
            echo "<td>$fila[0]</td>";
            echo "<td>$fila[1]</td>";
            echo "<td>$fila[2]</td>";
            echo "<td>$fila[3]</td>";
            echo "<td>$fila[4]</td>";
            echo "<td>$fila[5]</td>";
            echo "<td>$fila[6]</td>";
            echo "<td>$fila[7]</td>";
            echo "<td><a><button type='submit' class='btn btn-warning' value='$fila[0]' name='modificar' id='modificar'>Modificar</button></a></td>";

            echo "</tr>";
        }
        echo "</tbody>";
        echo "</table>";

        if (isset($_LOCALPOST['modificar'])) {

//
            $_SESSION["codalu"] = $_LOCALPOST["modificar"];
            header("Location:Modificarnota.php");
        }
//        $consulta->close();

        ?>








    </form>
</div>


<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>


