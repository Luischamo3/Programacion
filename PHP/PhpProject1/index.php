<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
          <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
         <script type="text/javascript" src="./libreria.js">
        </script>
    </head>
    <body>   
         

        <form name="entrada" action="Proceso.php" method="post" style="width: 80%; margin: auto"  class="tex-center">

            <h1>Formulario Alumnos</h1>
                   
        
    <div class="form-group">
    <label for="lcurso">Curso: </label> 
              <input type="text" id="cur" name=”cur” size="50">
  </div>
   
    
  <div class="form-group">
    <label for="lnumero">Número: </label> 
              <input type="text" id="num" name=”num” size="50">
  </div>
              
    <div class="form-group">
                
<label for="lnombre">Nombre: </label> 
              <input type="text" id="nom" name=”nom” size="50">

  </div>   
    
    <div class="form-group">
    
    <label for="ledad">Edad: </label> 
              <input type="text" id="age" name=”age” size="50">

  </div> 
    
    <div class="form-group">
  <label for="lnota1">Nota1: </label> 
              <input type="text" id="note1" name=”note1” size="50">

  </div>   
  
  
    <div class="form-group">
  <label for="lnota2">Nota2: </label> 
              <input type="text" id="note2" name=”note2” size="50">

  </div>   
  
  
    <div class="form-group">
  <label for="lnota3">Nota3: </label> 
              <input type="text" id="note3" name=”note3” size="50">

  </div>   
    	       
           
  <input type="button" class="btn btn-default" id="siguiente" value="Siguiente" onclick="return validacion()">     
        
        
</form>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>
    </body>
</html>
