// Atividade 1: Alunos Aprovados

// Crie uma função que receba o array alunos e um número que irá representar a média final;

// Percorra o array e popule um novo array auxiliar apenas com os alunos cujas notas são 
// maiores ou iguais à média final;

// Utilizar uma técnica de "desestruturação de objetos" para manipular as propriedades desejadas de cada aluno.

const ALUNOS = [
    {nome: 'Rafael', nota: 5},
    {nome: 'Manu', nota: 8},
    {nome: 'Kira', nota: 9},
    {nome: 'Tobias', nota: 3},
    {nome: 'Ana', nota: 6},
    {nome: 'Maria', nota: 8},
]

function alunos(array, media){
    let aprovados = []

    for(i of ALUNOS){
        if(i.nota >= media){
            aprovados.push(i.nome)
        }
    }
    
    return aprovados

}

console.log(alunos(ALUNOS, 6))


