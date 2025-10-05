import React from 'react';
import HeaderItem from './components/HeaderItem';
import ContentItem from './components/ContentItem';
import FooterItem from './components/FooterItem';

// конструктор
const HomePage = () => {
    return (
        <div className="container col-8">
            <HeaderItem />
            <ContentItem />
            <FooterItem />
        </div>
    )
}

export default HomePage;