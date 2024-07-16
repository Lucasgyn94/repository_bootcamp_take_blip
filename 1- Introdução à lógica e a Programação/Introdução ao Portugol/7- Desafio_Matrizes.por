programa {

	funcao inicio() {

		inteiro i = 0
		cadeia matriz[][] = {{"Joao", "São Paulo", "(11) 9999-5241"}, {"Maria", "Ribeirão Preto", "(16) 9999-8596"}, {"Ana", "Manaus", "(92) 9999-8574"}}

		faca {

			escreva("O seu nome é: " + matriz[i][0] + "\n")
			escreva("Cidade: " + matriz[i][1] + "\n")
			escreva("Telefone: " + matriz[i][2] + "\n\n")
			i++
			
		} enquanto (i <= 2)
	}	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 364; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */