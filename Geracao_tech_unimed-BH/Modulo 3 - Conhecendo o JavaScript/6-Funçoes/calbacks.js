const calc = function(operacao, n1, n2){
    return operacao(n1, n2)
}

const soma = function(n1, n2){
    return n1 + n2
}

const resultadoSoma = calc(soma, 2,3)
console.log(resultadoSoma)