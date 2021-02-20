//usando a notaçao literal
const obj1 = {}
console.log(obj1)

//object em JS
console.log(typeof Object, typeof new Object)
const obj2 = new Object
console.log(obj2)

//funcao construtora
function produto(nome, preco, desc){
    this.nome = nome
    this.getPrecoDesconto = () =>{
        return preco * (1 - desc)
    }
}

const p1 = new produto('Caneta', 7.99, 0.15)
const p2 = new produto('Notebook', 2998.99, 0.25)
console.log(p1.getPrecoDesconto(), p2.getPrecoDesconto())

//funcao factory
function criarFuncionario(nome, salarioBase, faltas){
    return{
        nome,
        salarioBase,
        faltas,
        getsalario(){
            return (salarioBase/30) *(30 - faltas)
        }
    }
}

const f1 = criarFuncionario('joao', 7980, 4)
const f1 = criarFuncionario('maria', 11980, 1)
console.log(f1.getsalario(), f2.getsalario())

//objetct.create
const filha = Object.create(null)
filha.nome = 'ana'
console.log (filha)