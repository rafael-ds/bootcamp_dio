// Atividade 2
// Troque todos os elementos pares e diferentes de zero de um array pelo número 0. 
// Se o array for vazio, rendimento -1.
// Exemplo: Entrada -> [1, 3, 4, 6, 80, 33, 23, 90]
// Saída -> [1, 3, 0, 0, 0, 33, 23, 0]
// Entrada -> []
// Saída -> -1

function lista(...num){
    num.forEach(l => l % 2 == 0 ? console.log(l = 0) : console.log(l))

    if(num.length == 0){
        console.log(-1)
    }
}

lista(1, 3, 4, 6, 80, 33, 23, 90)
lista()