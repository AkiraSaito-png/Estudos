const funcionario = {nome: 'MAria', salario: 12348.99}
const clone = {ativo: true, ...funcionario}
console.log(clone)

const grupoA = ['Joao', 'pedro', 'gloria']
const grupoFinal = ['maria', ...grupoA, 'rafaela']
console.log(grupoFinal)