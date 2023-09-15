function login(elemento){
    if(elemento.innerText == "Login"){
        elemento.innerText = "Log out";
    }else{
        elemento.innerText = "Login";
    }
}

function definition(elemento){
    elemento.remove();
}

function ninjalike(elemento){
    alert("Ninjas was liked");
}