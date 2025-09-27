import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <h1>DZHITS_NDBT</h1>
);

// сверху то же самое через React - проще, удобнее, компактнее
// const h1Element = document.createElement("h1");
// h1Element.innerText = 'DZHITS_NDBT';
// const root = document.getElementById('root');
// root.appendChild(h1Element);