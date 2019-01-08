import convert from 'convert-units';
import {SUN} from '../constants/weathers';
import WeatherLocation from '../WL/WeatherLocation';

const getTemp = kelvin => {
    return convert(kelvin).from('K').to('C').toFixed(2);
}

const getWeatherState = (weather) => {
    return SUN;
}

const transformWeather = (weather_data) => {
    const { humidity, temp } = weather_data.main; // se obtiene de la estructura JSON
    const { speed } = weather_data.wind;
    const weatherState = getWeatherState(this.weather);
    const temperature = getTemp(temp);
    const data = {
        humidity, 
        temperature: this.getTemp(temp),
        weatherState,
        wind: `${speed}m/s`,
    }

    return data;
}

export default transformWeather;
