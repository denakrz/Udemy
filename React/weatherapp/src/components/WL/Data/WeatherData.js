import React from 'react';
import PropTypes from 'prop-types';
import WeatherTeperature from './WeatherTemperature';
import WeatherExtraInfo from './WeatherExtraInfo';

import './styleData.css';


const WeatherData = ({ data }) => {
    const { temperature, weatherState, humidity, wind } = data;
    return (
        <div className="weatherDataCont"> 
        <WeatherTeperature temperature={temperature} weatherState={weatherState}/>
        <WeatherExtraInfo humidity={humidity} wind={wind} />
    </div>);
};

WeatherData.propTypes = {
    data: PropTypes.shape({
        temperature: PropTypes.number.isRequired,
        weatherState: PropTypes.string.isRequired,
        humidity: PropTypes.number.isRequired,
        wind: PropTypes.string.isRequired,
    }),
}
// para CSS 

export default WeatherData;