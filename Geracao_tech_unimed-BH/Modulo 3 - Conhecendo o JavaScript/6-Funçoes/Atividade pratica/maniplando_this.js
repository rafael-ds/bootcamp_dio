// Atividade 2: Esta
// Dada a função calculaIdade, utilize os métodos call e aplique para modificar o valor de this. 
// Crie seus próprios objetos para esta atividade!


function calculaIdade(anos) {
	return `Daqui a ${anos} anos, ${this.nome} terá ${
		this.idade + anos
	} anos de idade.`;
}