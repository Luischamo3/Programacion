<?php
 // Clase cursos, hereda de BDD
  require_once "BDD.php";
  
  class cursos extends BDD
  {
    protected $cod_cur;
	protected $descripcion;
	protected $horas;
	protected $tutor;
	
    public function __construct()
	{
	  parent::__construct();
	}
	
	public function listar($posi, $canti)
	{
	  $result = $this->_db->query('SELECT cod_cur,descripcion,horas, tutor FROM cursos limit '.$posi.', '.$canti);
      if($result)
      {
	    return $result;
      }
	}
        
    public function lee($result)
    {
       $curso = $result->fetch_array(MYSQLI_NUM);
       if($curso)
       {
          return($curso);
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

