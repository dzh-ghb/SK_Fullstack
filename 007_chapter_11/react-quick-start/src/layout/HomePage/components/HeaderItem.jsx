import React from 'react';

const HeaderItem = (props) => {
    return (
        <div>
            <h1 className='h1-style m-3'>{props.title}</h1>
        </div>
    )
}

export default HeaderItem;