import React from 'react';

const currentYear = new Date().getFullYear();

const FooterItem = () => {
    return (
        <div>
            <p className='m-3'>&copy; {currentYear}</p>
        </div>
    )
}

export default FooterItem;