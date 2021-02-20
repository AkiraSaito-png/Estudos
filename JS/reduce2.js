const alunos = [
    {nome: 'joao', nota: 7.3, bolsista: false},
    {nome: 'meria', nota: 8.2, bolsista: true},
    {nome: 'ana', nota: 9.8, bolsista: false},
    {nome: 'pedro', nota: 8.3, bolsista: true},
]


const resultado = (resultado, bolsista) => resultado && bolsista
console.log(alunos.map(a => a.bolsista).reduce(resultado))

const algumResultado = (resultado, bolsista) => resultado || bolsista
console.log(alunos.map(a => a.bolsista).reduce(resultado))