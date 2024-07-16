import React from "react"
import ReactDOM from "react-dom"
import Button from "./Button"
import ComponenteA from "./ComponenteA"
import ComponenteB from "./ComponenteB"
import "./index.css"

function soma(a, b) {
    alert(a + b)
    
}

function App() {
    return (
        <div className="App">
            Hello World
            <Button onClick={() => soma(10, 20)} name="Lucas Ferreira" />
            <ComponenteA>
                <ComponenteB>
                   <Button onClick={() => soma(50, 50)} name="Julia Silva" /> 
                </ComponenteB>
            </ComponenteA>
        </div>
    )
}

const rootElement = document.getElementById("root")
ReactDOM.render(<App />, rootElement)