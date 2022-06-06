// Verifique, de duas maneiras diferentes entre si, se uma String é um palíndromo.
// Palíndromo: frase ou palavra que se pode ler, indiferentemente, da esquerda para a direita ou vice-versa 
// (ex.: raiar, ama, ovo, radar)

function palindromo(string){
    let palavra = string.split('').reverse('').join('')

    if(palavra[1] === string[1]){
        console.log(`Palavra: ${string}`)
        console.log(`Palíndromo: ${palavra}`)
        console.log('A palavra é um palíndromo.')        
    }
    else{
        console.log(`Palavra: ${string}`)
        console.log(`Palíndromo: ${palavra}`)
        console.log('A palavra não é um palíndromo.')
    }    
}

palindromo('rafael')