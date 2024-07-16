// Função do algoritmo: Calcular a média aritmética

programa {

	funcao inicio () {
		real nota1, nota2, nota3, nota4, media
		cadeia nome

		escreva("Digite o seu nome: ")
		leia(nome)

		escreva("Digite a primeira nota: ")
		leia(nota1)

		escreva("Digite a segunda nota: ")
		leia(nota2)

		escreva("Digite a terceira nota: ")
		leia(nota3)

		escreva("Digite a quarta nota: ")
		leia(nota4)

		media = (nota1 + nota2 + nota3 + nota4) / 4

		escreva("\nA sua média = " + media)
		escreva("\n")

		// verifica se a média é maior ou igual a 7
		se (media >= 7) {
			escreva("Parabéns! Você foi aprovado.\n")
		} 
		// caso a nota seja menor que 7
		senao {
			escreva("Que pena! Você foi reprovado.\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 708; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */