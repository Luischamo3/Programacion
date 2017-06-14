<?php

require_once "BDD.php";

class classalumnos extends BDD
{

    protected $cod_cur;
    protected $cod_alu;
    protected $dni;
    protected $nombre;
    protected $apellido;

    public function __construct()
    {
        parent::__construct();
    }

    public function listar($posi, $canti)
    {
        $result = $this->_db->query('SELECT * FROM alumnos limit '.$posi.', '.$canti);
        if($result)
        {
            return $result;
        }
    }

    public function lee($result)
    {
        $alumno = $result->fetch_array(MYSQLI_NUM);
        if($alumno)
        {
            return($alumno);
        }
    }

    public function listarUno($cod_alu1)
    {
        $result = $this->_db->query("SELECT * FROM alumnos where cod_alu = '$cod_alu1'");
        return($result);
    }

    public function ConvertirArray ($result) {
        $fila = $result->fetch_array(MYSQLI_NUM);
        if ($fila){
            return ($fila);
        }
    }

    public function nuevo($cod_cur, $cod_alu, $dni, $apellido, $nombre )
    {
        $query = "INSERT INTO alumnos VALUES (?, ?, ?, ?,?)";
        $stmt = $this->_db->prepare($query);
        $stmt->bind_param('sssss', $cod_alu, $cod_cur, $dni, $apellido,$nombre);    // Enlazamos 4 parámetros
        $stmt->execute();



        if ($stmt->affected_rows > 0)   // Número de filas insertadas
        {
            echo "<p>Insertado Correctamente</p>";

            $query = "INSERT INTO notas VALUES ('" . $cod_cur . "', '" . $cod_alu . "', 0, 0, 0, 0)";
            $validacion = $this->_db->query($query);

            if (!$validacion) {
                echo"<p>error al insertar notas</p>";
            }
            else {
                echo"<p>Notas Insertadas Correctamente</p>";
            }

        }
        else
        {
           echo"<p>Error al insertar el registro</p>";
        }


    }

    public function modificalumno($cod_cur, $cod_alu, $dni, $apellido, $nombre)
    {
        $query = "update alumnos set dni= '%s', apellidos='%s',nombre='%s' where cod_alu = '%s'";
        $nombrep1= $this->_db->real_escape_string($nombre);
        $apellidol= $this->_db->real_escape_string($apellido);
        $query=sprintf($query,$dni,$apellidol,$nombrep1,$cod_alu);
        $comprobacion = $this->_db->query($query);

        if(!$comprobacion)
        {
            echo"<script> alert('Error al modificar el registro')</script>";
        }
    }

    public function borrar($cod_alu)
    {
        $query = "DELETE from notas WHERE cod_alu='" .$cod_alu. "';";
        $eliminar= $this->_db->query($query);

        $query = "DELETE from alumnos WHERE cod_alu='" .$cod_alu. "';";
        $eliminar= $this->_db->query($query);

        if(!$eliminar){
            echo"Error al eliminar el registro";
        }
        else {
            return $eliminar;
            $eliminar->close();
            $this->_db->close();
        }
    }



    public function cierra()
    {
        $this->_db->close();
    }
}


?>