import React from 'react';
import HeaderItem from './components/HeaderItem';
import ContentItem from './components/ContentItem';
import FooterItem from './components/FooterItem';

// конструктор
const HomePage = () => {
    const headerTitle = "_DZHITS";

    const labels = [ // массив объектов
        { id: 1, cardTitle: "Header #1", cardText: "Description #1" },
        { id: 2, cardTitle: "Header #2", cardText: "Description #2" },
        { id: 3, cardTitle: "Header #3", cardText: "Description #3" },
        { id: 4, cardTitle: "Header #4", cardText: "Description #4" },
        { id: 5, cardTitle: "Header #5", cardText: "Description #5" },
        { id: 6, cardTitle: "Header #6", cardText: "Description #6" },
        { id: 7, cardTitle: "Header #7", cardText: "Description #7" },
    ];
    const imgSrc = "https://cataas.com/cat?width=";
    const imgAlt = "_NDBT";

    const datePart = new Date().getFullYear();

    return (
        <div className="container col-8">
            <HeaderItem title={headerTitle} />
            <ContentItem
                setOfLabels={labels}
                imgSrc={imgSrc}
                imgAlt={imgAlt}
            />
            <FooterItem datePart={datePart} />
        </div>
    )
}

export default HomePage;