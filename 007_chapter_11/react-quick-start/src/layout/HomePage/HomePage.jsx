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

    const [labels, setLabels] = useState(
        [
            // { id: 1, cardTitle: "Header #1", cardText: "Description #1" },
        ]
    );

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
            <button className="btn btn-primary m-3"
                onClick={() => {
                    setLabels([...labels,
                    { id: 1, cardTitle: "New Header #1", cardText: "New Description #1" },
                    ])
                }}>Add element</button>
            <FooterItem datePart={datePart} />
        </div>
    )
}

export default HomePage;