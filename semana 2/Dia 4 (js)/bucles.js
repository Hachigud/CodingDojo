console.log("1.- Imprimir imapres : ");

for ( var i = 1; i<=20; i++){
    if(i%2 !=0){
        console.log(i);
    }
}

console.log ("-------------------------------------");

console.log("2.- Disminuir múltiplos de 3");
for ( var i = 100; i>=1; i--){
    if(i%3 ==0){
        console.log(i);
    }
}

console.log ("-------------------------------------");

console.log("3.- Imprime la secuencia");

for (var i = 1; i<=6;i++){
    if( i == 1){
        console.log(4);
    }
    if( i == 2){
        console.log(2.5);
    }
    if( i == 3){
        console.log(1);
    }
    if( i == 4){
        console.log(-0.5);
    }
    if( i == 5){
        console.log(-2);
    }
    if( i == 6){
        console.log(-3.5);
    }
}


console.log ("-------------------------------------");

console.log("4.- Sigma");

var sum = 0;
for (var i = 1; i <= 100; i++){
    sum += i;
}
console.log(sum);

console.log ("-------------------------------------");

console.log("4.- Factorial");

var producto = 1;

for  (var i =2 ; i <=12; i++){
    producto *= i;
}
console.log(producto);