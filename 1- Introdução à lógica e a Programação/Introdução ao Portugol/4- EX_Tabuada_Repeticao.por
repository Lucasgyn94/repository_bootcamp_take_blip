programa {
	
	funcao inicio() {

		inteiro contador, limite, resultado, numero

		contador = 0
		limite = 0

		escreva("Digite o número da tabuada que você deseja exibir: ")
		leia(numero)

		escreva("Digite até qual número deseja exibir a tabuada: ")
		leia(limite)

		faca {
			resultado = numero * contador
			escreva(numero + " x " + contador + " = " + resultado)
			contador++
			escreva("\n")
		} enquanto(contador <= limite)	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 197; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */