import React, { Component } from "react"
import ReactDOM from "react-dom"
import "./index.css"

class App extends Component {

    /* Props, é uma abreviação de properties, ou propriedades, 
    são informações que podem ser passadas para um componente. 
    Pode ser uma string, um número, até mesmo uma função. 
    Este valor pode então ser utilizado pelo componente que a recebe.
    */

  constructor(props) {
    super(props)

    this.state = {
      clock: 1000,
      copo: 'água'
    }
  }

//componentDiMount() Chamado imediatamente após a montagem de um componente. Definir o estado aqui irá desencadear uma nova renderização.

  componentDidMount() {
    // setTimeout() = definir o tempo limite
    window.setTimeout(() => {
      this.setState({
        copo: 'suco'
      })
    }, 3000)
  }

  alterarCopo = () => {
    // set = definir. Ele permiti armazenar valores únicos de qualquer tipo desde valores primitivos  a referência em objetos;
    this.setState({
      copo: 'refrigerante'
    })
  } 

  render() {
    const { clock, copo } = this.state
    return (
      <div>
        <h1>{clock}</h1>
        <button onClick={() => this.alterarCopo()}><h1>{copo}</h1></button>
      </div>
    )
  }
}

const rootElement = document.getElementById("root")
ReactDOM.render(<App />, rootElement)