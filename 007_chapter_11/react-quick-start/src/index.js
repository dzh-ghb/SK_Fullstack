import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

const root = ReactDOM.createRoot(document.getElementById('root'));

const first = "DZHITS";
const second = "NDBT";
const currentYear = new Date().getFullYear();

root.render(
  <div className="container col-8">
    <h1 className='h1-style m-3'>{second}</h1>

    {/* фигурные скобки нужны, так как это JS-вкрапление */}
    {Array.from({ length: 3 }, (_, index) =>
      <div className="card m-3" key={index}>
        <img src={`https://cataas.com/cat?width=${index + 1337}`} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">{first} {'#' + index}</h5>
          <p className="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
        </div>
      </div>
    )}

    <p className='m-3'>&copy; {currentYear}</p>
  </div>
);
