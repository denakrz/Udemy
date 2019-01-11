import React, { Component, PropTypes } from 'react'; // importo toda la libreria
import CircularProgress from 'material-ui/CircularProgress';
import convert from 'convert-units';
import Location from './Location'; // importo componente
import WeatherData from './Data/WeatherData';
import {SUN} from '../constants/weathers';
import './styleLoc.css';


const api_key = '8869135e9f8c76358c0e415c4c1cee83';
const url = `http://api.openweathermap.org/data/2.5/weather?q=${location}&appid=${api_key}`;  // con tilde invertida taradaaaaaa

class WeatherLocation extends Component { 
    
    constructor({ city }) {
        console.log('constructor');
        super();
        this.state = {
            city,
            data: null
        };
    }

    getTemp = kelvin => {
        return Number(convert(kelvin).from('K').to('C').toFixed(2));
    }

    getWeatherState = (weather) => {
        return SUN;
    }

    getData= (weather_data) => {
        const { humidity, temp } = weather_data.main; // se obtiene de la estructura JSON
        const { speed } = weather_data.wind;
        const weatherState = this.getWeatherState(this.weather);
        const temperature = this.getTemp(temp);
        const data = {
            humidity, 
            temperature,
            weatherState,
            wind: `${speed}m/s`,
        }

        return data;
    }

    handleUpdateClick  = () => {
      
    }

    /* Se invoca una única vez inmediatamente después del constructor, previo a renderizarse */
    componentWillMount() {
        const {city} = this.state;
        const api_weather = `${url}?q-${this.state.city}&appid-${api_key}`;
        fetch(api_weather).then( data => {
            console.log(data);
            return data.json(); // obtengo el valor del retorno
        }).then( weather_data => {
            const data = this.getData(weather_data);
            this.setState({ data });
            console.log(weather_data);
        }); // para pegarle a la APi // se obtiene los datos del clima apenas se inicia la aplicación.
    }

    /* Invocado inmediatamente después de que un componente es insertado, si se requiere 
     cargar data desde un endpoint remoto, es un bueno lugar para instanciar la llamada. */
    componentDidMount() {
        console.log('DidMount');
    }

    /* Se invoca en la actualización, luego se renderiza el componente */
    componentWillUpdate() {
        console.log('Update');
    }

    /* Invocado inmediatamente después de que ocurre la actualización del componenete
    este método no es llamado por el render inicial */
    componentDidUpdate() {
        console.log('DidUpdate');
    }

    render = () => { // función estilo ecmascript 2015
        
        console.log('render');

        const {city, data} = this.state;
        return (
            <div className='weatherLocationCont'> 
                <Location city={city} />
                {data ? <WeatherData data={data} /> :
                    <CircularProgress size= {60} thickness = {4} />}     
            </div>);

    }; // debería aparecer Buenos aires + data // función que devuelve un div
}

/* Lifecycle: 
* constructor
* ComponentWillMount
* render
* DidMount
*
*
* Update
* render
* DidUpdate
*/
WeatherLocation.propTypes = {
    city: PropTypes.string
}

export default WeatherLocation; // para que se pueda ver desde afuera

// class component: manejan el ciclo de vida de react, tienen atributos que los componentes funcionales no.

