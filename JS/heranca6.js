function aula(nome, videoID){
    this.nome = nome
    this.videoID = videoID
}

const aula1 = new aula('bem vindo', 123)
const aula2 = new aula('até breve', 456)
console.log(aula1, aula2)

function novo(f, ...params){
    const obj = {}
    obj.__proto__ = f.prototype
    f.apply(obj, params)
    return obj
}