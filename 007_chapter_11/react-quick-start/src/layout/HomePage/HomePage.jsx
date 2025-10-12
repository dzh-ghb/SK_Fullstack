import React, { useState, useEffect } from 'react';
import axios from 'axios';
import HeaderItem from './components/HeaderItem';
import ContentItem from './components/ContentItem';
import FooterItem from './components/FooterItem';

// url для запроса к FakeAPI
const baseUrl = "https://jsonplaceholder.typicode.com/posts";

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

    // GET-запрос и вывод результата в консоль
    useEffect(() => {
        axios.get(baseUrl)
            .then(res => console.log(res));
    })

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