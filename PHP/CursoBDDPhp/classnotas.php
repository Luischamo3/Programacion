<?php

require_once "BDD.php";


class classnotas extends BDD
{

    protected $cod_alu;
    protected $nombre;
    protected $apellido;
    protected $nota1 = 0;
    protected $nota2 = 0;
    protected $nota3 = 0;
    protected $media = 0;

    public function __construct()
    {
        parent::__construct();
    }

    public function listar($cod_cur)
    {
        $result = $this->_db->query("select a.cod_alu,a.cod_cur,a.apellidos,a.nombre,n.nota1,n.nota2,n.nota3,n.media
                                            FROM alumnos as a INNER JOIN notas as n ON a.cod_alu=n.cod_alu WHERE a.cod_cur= '" . $cod_cur . "';");
        if ($result) {
            return $result;
        }
    }

    public function lee($result)
    {
        $notas = $result->fetch_array(MYSQLI_NUM);
        if ($notas) {
            return ($notas);
        }
    }

    public function listaralumno($cod_alu)
    {

        $result2 = $this->_db->query("select a.cod_alu,a.cod_cur,a.apellidos,a.nombre,n.nota1,n.nota2,n.nota3,n.media
                                            FROM alumnos as a INNER JOIN notas as n ON a.cod_alu=n.cod_alu WHERE a.cod_alu= '" . $cod_alu . "';");
        if ($result2) {
            return $result2;
        }
    }

    public function modifcar($cod_cur, $cod_alu, $nota1, $nota2, $nota3 , $media)
    {
        $query = "update notas set nota= %d, nota1=%d,nota2=%d nota3=%d media=%d where cod_alu = '%s'";
        $query=sprintf($query,$nota1,$nota2,$nota3,$media,$cod_alu);
        $comprobacion = $this->_db->query($query);

        if(!$comprobacion)
        {
            echo"<script> alert('Error al modificar el registro')</script>";
        }
    }

    public function graba($cod_cur, $cod_alu, $dni, $apellido, $nombre)
    {

    }

    public function borrar($cod_cur)
    {
        $query = "delete from alumnos where cod_cur='$cod_cur'";
        $eliminar = $this->_db->query($query);
        if (!$eliminar) {
            echo "Error al eliminar el registro";
        } else {
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