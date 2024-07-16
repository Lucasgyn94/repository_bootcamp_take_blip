programa {
	
	funcao inicio() {

		inteiro opcao_menu = 0

		escreva("1- Abrir Netflix.\n")
		escreva("2- Abrir Amazon Prime.\n")
		escreva("3- Abrir HBO GO.\n")
		escreva("4- Sair.\n")

		escreva("\nDigite uma das opções do menu: ")
		leia(opcao_menu)

		escolha(opcao_menu) {
			caso 1: escreva("Abrindo netflix!\n")
			pare

			caso 2: escreva("Abrindo Amazon Prime\n")
			pare

			caso 3: escreva("Abrindo HBO GO\n")
			pare

			caso 4: escreva("Saindo...\n")
			pare

			caso contrario: escreva("Selecione uma das opções do menu.\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 475; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */