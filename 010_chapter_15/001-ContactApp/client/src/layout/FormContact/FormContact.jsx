import React, { useState } from "react";

const FormContact = (props) => {
    const [contactName, setContactName] = useState("");
    const [contactPhoneNumber, setContactPhoneNumber] = useState("");
    const [contactEmail, setContactEmail] = useState("");

    const submit = () => {
        props.addContact(contactName, contactPhoneNumber, contactEmail);
    }

    return (
        <div>
            <div className="mb-3">
                <form>
                    <div className="mb-3">
                        <label className="form-label">Введите имя:</label>
                        <input className="form-control" type="text"
                            onChange={e => setContactName(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label className="form-label">Введите номер телефона:</label>
                        <input className="form-control" type="text"
                            onChange={e => setContactPhoneNumber(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label className="form-label">Введите адрес электронной почты:</label>
                        <textarea className="form-control" rows={1}
                            onChange={e => setContactEmail(e.target.value)} />
                    </div>
                </form>
            </div>

            <div>
                <button className="btn btn-primary"
                    onClick={() => { submit() }}>
                    Добавить контакт
                </button>
            </div>
        </div >
    );
}

export default FormContact;