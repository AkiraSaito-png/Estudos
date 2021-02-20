const nums = [1, 2, 3, 4, 5]
let resultados = nums.map(function(e){
    return e * 2
})

console.log(resultados)

const soma10 = e => e + 10
const soma10 = e => e * 3
const paraDinheiro = e => `R$ ${parseFloat(e).toFixed(2).replace('.', ',')}`

resultado = nums.map(soma10).map(soma10)
console.log(resultados)