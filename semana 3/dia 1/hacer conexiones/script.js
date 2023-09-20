function cambiarNombre(elemento){
    const elementoNombreUsuario = document.querySelector('#username');
    elementoNombreUsuario.innerText="Martha Gomez";
}


function removerUsuario(elemento,opcion){
    const contenedor = elemento.closest('.card-list-item');
    contenedor.remove();

    let numeroDeConexiones = document.querySelector('#connectionRequestNumber').innerText;
    numeroDeConexiones--;
    document.querySelector('#connectionRequestNumber').innerText = numeroDeConexiones;

    if(opcion ==='aceptar'){
        let numeroTotalDeConexiones = document.querySelector('#totalConnections').innerText;
        numeroTotalDeConexiones++;
        document.querySelector('#totalConnections').innerText = numeroTotalDeConexiones;
    }
}