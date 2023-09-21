function cityalert(elemento){
    alert("Cargando informe metereologico");
}

function ocultar(elemento){
    const cookie = document.querySelector('.cookie-section');
    cookie.remove();
}

function cambiar(elemento){
   let opcion = elemento.value;
   let temperaturas = document.querySelectorAll('.max > span, .min >span');
   if(opcion === 'f'){
    for(let i = 0; i < temperaturas.length; i ++){
        let temperatura = temperaturas[i].innerText;
        let temperaturaFinal = (temperatura * 1.8) + 32;
        temperaturas[i].innerText = Math.round(temperaturaFinal);
    }
}
else{
    for(let i = 0; i < temperaturas.length; i ++){
        let temperatura = temperaturas[i].innerText;
        let temperaturaFinal = (temperatura - 32) / 1.8;
        temperaturas[i].innerText = Math.round(temperaturaFinal);
    }
}

}