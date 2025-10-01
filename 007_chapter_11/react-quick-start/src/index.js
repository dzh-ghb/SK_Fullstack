import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

const root = ReactDOM.createRoot(document.getElementById('root'));

const val1 = 'DZHITS';
const val2 = 'NDBT';
const currentYear = new Date().getFullYear();

root.render(
  <div className='container col-10'>
    <h1 className="m-3" style={{ color: 'green', fontSize: `25px` }}>{val1}</h1>
    <h2 className="h1-style m-3">{val2}</h2>

    {/* фигурные скобки нужны, так как это JS-вкрапление */}
    {Array.from({ length: 5 }, (_, index) =>
      <div className="card m-3" style={{ width: `18rem` }}>
        <img src={`https://cataas.com/cat?width=${320 + index}`} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">Card title</h5>
          <p className="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
        </div>
      </div>)}

    <p className="m-3">&copy; {currentYear}</p>
  </div>
);