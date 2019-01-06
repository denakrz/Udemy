import React from 'react'; // importo toda la libreria
import Location from './Location'; // importo componente
import WearherData from './WeatherData';

const WeatherLocation = () => ( // función estilo ecmascript 2015
    <div> 
        <Location city={'Buenos Aires'} />
        <WearherData /> 
    </div> // debería aparecer Buenos aires + data
); // función que devuelve un div

export default WeatherLocation; // para que se pueda ver desde afuera

