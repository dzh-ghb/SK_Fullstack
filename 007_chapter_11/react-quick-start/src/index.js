import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

const getRandom = () => Math.round(Math.random() * 10);

const root = ReactDOM.createRoot(document.getElementById('root'));
const firstName = "d";
const lastName = "zh";
// const val = `100%`;
const arr = [19, 20, 28];
const currentYear = new Date().getFullYear();

root.render(
  // div>h1{DZHITS}+ul>li*5>{NDBT} // без пробелов!
  <div>
    <h1>DZHITS</h1>
    <h2>NDBT</h2>
    <h3>{firstName} {lastName}</h3>
    <ul>
      {
        // arr.map(item => (<li>{item}</li>)) // работа с массивом
        // Array.from({ length: 10 }, (_, index) => // если val не используем - заменяем на "_"
        //   <li>{`Элемент ${index + 1}`}</li>)
        Array.from({ length: 10 }, (_, index) =>
          <li>{`Элемент ${getRandom() % 2 === 0 ? 'EVEN' : 'ODD'}`}</li>)
      }
    </ul>
    {/* {<ul>
      <li>{val}</li>
      <li>{arr[0]}</li>
    </ul>} */}
    <p>&copy; {currentYear}</p>
  </div>
);

// сверху то же самое через React - проще, удобнее, компактнее
// const h1Element = document.createElement("h1");
// h1Element.innerText = 'DZHITS_NDBT';
// const root = document.getElementById('root');
// root.appendChild(h1Element);