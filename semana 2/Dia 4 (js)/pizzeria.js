function pizzaOven (tipoCorteza,tipoSalsa,quesos,salsas){
    var pizza= {};
    pizza.corteza = tipoCorteza;
    pizza.tipoSalsa = tipoSalsa;
    pizza.quesos = quesos;
    pizza.salsas = salsas;

    return pizza;
}


var pizzaChicago = pizzaOven("estilo Chicago","tradicional",["mozarella"],["pepperoni","salchicha"]);
console.log(pizzaChicago);

var pizzaMano = pizzaOven("landazada a mano", "marinara" , ["mozarella","feta"],["champiñones","aceitunas","cebollas"]);
console.log(pizzaMano);

var pizzaPiña = pizzaOven("crocante", "marinara" , ["mozarella","feta","piña"],["champiñones","aceitunas"]);
console.log(pizzaPiña);

var pizzaCarne = pizzaOven("crocante", "marinara" , ["mozarella"],["champiñones","aceitunas","carne"]);
console.log(pizzaCarne);