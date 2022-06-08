let button = document.getElementById('btn')
let input_1 = document.getElementById('input1') as HTMLInputElement
let input_2 = document.getElementById('input2') as HTMLInputElement


function adcionarNumeros(num1: number, num2: number, devePrintar: boolean, frase: string){
    let resultado = num1 + num2
    if(devePrintar){
        console.log(frase, resultado)
    }
    return num1 + num2
}

let devePrintar = true
let frase = 'O valor é: '

if(button){

    button.addEventListener('click', () => {
        if(input_1 && input_2){
            adcionarNumeros(Number(input_1.value), Number(input_2.value), devePrintar, frase)
        }
    })

}
