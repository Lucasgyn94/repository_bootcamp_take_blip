import React from "react";
import mock from '../mock'
import Button from '../components/Button'

const App = () => {

  const handleClick = (id) => {
    console.log('deletar cliente')
    alert(`ID do cliente: ${id}`)
  }

  const renderCustomers = (customer, index) => {
    return (
      <div key={`customer-${customer.id}`}>
        <li>{customer.name}  <Button onClick={() => handleClick(customer.id)}>Deletar o Cliente </Button></li>
        {customer.skills.map(renderSkills)}
      </div>
    )
  }

  const renderSkills = (skill, index) => {
    return (
      <div style={{ paddingLeft: '30px'} } key={`skill-${index}`}>
        <li>{skill}</li>
      </div>
    )
  }

  return (
    <div>
      <p>Digital Innovation One</p>
      <p>Bem vindo a nossa aula =D.</p>
      <div>
        <ul>
          {mock.map(renderCustomers)}
        </ul>
      </div>
    </div>
  );
};
export default App;

/*
  O elemento HTML <li>  (ou a Lista dos Itens de um elemento HTML) é 
  usado para representar um item que faz parte de uma lista.

  O elemento HTML <ul> (ou elemento HTML de Lista desordenada) 
  representa uma lista de itens sem ordem rígida, isto é, 
  uma coleção de itens que não trazem uma ordenação numérica 
  e as suas posições, nessa lista, são irrelevantes. 
  Caracteristicamente, os itens em uma lista desordenada 
  são exibidos com um marcador que pode ter várias formas, 
  como um ponto, um círculo, ou um quadrado. 
  
  O método map() invoca a função callback passada por argumento 
  para cada elemento do Array e devolve um novo Array como 
  resultado.

*/