function soma(num1, num2){
    const IGUAIS = (num1 === num2) ? `Os numeros ${num1} e ${num2} São iguais` : `Os numeros ${num1} e ${num2} Não são iguais` 
    
    const SOMA = num1 + num2

    function comparar(){
        if(SOMA < 10){
            return "menor que 10 e menor que 20"
        }
        else if(SOMA > 10 && SOMA < 20){
            return "maior que 10 e menor que 20"
        }
        else{
            return "maior que 10 e maior que 20"
        }
    }

    return `${IGUAIS}. Sua soma é ${SOMA}, que é ${comparar()}.`
}

console.log(soma(1,2))