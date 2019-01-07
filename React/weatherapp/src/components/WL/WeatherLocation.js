import React, { Component } from 'react'; // importo toda la libreria
import Location from './Location'; // importo componente
import WeatherData from './Data/WeatherData';
import {SUN} from '../constants/weathers';
import './styleLoc.css';

const data1 = {
    temperature: 20,
    weatherState: SUN,
    humidity: 10,
    wind: '10m/s',
};

const data2 = {
    temperature: 15,
    weatherState: SUN,
    humidity: 15,
    wind: '5m/s',
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
        this.setState({
            city: 'Buenos Aires',
            data: data2 
        })
        console.log('actualizado');
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

