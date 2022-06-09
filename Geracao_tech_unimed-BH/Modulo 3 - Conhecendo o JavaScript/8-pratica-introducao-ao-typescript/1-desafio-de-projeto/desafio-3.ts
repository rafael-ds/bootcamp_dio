// O código abaixo tem alguns erros e não funciona como deveria. 
// Você pode identificar quais são e corrigi-los em um arquivo TS?

let botaoAtualizar = document.getElementById('atualizar-saldo');
let botaoLimpar = document.getElementById('limpar-saldo');
let soma = document.getElementById('soma') as HTMLInputElement;
let campoSaldo = document.getElementById('campo-saldo') as HTMLBodyElement;


campoSaldo.innerHTML = '0'

let depositos = []

function somarAoSaldo(soma: string) {
    campoSaldo.innerHTML = soma 
    let saldo = 0

    for(let i = 0; i < depositos.length; i++  ) {
        saldo += Number(depositos[i])
    }

    campoSaldo.innerHTML = String(saldo)

}


function limparSaldo() {
    campoSaldo.innerHTML = '';
}

if(botaoAtualizar){
    botaoAtualizar.addEventListener('click', function () {        
        depositos.push(soma.value)
        somarAoSaldo(soma.value);
    });

}

if(botaoLimpar){

    botaoLimpar.addEventListener('click', function () {
        limparSaldo();
    });
}