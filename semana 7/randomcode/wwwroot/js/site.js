// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function generar(){
    const characters ='ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
    const charactersLength = characters.length;
    let cantidad = document.getElementById("cantidadCodes");
    let cantidadTotal = cantidad.innerText;
    cantidadTotal ++;
    cantidad.innerText = cantidadTotal;
    let codigo = document.getElementById("codigo");
    let newCode = "";
    for ( let i = 0; i < 14; i++ ) {
        newCode += characters.charAt(Math.floor(Math.random() * charactersLength));
    }
    codigo.value = newCode;
}