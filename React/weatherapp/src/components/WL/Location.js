import React from 'react';
import PropTypes from 'prop-types';
import './styleLoc.css';

const Location = ({city}) => {  // para pasarle variable city x destructuring
    
    // console.log(props);
    // debugger; // es como poner un breakpoint en Chrome

    return (
        <div className='LocationCont'>
            <h1>
                {city}
            </h1>
        </div>
    );

};

Location.propTypes = {
    city: PropTypes.string.isRequired,
}

export default Location;