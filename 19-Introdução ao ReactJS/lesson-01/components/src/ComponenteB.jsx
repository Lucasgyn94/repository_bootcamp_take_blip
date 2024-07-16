import React from "react"

function ComponenteB (props) {

    return (
        <div> Componente B =D
            <div>{props.children}</div>
        </div>
    )
}

export default ComponenteB