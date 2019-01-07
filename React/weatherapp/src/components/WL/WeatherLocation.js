import React, { Component } from 'react'; // importo toda la libreria
import convert from 'convert-units';
import Location from './Location'; // importo componente
import WeatherData from './Data/WeatherData';
import {SUN, CLOUDY} from '../constants/weathers';
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

    getTemp = kelvin => {
        return convert(kelvin).from('K').to('C').toFixed(2);
    }

    getWeatherState = (weather) => {
        return CLOUDY;
    }

    getData= (weather_data) => {
        const { humidity, temp } = weather_data.main; // se obtiene de la estructura JSON
        const { speed } = weather_data.wind;
        const weatherState = this.getWeatherState(this.weather);
        const temperature = this.getTemp(temp);
        const data = {
            humidity, 
            temperature: this.getTemp(temp),
            weatherState,
            wind: `${speed}m/s`,
        }

        return data;
    }

    handleUpdateClick  = () => {
        fetch(api_weather).then( data => {
            console.log(data);
            return data.json(); // obtengo el valor del retorno
    }).then( weather_data => {
        const data = this.getData(weather_data);
        this.setState({ data });
        console.log(weather_data);
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

