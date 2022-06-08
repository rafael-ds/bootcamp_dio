// Protegendo o tipo

// Desta maneira o retorno sera uma concatecaçã
function soma(n1: number, n2: number){
    return n1 + n2.toString()
}

// Erro provocado. O func(): number indica que
// a saida tera que ser do tipo number
// function soma2(n1: number, n2: number): number{
//     return n1 + n2.toString()
// }

// Saida correta. Desta maneira a função fica protegida
function soma3(n1: number, n2: number): number{
    return n1 + n2
}