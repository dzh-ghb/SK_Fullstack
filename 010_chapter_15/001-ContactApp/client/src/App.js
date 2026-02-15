import axios from "axios";
import React, { useState, useEffect } from "react";
import TableContact from "./layout/TableContact/TableContact";
import FormContact from "./layout/FormContact/FormContact";
import { Route, Routes } from "react-router-dom";
import ContactDetails from "./layout/ContactDetails/ContactDetails";

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {
  const [contacts, setContacts] = useState([]);

  // GET-запрос
  const url = `${baseApiUrl}/contacts`;
  useEffect(() => {
    axios.get(url).then(
      res => setContacts(res.data)
    );
  }, []);

  const isEmptyArray = (array) => {
    return Array.isArray(array) && array.length === 0;
  }

  const addContact = (contactName, contactPhoneNumber, contactEmail) => {
    // const newId = isEmptyArray(contacts) ? 1 : Math.max(...contacts.map(e => e.id)) + 1;
    const item = {
      // id: newId, // идентификаторы выдает БД, передавать его от клиента серверу не нужно
      name: contactName,
      phoneNumber: contactPhoneNumber,
      email: contactEmail
    };
    // POST-запрос
    const url = `${baseApiUrl}/contacts`;
    // второй параметр - тело запроса
    axios.post(url, item).then(
      response => setContacts([...contacts, response.data])
    ); // ожидание ответа от сервера
  }

  const deleteContact = (id) => {
    // DELETE-запрос
    const url = `${baseApiUrl}/contacts/${id}`;
    axios.delete(url);

    setContacts(contacts.filter(item => item.id !== id));
  }

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
                deleteContact={deleteContact} />
              <FormContact addContact={addContact} />
            </div>
          </div>
        } />
        <Route path="contact/:id" element={<ContactDetails />} />
      </Routes>
    </div>
  );
}

export default App;
