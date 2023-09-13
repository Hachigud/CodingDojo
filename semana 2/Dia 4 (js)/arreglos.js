console.log("1.- Siempre hambriento")

function siempreHambriento(arr) {
    var aux = 0;
    for(var i =0; i<arr.length; i++){
        if(arr[i] === "comida"){
            console.log("delicioso");
            aux ++;
        }
    }
    if(aux === 0){
        console.log("tengo hambre");
    }
}
   
siempreHambriento([3.14, "comida", "pastel", true, "comida"]);
// esto debería mostrar "delicioso, "delicioso"
siempreHambriento([4, 1, 5, 7, 2]);
// esto debería mostrar "Tengo hambre"


console.log("------------------------");
console.log("2.- Filtro paso alto");

function highPass(arr, cutoff) {
    var filteredArr = [];
    for(var i = 0; i<arr.length; i++){
        if(arr[i] > cutoff ){
            filteredArr.push(arr[i]);
        }
    }
    return filteredArr;
}
var result = highPass([6, 8, 3, 10, -2, 5, 9], 5);
console.log(result); // esperamos de vuelta [6, 8, 10, 9]



console.log("------------------------");
console.log("3.- Mejor que el promedio");

function betterThanAverage(arr) {
    var sum = 0;
    
    for(var i = 0; i< arr.length; i++){
        sum += arr[i];
    }

    var prom = sum/arr.length;
    var count = 0
    for(var i=0; i<arr.length; i++){
        if(arr[i]>prom){
            count ++;
        }
    }
    return count;
}
var result = betterThanAverage([6, 8, 3, 10, -2, 5, 9]);
console.log(result); // esperamos 4 de vuelta

console.log("------------------------");
console.log("4.- Arreglo invertido");

function reverse(arr) {

    var arraux=[];

    for(var i = arr.length; i>0; i--){
        arraux.push(arr[i-1]);
    }

    return arraux;
}
   
var result = reverse(["a", "b", "c", "d", "e"]);
console.log(result); // esperamos de vuelta ["e", "d", "c", "b", "a"]


console.log("------------------------");
console.log("5.- Arreglo de Fibonacci");

function fibonacciArray(n) {
    // [0, 1] son los valores inciales del arreglos para calcular el resto
    var fibArr = [0, 1];
    for(var i = 1; i<n-1; i++){
        fibArr.push(fibArr[i] + fibArr[i-1]);
    }
    return fibArr;
}
   
var result = fibonacciArray(10);
console.log(result); // esperamos de vuelta[0, 1, 1, 2, 3, 5, 8, 13, 21, 34]


