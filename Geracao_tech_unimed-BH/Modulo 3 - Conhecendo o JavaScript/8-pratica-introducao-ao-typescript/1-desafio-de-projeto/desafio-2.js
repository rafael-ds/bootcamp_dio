"use strict";
// Como podemos melhorar o esse código usando TS? 
// let pessoa1 = {};
// pessoa1.nome = "maria";
// pessoa1.idade = 29;
// pessoa1.profissao = "atriz"
// let pessoa2 = {}
// pessoa2.nome = "roberto";
// pessoa2.idade = 19;
// pessoa2.profissao = "Padeiro";
// let pessoa3 = {
//     nome: "laura",
//     idade: "32",
//     profissao: "Atriz"
// };
// let pessoa4 = {
//     nome = "carlos",
//     idade = 19,
//     profissao = "padeiro"
// }
// interface PESSOA {
//     nome: string,
//     idade: number,
// }
var Profissao;
(function (Profissao) {
    Profissao[Profissao["Atriz"] = 0] = "Atriz";
    Profissao[Profissao["Padeiro"] = 1] = "Padeiro";
})(Profissao || (Profissao = {}));
const PESSOA1 = {
    nome: 'Maria',
    idade: 29,
    profissao: Profissao.Atriz
};
const PESSOA2 = {
    nome: 'Roberto',
    idade: 19,
    profissao: Profissao.Padeiro
};
const PESSOA3 = {
    nome: 'Laura',
    idade: 32,
    profissao: Profissao.Atriz
};
const PESSOA4 = {
    nome: 'Carlos',
    idade: 19,
    profissao: Profissao.Padeiro
};
console.log(PESSOA1);
console.log(PESSOA2);
console.log(PESSOA3);
console.log(PESSOA4);
