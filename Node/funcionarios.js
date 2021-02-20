const url = ''
const axios = require('axios')

const chineses = f => f.pais === 'China'
const mulheres = f => f.genero === 'F'
const menorSalario = (func, funcAtual) => {
    return func.salario < funcAtual
}

axios.get(url).then(responses => {
    const funcionarios = response.data
    console.log(funcionarios)
})