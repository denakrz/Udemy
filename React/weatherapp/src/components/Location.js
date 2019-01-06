import React from 'react';

const Location = ({city}) => {  // para pasarle variable city x destructuring
    
    // console.log(props);
    // debugger; // es como poner un breakpoint en Chrome

    return (
        <div>
            <h1>
                {city}
            </h1>
        </div>
    );

};

export default Location;