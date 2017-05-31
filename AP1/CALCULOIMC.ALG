algoritmo "calculoIMC"

var
nome,peso,altura,IMC:real

inicio
escreval("qual seu nome?")
leia(nome)
          escreval("qual seu peso ?")
          leia(peso)
                    escreval("qual sua altura?")
                     leia(altura)
IMC:= (peso / (altura*altura))
              escreval("o seu IMC é:",IMC)
//peso< 18,5 = abaixo do peso
//peso entre 18,6 e 24,9 = peso ideal
//peso entre 30,0 e 34,9 = obesidade
fimalgoritmo