const PESSOA = {
    nome: 'Rafael',
    idade: 38,
    profissao: 'Dev'
}

PESSOA.idade = 18

const MANU: {nome: string, idade: number, profissao: string} = {
    nome: 'Manu',
    idade: 25,
    profissao: 'Dev'

}

enum Profissao {
    Professora,
    Atriz,
    Desenvolvedora,
    Advogada,
    Estudante
}

interface Pessoa {
    nome: string,
    idade: number,
    profissao?: Profissao

}

interface Estudante extends Pessoa{
    materia: string[]
}

const KIRA: Pessoa = {
    nome: 'Kira',
    idade: 25,
    profissao: Profissao.Professora
}

const ISABELA: Estudante = {
    nome: 'Isabela',
    idade: 10,
    profissao: Profissao.Estudante,
    materia: ['Matematica', 'Português', 'Ciências', 'Geografia']

}

function listarMaterias(lista: string[]){
    for(let item of lista){
        console.log('- ', item)
    }
}

listarMaterias(ISABELA.materia)