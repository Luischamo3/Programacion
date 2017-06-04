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

    public function listarUno($posi)
    {
        $_SESSION['posi'] = $posi;
    }

    public function inserta($codigo, $descrip, $hora, $tut)
    {

    }

    public function graba($codigo, $descrip, $hora, $tut)
    {

    }

    public function borrar($codigo)
    {

    }

    public function cierra()
    {
        $this->_db->close();
    }
}


?>