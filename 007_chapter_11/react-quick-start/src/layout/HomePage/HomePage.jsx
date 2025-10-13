import React, { useState, useEffect } from 'react';
import axios from 'axios';
import HeaderItem from './components/HeaderItem';
import ContentItem from './components/ContentItem';
import FooterItem from './components/FooterItem';

// url для запроса к сервису с FakeAPI
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
        axios.get(baseUrl) // запрос к сервису
            // .then(res => console.log(res));
            // .then(res => console.log(res.data.slice(0, 5)));
            .then(res => { // обработка полученных данных, в res - ответ от сервиса
                const temp = [];
                res.data.slice(0, 5).forEach( // работа со свойством data со всеми объектами
                    item => { // перебор каждого объекта
                        temp.push({ // заполнение временного объекта нужной модели данных (структуры)
                            id: item.id,
                            cardTitle: item.title.slice(0, 10),
                            cardText: item.body.slice(0, 50)
                        });
                    }
                );
                setLabels(temp); // изменение исходного массива данных labels
            });
    })

    return (
        <div className="container col-8">
            <HeaderItem title={headerTitle} />
            <ContentItem
                setOfLabels={labels} // передачи данных для отображения
                imgSrc={imgSrc}
                imgAlt={imgAlt}
            />
            {/* <button className="btn btn-primary m-3"
                onClick={() => {
                    setLabels([...labels,
                    { id: 1, cardTitle: "New Header #1", cardText: "New Description #1" },
                    ])
                }}>Add element</button> */}
            <FooterItem datePart={datePart} />
        </div>
    )
}

export default HomePage;