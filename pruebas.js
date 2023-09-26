/*
for(var i=8; i>-2; i-=3) {
    console.log(i);
}


var x = "0";
for(var i=1; i<5; i++) {
     x += i;
 }
 console.log(x);
 */



 /* 
 Dado el arreglo ["Perro","Gato","Vaca","Alpaca","Chinchilla"]
convertirlo en éste: ["Vaca","Alpaca","Chinchilla","Perro","Gato"] 
*/

/* 
let array = ["Perro","Gato","Vaca","Alpaca","Chinchilla"];
let arrayAux = [];
let arrayAux2 = [];
let arrayFinal = [];
for (let i = 2; i< array.length; i++){
    arrayAux[i-2] = array[i];
}

for (i = 0; i< 2; i++){
    arrayAux2[i] = array[i];
}

arrayFinal = arrayAux.concat(arrayAux2);

console.log(arrayFinal);
*/