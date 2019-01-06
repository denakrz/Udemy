import React from 'react';
import WeatherTeperature from './WeatherTemperature';
import WeatherExtraInfo from './WeatherExtraInfo';
import {SNOW} from './constants/weathers';

const WeatherData = () => (
   <div>
        <WeatherTeperature temperature={20} weatherState={SNOW}/>
        <WeatherExtraInfo humidity={80} wind={'10m/s'}/>
    </div>
);

export default WeatherData;