"use strict";
let button = document.getElementById('btn');
let input_1 = document.getElementById('input1');
let input_2 = document.getElementById('input2');
function adcionarNumeros(num1, num2) {
    return num1 + num2;
}
if (button) {
    button.addEventListener('click', () => {
        if (input_1 && input_2) {
            adcionarNumeros(Number(input_1.value), Number(input_2.value));
        }
    });
}
