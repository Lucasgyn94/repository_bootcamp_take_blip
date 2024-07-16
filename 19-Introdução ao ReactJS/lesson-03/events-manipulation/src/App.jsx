import React from "react";

const listCustomer = [
  {
    id: 1,
    name: 'Lucas Ferreira',
    skills: ['React', 'Node', 'CSS', 'Webpack']
  },
  {
    id: 2,
    name: 'Jose Tampa',
    skills: ['HTML', 'React Native', 'Go', 'JS']
  },
  {
    id: 3,
    name: 'Silvio Tanaka',
    skills: ['Assembly']
  },
  {
    id: 4,
    name: 'Jose Pink',
    skills: ['Reason']
  }
]

// handle = lidar com / customers = clientes / skill = habilidades
/*
A propriedade onclick do mixin GlobalEventHandlers é o event handler para o processamento de eventos de click (en-US) em um dado elemento.
O evento click acontece quando o usuário clica em um elemento. É disparado após os eventos mousedown (en-US) emouseup (en-US) na respectiva ordem.
*/
const App = () => {

  const handleClick = (e, id) => {
    console.log('deletar cliente')
    alert(`ID do cliente: ${id}`)
  }

  const renderCustomers = (customer, index) => {
    return (
      <div key={`customer-${customer.id}`}>
        <li>{customer.name}  <button onClick={(e) => handleClick(e, customer.id)}>Deletar Cliente x</button></li>
        {customer.skills.map(renderSkills)}
      </div>
    )
  }

  const renderSkills = (skill, index) => {
    return (
      <div style={{ paddingLeft: '30px' }} key={`skill-${index}`}>
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
          {listCustomer.map(renderCustomers)}
        </ul>
      </div>
    </div>
  );
};
export default App;