const alunos = [
    {nome: 'joao', nota: 7.3, bolsista: false},
    {nome: 'meria', nota: 8.2, bolsista: true},
    {nome: 'ana', nota: 9.8, bolsista: false},
    {nome: 'pedro', nota: 8.3, bolsista: true},
]


console.log(alunos.map(a=>a.nota))
const resultado = alunos.map(a => a.nota).reduce(function(acumulador, atual){
    console.log(acumulador, atual)
    return
}, 0)

console.log(resultado)