function Pessoa(){
    this.idade = 0

    const self = this
    setInterval(function() {
        self.idade++;
        console.log(self.idade)
    },1000) // a cada 1 segundo essa funcao sera disparada
}

new Pessoa