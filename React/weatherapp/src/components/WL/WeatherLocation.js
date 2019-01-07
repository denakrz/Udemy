import React, { Component } from 'react'; // importo toda la libreria
import Location from './Location'; // importo componente
import WeatherData from './Data/WeatherData';
import {SUN} from '../constants/weathers';
import './styleLoc.css';

const location = 'Buenos Aires,ar';
const api_key = '8869135e9f8c76358c0e415c4c1cee83';
const api_weather = `http://api.openweathermap.org/data/2.5/weather?q=${location}&appid=${api_key}`;  // con tilde invertida taradaaaaaa

const data1 = {
    temperature: 20,
    weatherState: SUN,
    humidity: 10,
    wind: '10m/s',
};

class WeatherLocation extends Component { 
    
    constructor() {
        super();
        this.state = {
            city: 'Buenos Aires',
            data: data1
        };
    }

    handleUpdateClick  = () => {
        fetch(api_weather).then( data => {
            console.log(data);
            return data.json(); // obtengo el valor del retorno
    }).then( weather_data => {
        console.log(weather_data);
        debugger;
    }); // para pegarle a la APi
    }

    render = () => { // función estilo ecmascript 2015
        const {city, data} = this.state;
        return(
            <div className='weatherLocationCont'> 
                <Location city={this.state.city} />
                <WeatherData data={this.state.data} /> 
                <button onClick={this.handleUpdateClick}> Actualizar </button>
            </div>
        )
    }; // debería aparecer Buenos aires + data // función que devuelve un div
};

export default WeatherLocation; // para que se pueda ver desde afuera

// class component: manejan el ciclo de vida de react, tienen atributos que los componentes funcionales no.

