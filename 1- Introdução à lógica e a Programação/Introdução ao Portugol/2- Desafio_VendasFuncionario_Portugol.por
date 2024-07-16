programa {
	
	funcao inicio() {

		cadeia nome
		real vendas_janeiro, vendas_fevereiro, vendas_marco, vendas_abril, media_vendas

		escreva("Digite o seu nome: ")
		leia(nome)

		escreva("Digite o valor total das vendas de janeiro: ")
		leia(vendas_janeiro)

		escreva("Digite o valor total das vendas de fevereiro: ")
		leia(vendas_fevereiro)

		escreva("Digite o valor total das vendas de março: ")
		leia(vendas_marco)

		escreva("Digite o valor total das vendas de abril: ")
		leia(vendas_abril)

		media_vendas = (vendas_janeiro + vendas_fevereiro + vendas_marco + vendas_abril) / 4

		se (media_vendas >= 5000) {
			escreva("\nParabéns! Você receberá um abono de 10%\n")
		} senao {
			escreva("\nVocê receberá um abono de 3%\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 621; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */