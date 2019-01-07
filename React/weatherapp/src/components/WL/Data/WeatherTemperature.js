import React from 'react';
import WeatherIcons from 'react-weathericons';
import { CLOUD,
    CLOUDY, SUN,
    RAIN, SNOW, 
    WINDY } from '../../constants/weathers';
import PropTypes from 'prop-types';
import './styleData.css';

const stateToIconName = (weatherState) => {
    switch (weatherState) {
        case CLOUD:
            return "cloud";
        case CLOUDY:
            return "cloudy";
        case SUN:
            return "day-sunny";
        case RAIN:
            return "rain";
        case SNOW:
            return "snow";
        case WINDY:
            return "windy";
        default:
            return "day-sunny";
    }
};

const getWeatherIcon = weatherState => {
    return (<WeatherIcons className= "wicon" name={stateToIconName(weatherState)} size="4x" />);
}

const WeatherTemperature = ({temperature, weatherState}) => (
    <div className="weatherTemperatureCont"> 
        {getWeatherIcon(weatherState)}
        <span className="temperature"> {`${temperature} `} </span>
        <span className='temperatureType'>°C </span>
    </div>
);

WeatherTemperature.propTypes = { // para validar
    temperature: PropTypes.number, // que sea un numero
    weatherState: PropTypes.string, // que sea un string
}
export default WeatherTemperature;