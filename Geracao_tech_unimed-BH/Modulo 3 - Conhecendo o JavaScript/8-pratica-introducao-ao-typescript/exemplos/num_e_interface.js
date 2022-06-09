"use strict";
const PESSOA = {
    nome: 'Rafael',
    idade: 38,
    profissao: 'Dev'
};
PESSOA.idade = 18;
const MANU = {
    nome: 'Manu',
    idade: 25,
    profissao: 'Dev'
};
var Profissao;
(function (Profissao) {
    Profissao[Profissao["Professora"] = 0] = "Professora";
    // Atriz,
    Profissao[Profissao["Desenvolvedora"] = 1] = "Desenvolvedora";
    Profissao[Profissao["Advogada"] = 2] = "Advogada";
    Profissao[Profissao["Estudante"] = 3] = "Estudante";
})(Profissao || (Profissao = {}));
const KIRA = {
    nome: 'Kira',
    idade: 25,
    profissao: Profissao.Professora
};
const ISABELA = {
    nome: 'Isabela',
    idade: 10,
    profissao: Profissao.Estudante,
    materia: ['Matematica', 'Português', 'Ciências', 'Geografia']
};
function listarMaterias(lista) {
    for (let item of lista) {
        console.log('- ', item);
    }
}
listarMaterias(ISABELA.materia);
