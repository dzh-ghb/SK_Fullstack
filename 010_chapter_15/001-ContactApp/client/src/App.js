import axios from "axios";
import React, { useState, useEffect } from "react";
import { Route, Routes, useLocation, Link } from "react-router-dom";
import TableContact from "./layout/TableContact/TableContact";
import ContactDetails from "./layout/ContactDetails/ContactDetails";
import Pagination from "./layout/Pagination/Pagination";
import AppendContact from "./layout/FormContact/AppendContact";

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {
  const [contacts, setContacts] = useState([]);

  const [currentPage, setCurrentPage] = useState(1);
  const [totalPages, setTotalPages] = useState(0);
  const [pageSize] = useState(3);

  // СПРАВОЧНО: вариант решения проблемы "не обновления" данных на главной форме после обновления на странице контакта;
  // у меня проблемы нет, так как в .then при выполнении PUT-запроса я передаю колбэк, а не вызываю функцию перехода назад
  // const [updateTrigger, setUpdateTrigger] = useState(0);
  // const handleUpdateTrigger = () => {
  //   setUpdateTrigger(updateTrigger + 1); // далее - передать пропс в ContactDetails и вызвать в .then функции handleUpdate
  // }

  const location = useLocation(); // объект текущего маршрута, меняется при navigate

  // функция переключения (обновления) страниц
  const handlePageChange = (pageNumber) => {
    setCurrentPage(pageNumber); // для примитивов useState срабатывает только при смене значения
  }

  const getContacts = () => {
    // /page?pageNumber=1&pageSize=5
    const url = `${baseApiUrl}/contacts/page?pageNumber=${currentPage}&pageSize=${pageSize}`;
    axios.get(url).then(
      res => {
        setContacts(res.data.contacts);
        setTotalPages(Math.ceil(res.data.totalCount / pageSize));
      }
    );
  }

  // выполняется после рендера, повторяется при изменении зависимости/пути (location)
  useEffect(() => {
    getContacts();
  }, [currentPage, pageSize, location.pathname]); // отслеживание изменения currentPage, pageSize;
  // location с pathname сработает только при изменении пути (без - сработает и при изменении параметров запроса/хэша и тд)

  // СПРАВОЧНО: использовалось при добавлении контакта на главной странице
  // const addContact = (contactName, contactPhoneNumber, contactEmail) => {
  //   const item = {
  //     name: contactName,
  //     phoneNumber: contactPhoneNumber,
  //     email: contactEmail
  //   };
  //   const url = `${baseApiUrl}/contacts`;
  //   // второй параметр - тело запроса
  //   axios.post(url, item); // добавление данных
  //   getContacts(); // повторный GET-запрос для обновления списка контакта и счетчика количества страниц
  // }

  // СПРАВОЧНО: использовалось при удалении контакта по двойному клику по записи
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
              <Pagination
                currentPage={currentPage}
                totalPages={totalPages}
                onPageChange={handlePageChange}
              />
              {/* <FormContact addContact={addContact} /> */}
              <Link to="/append"
                className="btn btn-success mt-3">
                Добавить контакт
              </Link>
            </div>
          </div>
        } />
        {/* :id - параметр маршрута, useParams() возвращает только параметры */}
        <Route path="contact/:id" element={<ContactDetails /*deleteContact={deleteContact}*/ />} />
        <Route path="append" element={<AppendContact baseApiUrl={baseApiUrl} />} />
      </Routes>
    </div>
  );
}

export default App;
