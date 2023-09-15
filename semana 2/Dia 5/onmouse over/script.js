
function reproducir(elemento){
    elemento.volume = 0;
    elemento.play();
}

function parar(elemento){   
    elemento.pause();
    elemento.load();
}