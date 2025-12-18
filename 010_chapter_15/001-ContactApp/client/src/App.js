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

  const isEmptyArray = (array) => {
    return Array.isArray(array) && array.length === 0;
  }

  const addContact = (contactName, contactPhoneNumber, contactEmail) => {
    const newId = isEmptyArray(contacts) ? 1 : Math.max(...contacts.map(e => e.id)) + 1;

    const item = {
      id: newId,
      name: contactName,
      phoneNumber: contactPhoneNumber,
      email: contactEmail
    };
    setContacts([...contacts, item]);
  }

  const deleteContact = (id) => {
    setContacts(contacts.filter(item => item.id !== id));
  }

  return (
    <div className="container mt-5">
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
    </div>
  );
}

export default App;
