const pessoa = {
    nome: 'rebeca',
    idade: 2,
    peso: 13
}

console.log(Object.keys(pessoa))
console.log(Object.values(pessoa))
console.log(Object.entries(pessoa))

Object.entries(pessoa).forEach([chave, valor] => {
    console.log(`${chave}: ${valor}`)
})

Object.defineProperties(pessoa, 'dataNascimento',{
    enmerable: true,
    writable: false,
    value: '01/01/2019'
})

pessoa.dataNascimento = 
console.log(pessoa.dataNascimento)
console.log(Object,keys(pessoa))

const dest = {a: 1}
const o1 = {b:2}