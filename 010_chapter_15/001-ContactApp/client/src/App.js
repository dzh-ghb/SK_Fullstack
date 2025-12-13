import TableContact from "./layout/TableContact/TableContact";

const contacts = [
  { id: 1, name: "Joe Peach 1", phoneNumber: 1231, email: "duv1@mylo.mda" },
  { id: 2, name: "Joe Peach 2", phoneNumber: 1232, email: "duv2@mylo.mda" },
  { id: 3, name: "Joe Peach 3", phoneNumber: 1233, email: "duv3@mylo.mda" },
];

const addContact = () => {
  const item = {
    id: Math.floor(Math.random() * 100 + 1),
    name: `Joe Peach ${Math.floor(Math.random() * 100 + 1)}`,
    phoneNumber: `123${Math.floor(Math.random() * 100 + 1)}`,
    email: `duv${Math.floor(Math.random() * 100 + 1)}@mylo.mda`
  };
  contacts.push(item);
  console.log(contacts);
}

const App = () => {
  return (
    <div className="container mt-5">
      <div className="card">
        <div className="card-header">
          <h1>Список контактов</h1>
        </div>

        <div className="card-body">
          <TableContact contacts={contacts} />
          <div>
            <button className="btn btn-primary"
              onClick={() => { addContact() }}>
              Добавить контакт
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
