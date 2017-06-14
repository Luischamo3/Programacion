
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
        <h1>Datos Alumno</h1> 
        <table class="table">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Curso</th>
                    <th>Edad</th>
                    <th>Numero</th>
                    <th>Nota1</th>
                    <th>Nota2</th>
                    <th>Nota3</th>
                    <th>Valoración</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                  <?php   function validacion($note1, $note2, $note3){
                $media=($note1+$note2+$note3)/3;
                $notafinal="";
                if($media < 3){$notafinal="Muy deficiente";}
                if($media >= 3  && $media < 5){$notafinal="Suspenso";}
                if($media >= 5 && $media<6 ){$notafinal="Suficiente";}
                if($media >=6 && $media <7){$notafinal="Bien";}
                if($media >= 7 && $media < 9){$notafinal="Notable";}
                if($media>=9){$notafinal="Sobresaliente";}
                 return array("notafinal" => $notafinal, "media" => $media);
                  }
                  $_LOCALPOST=  filter_input_array(INPUT_POST);
             $valores = validacion($_LOCALPOST['pnota1'],$_LOCALPOST['pnota2'],$_LOCALPOST['pnota3']);
             
             foreach ($_LOCALPOST as $key => $value) {
                  echo "<td>";
                  echo htmlspecialchars($value);
                  echo "</td>";   
              };
              echo "<td>";
              echo number_format($valores["media"], 2);
              echo "</td>";
              echo "<td>";
              echo $valores["notafinal"];
              echo "</td>";
                  
                 
                 ?>
                </tr>

                <a href="index.php">Atras</a>
            </tbody>
        </table>

        
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js" type="text/javascript"></script>
<script src="js/bootstrap.js" type="text/javascript"></script>
    </body>
    
</html>


