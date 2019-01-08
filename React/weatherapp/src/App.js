import React, { Component } from 'react';
import WeatherLocation from './components/WL/WeatherLocation';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider'; // para agregar un tema desde libreria Material ui
import './App.css';

class App extends Component {
  render() {
    return (
      <MuiThemeProvider> 
        <div className="App">
          <WeatherLocation></WeatherLocation>
        </div>
      </MuiThemeProvider>
    );
  }
}

export default App;
