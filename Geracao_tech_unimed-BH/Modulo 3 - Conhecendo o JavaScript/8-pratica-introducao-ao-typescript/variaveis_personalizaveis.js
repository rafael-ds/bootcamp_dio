"use strict";
// function somarValores(input1: number | string, input2: number | string){
//     if(typeof input1 == 'string' || typeof input2 == 'string'){
//         return input1.toString() + input2.toString()
//     }
//     return input1 + input2
// }
function somarValores(input1, input2) {
    if (typeof input1 == 'string' || typeof input2 == 'string') {
        return input1.toString() + input2.toString();
    }
    return input1 + input2;
}
console.log(somarValores(2, 3));
console.log(somarValores('Ola Mundo ', 63));
console.log(somarValores(8, 7));
