import React from 'react';

const FooterItem = (props) => {
    return (
        <div>
            <p className='m-3'>&copy; {props.datePart}</p>
        </div>
    )
}

export default FooterItem;