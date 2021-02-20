const notas = [7.7, 6.5]

//sem callback
let notasBaixas1 = []
for (let i in notas) {
    if(notas[i] < 7){
        notasBaixas1.push(notas[i])
    }
}

console.log(notasBaixas1)

//com callback
notasBaixas2 = notas.filter(function (nota){
    return nota < 7
})

console.log(notasBaixas2)

