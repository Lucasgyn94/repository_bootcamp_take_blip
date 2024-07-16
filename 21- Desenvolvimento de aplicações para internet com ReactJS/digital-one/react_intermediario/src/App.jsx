import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Aula1 from './aula-1/Aula1';
import './App.css';


function App() {
  return (
    <div className="App">
      <BrowserRouter basename="/">
        <Switch>
          <Route path="/aula-1" component={Aula1} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;