import React from "react";
import RowTableContact from "./components/RowTableContact";

const TableContact = (props) => {
    return (
        <table className="table table-hover">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Имя контакта</th>
                    <th>Номер телефона</th>
                    {/* скрытие поля email на небольших экранах */}
                    <th className="d-none d-md-table-cell">E-mail</th>
                    <th></th> {/* пустое поля над столбцом с кнопками - для корректного отображения */}
                </tr>
            </thead>
            <tbody>
                {
                    props.contacts.map(
                        item =>
                        (<RowTableContact
                            key={item.id}
                            id={item.id}
                            name={item.name}
                            phoneNumber={item.phoneNumber}
                            email={item.email}
                        // deleteContact={props.deleteContact}
                        />)
                    )
                }
            </tbody>
        </table>
    );
}

export default TableContact;