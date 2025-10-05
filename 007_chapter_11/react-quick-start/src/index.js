import React from 'react'; // начиная с 18-й версии, импорт необязателен
import ReactDOM from 'react-dom/client';
import './css/index.css';
import HomePage from './layout/HomePage/HomePage';

const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(
  <HomePage />
);
