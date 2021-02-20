const produto = [ 
    { nome: 'notebook', preco: 2499, fragil: true},
    { nome: 'Iped pro', preco: 4499, fragil: true},
    { nome: 'copo', preco: 12.99, fragil: true},
    { nome: 'caneca', preco: 18.99, fragil: false}
]

console.log(produto.filter(function(p){
    return p.preco > 2400
}))