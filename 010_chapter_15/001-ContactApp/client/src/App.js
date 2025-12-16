import React, { useState } from "react";
import TableContact from "./layout/TableContact/TableContact";
import FormContact from "./layout/FormContact/FormContact";

const App = () => {
  const [contacts, setContacts] = useState(
    [
      { id: 7, name: "Joe Peach 1", phoneNumber: 1231, email: "duv1@mylo.mda" },
      { id: 3, name: "Joe Peach 2", phoneNumber: 1232, email: "duv2@mylo.mda" },
      { id: 1, name: "Joe Peach 3", phoneNumber: 1233, email: "duv3@mylo.mda" },
    ]
  );

  const addContact = (contactName, contactPhoneNumber, contactEmail) => {
    // #1 - унификация id через сортировку массива
    // const newId = contacts
    //   .sort((x, y) => x.id - y.id)[contacts.length - 1]
    //   .id + 1;

    // #2 - без сортировки через линейный алгоритм поиска
    // let newId = -1;
    // for (let i = 0; i < contacts.length; i++) {
    //   const elementId = contacts[i].id;
    //   if (elementId > newId) {
    //     newId = elementId;
    //   }
    // }
    // newId++;

    // #3
    const newId = Math.max(...contacts.map(e => e.id)) + 1;

    console.log(newId);
    const item = {
      id: newId,
      name: contactName,
      phoneNumber: contactPhoneNumber,
      email: contactEmail
    };
    setContacts([...contacts, item]);
    console.log(contacts);
  }

  return (
    <div className="container mt-5">
      <div className="card">
        <div className="card-header">
          <h1>Список контактов</h1>
        </div>

        <div className="card-body">
          <TableContact contacts={contacts} />
          <FormContact addContact={addContact} />
        </div>
      </div>
    </div>
  );
}

export default App;
