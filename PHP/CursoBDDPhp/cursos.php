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
        $query = "INSERT INTO cursos VALUES (?, ?, ?, ?)";
        $stmt = $this->_db->prepare($query);
        $stmt->bind_param('ssds', $codigo, $descrip, $hora, $tut);    // Enlazamos 4 parámetros
        $stmt->execute();

        if ($stmt->affected_rows > 0)   // Número de filas insertadas
        {
            echo  "<p>Insertado Correctamente</p>";
        } else
        {
            echo "<p>Error al insertar el registro</p>";
        }
	}
	
    public function modifcar($codigo, $descrip, $hora, $tut)
    {
        $query = "update cursos set descripcion= '%s', horas='%d',tutor='%s' where cod_cur = '%s'";
        $descrip1= $this->_db->real_escape_string($descrip);
        $tut1= $this->_db->real_escape_string($tut);
        $query=sprintf($query,$descrip1,$hora,$tut1,$codigo);
        $comprobacion = $this->_db->query($query);

        if(!$comprobacion)
        {
            echo"<script> alert('Error al modificar el registro')</script>";
        }

    }
        	
	public function borrar($codigo)
	{
        $query = "delete from cursos where cod_cur='$codigo'";
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

