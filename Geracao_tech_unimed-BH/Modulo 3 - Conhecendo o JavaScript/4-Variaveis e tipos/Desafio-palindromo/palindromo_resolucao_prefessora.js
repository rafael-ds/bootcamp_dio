// Verifique, de duas maneiras diferentes entre si, se uma String é um palíndromo.
// Palíndromo: frase ou palavra que se pode ler, indiferentemente, da esquerda para a direita ou vice-versa 
// (ex.: raiar, ama, ovo, radar)

// Solução 1
function palindromo(string){
    if(!string) return 'string inexistente';

    return string.split('').reverse().join('') === string

}

// Solução 2
function palindromo2(string){
    if(!string) return 'string inexistente';
    for(let i = 0; i < string.length / 2; i++ ){
        if(string[i] !== string[string.length -1 -i]){
            return false
        }
    }
    return true
}

console.log(palindromo2('ovo'))