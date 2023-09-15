


function ninjalike(elemento){
    let cantidadLikes = elemento.closest('.contenido-izq').querySelector('#cantidadLikes');
    let numeroLikes = cantidadLikes.innerText;
    numeroLikes ++;
    cantidadLikes.innerText = numeroLikes;
}