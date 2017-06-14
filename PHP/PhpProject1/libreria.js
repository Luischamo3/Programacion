function validacion() {
    
    var condicion = true;

    var pcurso = document.entrada.cur.value;

    var pnumero = document.entrada.num.value;

    var pnombre = document.entrada.nom.value;

    var pedad = document.entrada.age.value;

    var pnota1 = document.entrada.note1.value;

    var pnota2 = document.entrada.note2.value;

    var pnota3 = document.entrada.note3.value;

    if(pcurso.length===0){
        var pcurso = document.entrada.cur.value='Rellene el curso';
        condicion=false;
    }
    
    if(pnumero.length===0){
        var pnumero = document.entrada.num.value='Escriba el número';
        condicion=false;
    }
    
    if(pnombre.length===0){
        var pnombre = document.entrada.nom.value='Escriba un nombre';
        condicion=false;
    }
    
    
    if(pedad.length===0){
        var pedad = document.entrada.age.value='Ingrese la edad';
        condicion=false;
    }
    else if(isNaN(pedad)|| pedad<18){
        var pedad = document.entrada.age.value='Debe ser mayor de edad';
        condicion=false;
    }
    
    
    
    if(pnota1.length===0){
        var pnota1 = document.entrada.note1.value='Escriba la nota';
        condicion=false;
    }
    else if(isNaN(pnota1 )||pnota1>=1 || pnota1 <=10){
        var pnota1 = document.entrada.note1.value='La nota debe ser entre 1 y 10';
        condicion=false;
    }
    
    
     
    if(pnota2.length===0){
        var pnota2 = document.entrada.note2.value='Escriba la nota';
        condicion=false;
    }
    else if(isNaN(pnota2 )||pnota2>=1 || pnota2 <=10){
        var pnota2 = document.entrada.note2.value='La nota debe ser entre 1 y 10';
        condicion=false;
        
        
    }
    
    
    if(pnota3.length===0){
        var pnota3 = document.entrada.note3.value='Escriba la nota';
        condicion=false;
    }
    else if(isNaN(pnota3 )||pnota3>=1 || pnota3 <=10){
        var pnota3 = document.entrada.note3.value='La nota debe ser entre 1 y 10';
        condicion=false;
    }
    
    
    
    if(condicion)
    {
        document.form('entrada').submit();
    }
    console.log(condicion);
    return condicion;
}


