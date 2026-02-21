import axios from "axios";
import React, { useState, useEffect } from "react";
import TableContact from "./layout/TableContact/TableContact";
import FormContact from "./layout/FormContact/FormContact";
import { Route, Routes, useLocation } from "react-router-dom";
import ContactDetails from "./layout/ContactDetails/ContactDetails";

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {
  const [contacts, setContacts] = useState([]);

  const location = useLocation(); // объект текущего маршрута, меняется при navigate

  const getContacts = () => {
    const url = `${baseApiUrl}/contacts`;
    axios.get(url).then(
      res => setContacts(res.data)
    );
  }

  // выполняется после рендера, повторяется при изменении зависимости/пути (location)
  useEffect(() => {
    getContacts();
  }, [location.pathname]); // с pathname сработает только при изменении пути (без - сработает и при изменении параметров запроса/хэша и тд)

  const addContact = (contactName, contactPhoneNumber, contactEmail) => {
    const item = {
      name: contactName,
      phoneNumber: contactPhoneNumber,
      email: contactEmail
    };
    const url = `${baseApiUrl}/contacts`;
    // второй параметр - тело запроса
    axios.post(url, item).then(
      response => setContacts([...contacts, response.data])
    ); // ожидание ответа от сервера
  }

  // использовалось при удалении контакта по двойному клику по записи
  // const deleteContact = (id) => {
  //   const url = `${baseApiUrl}/contacts/${id}`;
  //   axios.delete(url).then(prev => {
  //     setContacts(prev =>
  //       prev.filter(item => item.id !== id)
  //     );
  //   }
  //   ).catch(() =>
  //     console.log("Ошибка удаления")
  //   );
  // }

  return (
    <div className="container mt-5">
      <Routes>
        <Route path="/" element={
          <div className="card">
            <div className="card-header">
              <h1>Список контактов</h1>
            </div>

            <div className="card-body">
              <TableContact
                contacts={contacts}
              // deleteContact={deleteContact}
              />
              <FormContact addContact={addContact} />
            </div>
          </div>
        } />
        <Route path="contact/:id" element={<ContactDetails /*deleteContact={deleteContact}*/ />} />
      </Routes>
    </div>
  );
}

export default App;
