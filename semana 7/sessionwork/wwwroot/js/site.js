// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function operacion(operacion){
    let numero = document.getElementById("Numero");
    let numeroTotal = numero.innerText;
    let random = 0;
    if(operacion === "sumar"){
        numeroTotal++;
    }
    if(operacion === "restar"){
        numeroTotal--;
    }
    if(operacion === "multiplicar"){
        
        numeroTotal = numeroTotal * 2;
    }

    if(operacion === "random"){
        random = Math.floor(Math.random()*10);
        console.log(random);
        numeroTotal = parseInt(numeroTotal) + parseInt(random);
    }

    numero.innerText = numeroTotal;
}





