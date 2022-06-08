// types
// interface

interface IAnimal{
    nome: string;
    tipo: 'terrestre' | 'aquático';
}

interface IFelino extends IAnimal{
    visaoNoturna: boolean;
    sabeNadar: boolean
}

const ANIMAL: IAnimal = {
    nome: 'Elefante',
    tipo: "terrestre"
} 

const FELINO: IFelino = {
    nome: 'Tigre',
    tipo: 'terrestre',
    visaoNoturna: true,
    sabeNadar: false
}