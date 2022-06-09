// Como podemos rodar isso em um arquivo .ts sem causar erros? 

// let employee = {};
// employee.code = 10;
// employee.name = "John";


let employee: {code: number, name: string} = {

    code: 10,
    name: "John",
}
 console.log(employee.code)
 console.log(employee.name)


interface Employee {
     code: number,
     name: string
 }

 const JONH: Employee = {
     code: 10,
     name: 'Jonh'

 }

